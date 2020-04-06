using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using StudioPlatform.Properties;
using UBTStandardLibrary.Dialog;

namespace StudioPlatform
{
    public partial class MainWindow : UBTStandardLibrary.Forms.N1Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Cef.Initialize(new CefSettings() {MultiThreadedMessageLoop = false});
            Cef.DoMessageLoopWork();
            CheckForIllegalCrossThreadCalls = false;
            KeyPreview = true;
            pnlBrowsers.KeyDown += OnKeyDown;
            this.KeyDown += OnKeyDown;
            for (int x = 0; x < pnlBrowsers.RowCount; x++)
            {
                for (int y = 0; y < pnlBrowsers.ColumnCount; y++)
                {
                    ChromiumWebBrowser browser = new ChromiumWebBrowser("https://www.n1developer.com");
                    browser.Dock = DockStyle.Fill;
                    browser.Padding = new Padding(5);
                    pnlBrowsers.Controls.Add(browser, y, x);
                }
            }
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.Shift && e.Alt && e.KeyCode == Keys.A)
            {
                InputDialog dialog = new InputDialog("Enter Password", new List<Input>(){new Input()
                {
                    Hint = "Password",
                    Index = 0,
                    Type = InputType.Password,
                    Name = "p"
                }}, this);

                if (dialog.ShowIt() == ResultType.OK)
                {
                    string data = dialog.Output.Find(x => x.Name.Equals("p")).Value;
                    if (data.Equals("n1developer"))
                    {
                        string jsonData = Settings.Default.JsonData;

                        List<Input> inp;

                        if (jsonData.Trim().Equals(""))
                        {
                            inp = new List<Input>();
                        }
                    }
                }
            }
        }
    }

    class Setting
    {
        public string Address { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
    }
}
