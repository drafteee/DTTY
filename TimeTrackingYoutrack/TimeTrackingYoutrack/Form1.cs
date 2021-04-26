using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TimeTrackingYoutrack.Services;
using System.Threading;
using System.Reflection;
using System.Net.Http;
using System.Drawing;
using FontAwesome.Sharp;

namespace TimeTrackingYoutrack
{
    public partial class MainForm : Form
    {
        private NotificationService _notificationService;
        private YouTrack _youTrack;
        private Thread _thread;

        private IconButton _btnCurrent;
        private Panel _leftBorderBtn;
        private bool _isMinimize = false;
        private bool _isTimerWorking = false;
        private DateTime _dateTime = new DateTime(0);

        public MainForm()
        {
            InitializeComponent();
            InitCustomElements();

            _leftBorderBtn = new Panel();
            _leftBorderBtn.Size = new Size(8, 50);
            panelButtons.Controls.Add(_leftBorderBtn);
            _notificationService = new NotificationService();
            _youTrack = new YouTrack();

        }


        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();

                _btnCurrent = (IconButton)senderBtn;
                _btnCurrent.BackColor = Color.FromArgb(37, 36, 81);
                _btnCurrent.ForeColor = color;
                _btnCurrent.TextAlign = ContentAlignment.MiddleCenter;
                _btnCurrent.IconColor = color;

                _leftBorderBtn.BackColor = color;
                _leftBorderBtn.Location = new Point(0, _btnCurrent.Location.Y);
                _leftBorderBtn.Visible = true;
                _leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(_btnCurrent != null)
            {
                _btnCurrent.BackColor = Color.FromArgb(28,28,28);
                _btnCurrent.ForeColor = Color.Gainsboro;
                _btnCurrent.TextAlign = ContentAlignment.MiddleLeft;
                _btnCurrent.IconColor = Color.Gainsboro;
            }
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string token = this.textBoxToken.Text;
            UserInfo userInfo = await _youTrack.Login(token);

            if ((userInfo != null) && (!userInfo.Guest))
            {
                MessageBox.Show($"Логин: {userInfo.Login}\nФИО: {userInfo.FullName}", "Успешная авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                panelToken.Visible = false;

            }
            else
            {
                MessageBox.Show($"Произошла ошибка авторизации, токен не распознан", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnShowNotify_Click(object sender, EventArgs e)
        {
            //_notificationService.Show();
            
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            _thread = new Thread(new ThreadStart(HttpListenerYouTrack.Run));
            _thread.IsBackground = true;
            _thread.Start();

            //var auth = _youTrack.LoadJson();
            //if(auth.Token != null)
            //{
            //    panelToken.Visible = false;
            //    Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - Width,
            //           Screen.PrimaryScreen.WorkingArea.Height - Height);
            //    try
            //    {
            //        await _youTrack.Login(auth.Token);
            //    }catch(HttpRequestException ex)
            //    {
            //        MessageBox.Show($"Произошла ошибка авторизации, не найден хост", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }

                

            //    //labelToken.Visible = false;
            //    //buttonLoginByToken.Visible = false;
            //    //textBoxToken.Visible = false;
            //}
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //thread.Interrupt();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.panelButtons.Visible = false;
            //this.panelLogo.Visible = false;
            this.panelToken.Visible = false;
            this.Size = new Size(350, 150);
            _isMinimize = true;
            this.Opacity = 0.5;
            Rectangle workingArea = Screen.GetWorkingArea(this);
            this.Location = new Point(workingArea.Right - Size.Width,
                          workingArea.Bottom - Size.Height);
            this.panelTimer.Location = new Point(0, 0);
            
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_isMinimize)
            {
                //this.Opacity = 1;
            }
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (_isMinimize)
            {
                //this.Opacity = 0.2;
            }
        }

        private void startTimerPictureBox_Click(object sender, EventArgs e)
        {
            if (_isTimerWorking)
            {
                mainTimer.Stop();
                this.startStopTimerPictureBox.Image = Properties.Resources.StartTimerButtomImage;
                _isTimerWorking = false;
            }
            else
            {
                mainTimer.Start();
                this.startStopTimerPictureBox.Image = Properties.Resources.StopTimerButtomImage;
                _isTimerWorking = true;

            }
        }

        private void onStartStopTimerMouseMove(object sender, MouseEventArgs e)
        {
           //this.startStopTimerPictureBox=
        }

        private void onStartStopTimerMouseLeave(object sender, EventArgs e)
        {
        }

        private void onTimerTick(object sender, EventArgs e)
        {
           _dateTime= _dateTime.AddSeconds(1);
            this.timerLabel.Text = _dateTime.ToString("HH:mm:ss");
        }
    }
}

