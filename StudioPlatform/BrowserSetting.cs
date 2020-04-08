using System.Windows.Forms;

namespace StudioPlatform
{
    public partial class BrowserSetting : UserControl
    {
        public BrowserSettingData CurrentData => new BrowserSettingData()
        {
            Address = txtAddress.isEmptyOrHint()?"": txtAddress.Text.Trim(),
            Index = _index,
            UserDataDirectory = txtFolder.isEmptyOrHint()?"":txtFolder.Text.Trim()
        };

        private readonly int _index;
        public BrowserSetting(int index)
        {
            InitializeComponent();
            _index = index;
            lblIndex.Text = _index + "";
        }

        public BrowserSetting(BrowserSettingData data) : this(data.Index)
        {
            if (!data.UserDataDirectory.Trim().Equals(""))
                txtFolder.Text = data.UserDataDirectory;
            if(!data.Address.Trim().Equals(""))
                txtAddress.Text = data.Address;
        }

        private void btnSelectFolder_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog d = new FolderBrowserDialog())
            {
                d.Description = "Select Folder";
                if (d.ShowDialog() == DialogResult.OK)
                {
                    txtFolder.Text = d.SelectedPath;
                }
            }
        }
    }

    public class BrowserSettingData
    {
        public string Address { get; set; }
        public int Index { get; set; }
        public string UserDataDirectory { get; set; }
    }
}
