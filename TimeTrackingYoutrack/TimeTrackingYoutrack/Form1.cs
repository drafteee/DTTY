using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using TimeTrackingYoutrack.Services;
using System.Threading;
using System.Reflection;
using System.Net.Http;
using System.Drawing;

namespace TimeTrackingYoutrack
{
    public partial class MainForm : Form
    {
        private NotificationService _notificationService;
        private YouTrack _youTrack;
        private Thread thread;
        public MainForm()
        {
            InitializeComponent();
            InitCustomElements();
            _notificationService = new NotificationService();
            _youTrack = new YouTrack();
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
            thread = new Thread(new ThreadStart(HttpListenerYouTrack.Run));
            thread.IsBackground = true;
            thread.Start();

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
    }
}

