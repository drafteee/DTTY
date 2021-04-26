﻿using System.Drawing;

namespace TimeTrackingYoutrack
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonLoginByToken = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.panelToken = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTimer = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.startStopTimerPictureBox = new System.Windows.Forms.PictureBox();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Timer(this.components);
            this.panelToken.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTimer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startStopTimerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLoginByToken
            // 
            this.buttonLoginByToken.Location = new System.Drawing.Point(9, 64);
            this.buttonLoginByToken.Name = "buttonLoginByToken";
            this.buttonLoginByToken.Size = new System.Drawing.Size(75, 23);
            this.buttonLoginByToken.TabIndex = 0;
            this.buttonLoginByToken.Text = "Войти";
            this.buttonLoginByToken.UseVisualStyleBackColor = true;
            this.buttonLoginByToken.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxToken
            // 
            this.textBoxToken.Location = new System.Drawing.Point(9, 35);
            this.textBoxToken.Name = "textBoxToken";
            this.textBoxToken.Size = new System.Drawing.Size(217, 23);
            this.textBoxToken.TabIndex = 1;
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Location = new System.Drawing.Point(9, 17);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(87, 15);
            this.labelToken.TabIndex = 2;
            this.labelToken.Text = "Введите токен:";
            // 
            // panelToken
            // 
            this.panelToken.Controls.Add(this.textBoxToken);
            this.panelToken.Controls.Add(this.button1);
            this.panelToken.Controls.Add(this.labelToken);
            this.panelToken.Controls.Add(this.buttonLoginByToken);
            this.panelToken.Location = new System.Drawing.Point(271, 35);
            this.panelToken.Name = "panelToken";
            this.panelToken.Size = new System.Drawing.Size(252, 113);
            this.panelToken.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Notify";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnShowNotify_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(340, 169);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelButtons.Controls.Add(this.panelLogo);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(130, 527);
            this.panelButtons.TabIndex = 5;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelLogo.Size = new System.Drawing.Size(130, 81);
            this.panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panelTimer
            // 
            this.panelTimer.Controls.Add(this.timerLabel);
            this.panelTimer.Controls.Add(this.startStopTimerPictureBox);
            this.panelTimer.Location = new System.Drawing.Point(237, 361);
            this.panelTimer.Name = "panelTimer";
            this.panelTimer.Size = new System.Drawing.Size(338, 100);
            this.panelTimer.TabIndex = 9;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.timerLabel.Location = new System.Drawing.Point(82, 15);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(204, 65);
            this.timerLabel.TabIndex = 9;
            this.timerLabel.Text = "00:00:00";
            // 
            // startStopTimerPictureBox
            // 
            this.startStopTimerPictureBox.BackColor = System.Drawing.SystemColors.Window;
            this.startStopTimerPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startStopTimerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("startStopTimerPictureBox.Image")));
            this.startStopTimerPictureBox.Location = new System.Drawing.Point(17, 19);
            this.startStopTimerPictureBox.Name = "startStopTimerPictureBox";
            this.startStopTimerPictureBox.Size = new System.Drawing.Size(60, 60);
            this.startStopTimerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startStopTimerPictureBox.TabIndex = 8;
            this.startStopTimerPictureBox.TabStop = false;
            this.startStopTimerPictureBox.Click += new System.EventHandler(this.startTimerPictureBox_Click);
            this.startStopTimerPictureBox.MouseLeave += new System.EventHandler(this.onStartStopTimerMouseLeave);
            this.startStopTimerPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.onStartStopTimerMouseMove);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Location = new System.Drawing.Point(340, 249);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(64, 23);
            this.buttonMinimize.TabIndex = 6;
            this.buttonMinimize.Text = "Minimize";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.Interval = 1000;
            this.mainTimer.Tick += new System.EventHandler(this.onTimerTick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 527);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelToken);
            this.Controls.Add(this.panelTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "YouTrack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.panelToken.ResumeLayout(false);
            this.panelToken.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTimer.ResumeLayout(false);
            this.panelTimer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startStopTimerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        private void InitCustomElements()
        {
            this.buttonAccount = new FontAwesome.Sharp.IconButton();


            // 
            // buttonAccount
            // 
            //this.buttonAccount.Location = new System.Drawing.Point(109, 64);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(0, 50);

            this.buttonAccount.TabIndex = 0;
            this.buttonAccount.Text = "Профиль";
            this.buttonAccount.ForeColor = Color.White;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.ImageAlign = ContentAlignment.MiddleLeft;
            this.buttonAccount.TextAlign = ContentAlignment.MiddleLeft;
            this.buttonAccount.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.buttonAccount.IconColor = Color.White;
            this.buttonAccount.IconSize = 32;

            //this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            this.panelButtons.Controls.Remove(this.panelLogo);

            this.panelButtons.Controls.Add(this.buttonAccount);
            this.panelButtons.Controls.Add(this.panelLogo);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginByToken;
        private FontAwesome.Sharp.IconButton buttonAccount;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Panel panelToken;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.PictureBox startStopTimerPictureBox;
        private System.Windows.Forms.Panel panelTimer;
        private System.Windows.Forms.Timer mainTimer;
        private System.Windows.Forms.Label timerLabel;
    }
}

