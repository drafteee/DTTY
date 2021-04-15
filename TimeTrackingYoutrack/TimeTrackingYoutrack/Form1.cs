using Newtonsoft.Json;
﻿using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTrackingYoutrack.Services;
using Windows.ApplicationModel.Activation;
using Windows.Foundation.Collections;
using System.Threading;

namespace TimeTrackingYoutrack
{
    public partial class Form1 : Form
    {
        private NotificationService _notificationService;
        private YouTrack _youTrack;
        private Thread thread;
        public Form1()
        {
            InitializeComponent();
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
            _notificationService.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(HttpListenerYouTrack.Run));

            thread.Start();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }
    }
}

