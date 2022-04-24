using System.Diagnostics;
using System.Text.RegularExpressions;
namespace TShutdown
{
    public partial class TShutdownForm : Form
    {
        private string timer = "0";
        private bool shutdownFlag = false;
        private bool isSettingTimer = false;
        private bool IsSettingTimer
        {
            get
            {
                return isSettingTimer;
            }
            set
            {
                isSettingTimer = value;
                if (isSettingTimer)
                {
                    TimerField.Visible = true;
                    ErrorTimerText.Visible = true;
                    TimerShutdownBtn.Visible = true;
                    TimerRestartBtn.Visible = true;
                    TimerField.Focus();
                }
                else
                {
                    TimerField.Visible = false;
                    ErrorTimerText.Visible = false;
                    TimerShutdownBtn.Visible = false;
                    TimerRestartBtn.Visible = false;
                }
            }
        }
        public TShutdownForm()
        {
            InitializeComponent();
        }
        //shutdownFlag true = shut down, false = restart, timer for second
        private void HandleCommandTimer(bool useTimer = false)
        {
            string commandType = "";
            string shutdownKey = "";
            if (shutdownFlag)
            {
                commandType = "shutdown";
                shutdownKey = "/s";
            }
            else
            {
                commandType = "restart";
                shutdownKey = "/r";
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to "+ commandType + "?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(confirm == DialogResult.Yes)
            {
                string currentTimer = useTimer ? timer : "0";
                var psi = new ProcessStartInfo("shutdown", shutdownKey + " /f /t " + currentTimer);
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }
        private void ConvertTimerToSecond()
        {
            string[] timerSlpit = timer.Split(':');
            int timerSlpitLenght = timerSlpit.Length;
            switch (timerSlpitLenght)
            {
                case 1:
                    {
                        break;
                    }
                case 2:
                    {
                        int minutesToSecond = Int32.Parse(timerSlpit[0])*60;
                        int seconds = Int32.Parse(timerSlpit[1]);
                        int totalTime = minutesToSecond + seconds;
                        timer = "" + totalTime;
                        break;
                    }
                case 3:
                    {
                        int hoursToSeconds = Int32.Parse(timerSlpit[0]) * 3600;
                        int minutesToSeconds = Int32.Parse(timerSlpit[1]) * 60;
                        int seconds = Int32.Parse(timerSlpit[2]);
                        int totalTime = hoursToSeconds + minutesToSeconds + seconds;
                        timer = "" + totalTime;
                        break;
                    }
            }

        }
        //our type is hh:mm:ss
        private bool CheckTimerType(string timer)
        {
            string pattern = @"^((\d{2,}:[0-5]?[0-9]:[0-5]?[0-9])|(\d{2,}:[0-5]?[0-9])|\d+)$";
            Regex rgx = new Regex(pattern);
            return rgx.IsMatch(timer);
        }
        private void TimerField_TextChanged(object sender, EventArgs e)
        {
            string currentTimerText = TimerField.Text;
            if (CheckTimerType(currentTimerText))
            {
                timer = currentTimerText;
                ErrorTimerText.Visible = false;
            }
            else
            {
                ErrorTimerText.Visible = true;

            }
        }

        private void ShutdownBtn_Click(object sender, EventArgs e)
        {
            shutdownFlag = true;
            HandleCommandTimer();
        }
        private void RestartBtn_Click(object sender, EventArgs e)
        {
            shutdownFlag = false;
            HandleCommandTimer();
        }
        private void CancelTimerBtnClick(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo("shutdown", "-a");
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
        }

        private void CancelTimer_Click(object sender, EventArgs e)
        {
            IsSettingTimer = !IsSettingTimer;
        }

        private void TimerShutdownBtn_Click(object sender, EventArgs e)
        {
            shutdownFlag = true;
            ConvertTimerToSecond();
            HandleCommandTimer(true);
        }

        private void TimerRestartBtn_Click(object sender, EventArgs e)
        {
            shutdownFlag = false;
            ConvertTimerToSecond();
            HandleCommandTimer(true);
        }
    }
}