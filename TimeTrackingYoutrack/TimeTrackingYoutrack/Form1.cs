using Microsoft.Toolkit.Uwp.Notifications;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        
        private void btnShowNotify_Click(object sender, EventArgs e)
        {
            _notificationService.Show();
        }
    }
}
