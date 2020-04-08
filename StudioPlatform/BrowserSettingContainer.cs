using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudioPlatform
{
    public partial class BrowserSettingContainer : UserControl
    {
        public BrowserSettingContainer()
        {
            InitializeComponent();
        }

        public void Add(int count)
        {
            while (count != 0)
            {
                BrowserSetting s = new BrowserSetting(count--);
                s.Dock = DockStyle.Top;
                s.BackColor = Color.White;

                Panel p  = new Panel();
                p.Height = 10;
                p.Dock = DockStyle.Top;

                this.Controls.Add(s);
                this.Controls.Add(p);
            }
        }

        public List<BrowserSettingData> AllData =>
            Controls.OfType<BrowserSetting>().Select(x => x.CurrentData).ToList();

        public void Add(List<BrowserSettingData> data)
        {
            List<BrowserSettingData> newData = data.OrderByDescending(x => x.Index).ToList();

            foreach (BrowserSettingData browserSettingData in newData)
            {
                BrowserSetting s = new BrowserSetting(browserSettingData);
                s.Dock = DockStyle.Top;
                s.BackColor = Color.White;

                Panel p = new Panel();
                p.Height = 10;
                p.Dock = DockStyle.Top;

                this.Controls.Add(s);
                this.Controls.Add(p);
            }
        }
    }
}
