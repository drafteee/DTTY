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

namespace TimeTrackingYoutrack
{
    public partial class Form1 : Form
    {
        private NotificationService _notificationService;
        public Form1()
        {
            InitializeComponent();
            _notificationService = new NotificationService();
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            string token = this.textBoxToken.Text;
            UserInfo userInfo = null;
            using (var client = new HttpClient())
            {

                var req = new HttpRequestMessage(HttpMethod.Get, "http://sa-yt.ipps.by/api/users/me?fields=$type,banned,email,fullName,guest,id,login,ringId");
                req.Headers.Add("Accept", "application/json");
                req.Headers.Add("Authorization", $"Bearer {token}");
                req.Headers.Add("Cache-Control", "no-cache");

                HttpResponseMessage response = await client.SendAsync(req);
                if (response.IsSuccessStatusCode)
                {
                    string result = response.Content.ReadAsStringAsync().Result;
                    userInfo = JsonConvert.DeserializeObject<UserInfo>(result);

                }
            }
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

        }
    }
}

