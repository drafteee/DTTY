using System.Drawing;

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
            this.panelToken.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 527);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelToken);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "YouTrack";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelToken.ResumeLayout(false);
            this.panelToken.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

