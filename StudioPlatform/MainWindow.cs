using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using StudioPlatform.Properties;
using UBTStandardLibrary.Dialog;

namespace StudioPlatform
{
    public partial class MainWindow : UBTStandardLibrary.Forms.N1Form//, IKeyboardHandler
    {
        public MainWindow()
        {
            InitializeComponent();
            CustomBrowser b = new CustomBrowser("chrome://version/", new Size(100,100),new Point(0, 0) );
            b.Open();
        }

        private void DotIt()
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
                        int index = 0;
                        inp = new List<Input>()
                            {
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                                new Input()
                                {
                                    Hint = $"Address {++index}",
                                    Name = $"{index}",
                                    Type = InputType.Text,
                                    Index = index,
                                    IsMandatory = true
                                },
                            };
                    }
                    else
                    {
                        List<Setting> s = JsonConvert.DeserializeObject<List<Setting>>(jsonData);
                        inp = s.Select(x => new Input
                        {
                            Hint = "Address " + x.Index,
                            Index = x.Index,
                            IsMandatory = true,
                            Name = x.Index + "",
                            Type = InputType.Text, 
                            Value = x.Address
                        }).ToList();
                    }

                    InputDialog addressDialog = new InputDialog("Enter Address", inp, this);

                    if (addressDialog.ShowIt() == ResultType.OK)
                    {
                        List<Output> outputs = addressDialog.Output;

                        List<Setting> set = outputs.Select(x => new Setting()
                        {
                            Address = x.Value,
                            Index = Convert.ToInt16(x.Name)
                        }).ToList();

                        Settings.Default.JsonData = JsonConvert.SerializeObject(set);
                        Settings.Default.Save();
                        //LoadIt();
                    }
                }
            }
        }
    }

    class Setting
    {
        public string Address { get; set; }
        public int Index { get; set; }
        public int UserDir { get; set; }
    }
}
