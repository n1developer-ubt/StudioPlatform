using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using Timer = System.Timers.Timer;

namespace StudioPlatform
{
    class CustomBrowser
    {
        private ChromeDriver _driver;
        private readonly Size _size;
        private readonly Point _point;
        private readonly string _path;
        private readonly Timer _timer;
        public CustomBrowser(string path, Size size, Point point)
        {
            _path = path;
            _size = size;
            _point = point;
            _timer = new Timer(1000);
            _timer.Elapsed += TimerOnElapsed;
        }

        private bool IsChecking = false;

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            if (IsChecking)
                return;

            IsChecking = true;
            if (IsRunning())
            {
                if (_driver.Manage().Window.Position != _point)
                {
                    _driver.Manage().Window.Position = _point;
                }

                if (_driver.Manage().Window.Size != _size)
                    _driver.Manage().Window.Size = _size;
            }
            else
            {
                _timer.Stop();
                MessageBox.Show("Closed");
                Open();
            }

            IsChecking = false;
        }

        private bool IsRunning()
        {
            try
            {
                bool b = _driver.WindowHandles.Count == 0;
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private ChromeDriver GetDriver(Size s, Point p)
        {
            ChromeOptions op = new  ChromeOptions();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            op.AddArgument($"--window-size={s.Width},{s.Height}");
            op.AddArgument($"--window-position={p.X},{p.Y}");
            return new ChromeDriver(service, op);
        }

        public void Open()
        {
            Kill();
            _driver = GetDriver(_size, _point);
            _driver.Navigate().GoToUrl(_path);
            _timer.Enabled = true;
            _timer.Start();
        }

        private void Kill()
        {
            try
            {
                _driver?.Close();
            }
            catch (Exception e)
            {
                
            }

            try
            {
                _driver?.Quit();
            }
            catch (Exception e)
            {
                
            }
            _driver = null;
        }
        public void Close()
        {
            _driver.Quit();
        }
    }
}
