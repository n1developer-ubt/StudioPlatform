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
    class CustomBrowser:IDisposable
    {
        private ChromeDriver _driver;
        private readonly Size _size;
        private readonly Point _point;
        private readonly string _path;
        private readonly Timer _timer;
        private bool _isChecking = false;
        private readonly string _userDataDir;

        public CustomBrowser(string path, string userDataDir, Size size, Point point)
        {
            _userDataDir = userDataDir;
            _path = path;
            _size = size;
            _point = point;
            _timer = new Timer(1000);
            _timer.Elapsed += TimerOnElapsed;
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs e)
        {
            if (_isChecking)
                return;

            _isChecking = true;
            if (IsRunning())
            {
                CheckAndFix();
            }
            else
            {
                _timer.Stop();
                Open();
            }

            _isChecking = false;
        }

        private void CheckAndFix()
        {
            if (_driver.Manage().Window.Position != _point)
            {
                _driver.Manage().Window.Position = _point;
            }

            if (_driver.Manage().Window.Size != _size)
                _driver.Manage().Window.Size = _size;
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

        private ChromeDriver GetDriver(Size s, Point p, string userDataDir = "")
        {
            ChromeOptions op = new  ChromeOptions();
            ChromeDriverService service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            op.AddArgument($"--window-size={s.Width},{s.Height}");
            op.AddArgument($"--window-position={p.X},{p.Y}");
            op.AddArgument($"--app=http://google.nl/");
            op.AddArgument($"--chrome-frame");
            if(!userDataDir.Trim().Equals("")) op.AddArgument($"--user-data-dir={userDataDir}");
            ChromeDriver d = null;
            try
            {
                d = new ChromeDriver(service, op);
                return d;
            }
            catch (Exception e)
            {
                try
                {
                    d?.Quit();
                }
                catch (Exception exception)
                {
                    
                }
                op = new ChromeOptions();
                op.AddArgument($"--window-size={s.Width},{s.Height}");
                op.AddArgument($"--window-position={p.X},{p.Y}");
                op.AddArgument($"--app=http://google.nl/");
                op.AddArgument($"--chrome-frame");
                return new ChromeDriver(service,op);
            }
        }

        public void Open()
        {
            Kill();
            _driver = GetDriver(_size, _point, _userDataDir);
            if(!_path.Trim().Equals(""))
                _driver.Navigate().GoToUrl(_path);
            _driver.Manage().Window.Size = _size;
            _driver.Manage().Window.Position = _point;
            _timer.Enabled = true;
            _isChecking = false;
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

        public void Dispose()
        {
            _timer.Enabled = false;
            _isChecking = true;
            _timer.Stop();
            Kill();
            _timer?.Dispose();
            GC.SuppressFinalize(this);
            GC.WaitForPendingFinalizers();
        }
    }
}
