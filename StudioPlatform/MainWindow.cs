using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using StudioPlatform.Properties;
using UBTStandardLibrary.Dialog;

namespace StudioPlatform
{
    public partial class MainWindow : UBTStandardLibrary.Forms.N1Form//, IKeyboardHandler
    {
        private const int TaskBarSize = 60;
        private const int Columns = 3;
        private const int Rows = 2;
        private const int Space = 2;
        private readonly List<CustomBrowser> _browsers;
        public MainWindow()
        {
            InitializeComponent();
            _browsers = new List<CustomBrowser>();
            btnKill.Enabled = false;
            sc.Load += ScOnLoad;
        }
        
        private void ScOnLoad(object sender, EventArgs e)
        {
            string set = Settings.Default.JsonData;

            if(set.Trim().Equals(""))
                sc.Add(Rows*Columns);
            else
            {
                try
                {
                    List<BrowserSettingData> data = JsonConvert.DeserializeObject<List<BrowserSettingData>>(set);
                    sc.Add(data);
                }
                catch (Exception exception)
                {
                    sc.Add(Rows*Columns);
                }
            }
        }

        private void AlterButton(bool alter)
        {
            btnStart.Enabled = alter;
            btnKill.Enabled = !alter;
        }

        private void Enable(bool enable)
        {
            btnStart.Enabled = enable;
            btnKill.Enabled = enable;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            Enable(false);
            int height = Screen.PrimaryScreen.Bounds.Height - TaskBarSize;
            int width = Screen.PrimaryScreen.Bounds.Width;

            Point position = new Point(0, 0);
            Size windowSize = new Size(width / Columns, height / Rows - Space);

            int index = 0;
            List<BrowserSettingData> set;
            string jd = Settings.Default.JsonData;

            if (jd.Trim().Equals(""))
            {
                set = new List<BrowserSettingData>();
            }
            else
            {
                set = JsonConvert.DeserializeObject<List<BrowserSettingData>>(Settings.Default.JsonData);
            }
            

            for (int x = 0; x < Rows; x++)
            {
                for (int y = 0; y < Columns; y++)
                {
                    ++index;
                    BrowserSettingData data = set.Find(l => l.Index == index);
                    CustomBrowser b;
                    if (data != null)
                    {
                        b = new CustomBrowser(data.Address, data.UserDataDirectory, windowSize, position);
                    }
                    else
                    {
                        b = new CustomBrowser("chrome://version/", "", windowSize, position);
                    }
                    _browsers.Add(b);
                    b.Open();
                    position.X += width / Columns + Space;
                }

                position.X = 0;
                position.Y += height / Rows + Space;
            }

            AlterButton(false);
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            CloseAll();
        }

        private void CloseAll()
        {
            Enable(false);
            foreach (CustomBrowser browser in _browsers.ToList())
            {
                browser?.Dispose();
                _browsers.Remove(browser);
            }

            AlterButton(true);
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool res = MessageBox.Show("Are you sure?\nAll browser will be closed!", "Warning", MessageBoxButtons.YesNo,
                           MessageBoxIcon.Warning) == DialogResult.No;
            e.Cancel = res;

            if(!res)
            {
                CloseAll();
                Environment.Exit(Environment.ExitCode);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.JsonData = JsonConvert.SerializeObject(sc.AllData);
            Settings.Default.Save();
            MessageBox.Show("Saved", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                InputDialog d = new InputDialog("Enter Password",new List<Input>(){new Input()
                {
                    Index = 0,
                    Hint = "Password",
                    IsMandatory = true,
                    Name = "p",
                    Type = InputType.Password,
                }}, this);

                if (d.ShowIt() == ResultType.OK)
                {
                    string s = d.Output.Find(x => x.Name.Equals("p")).Value;

                    if (!s.Equals("n1developer"))
                    {
                        tabControl1.SelectedIndex = 0;
                    }
                }
                else
                {
                    tabControl1.SelectedIndex = 0;
                }
            }
        }
    }

}
