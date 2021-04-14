namespace TimeTrackingYoutrack
{
    partial class Form1
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
            this.buttonLoginByToken = new System.Windows.Forms.Button();
            this.textBoxToken = new System.Windows.Forms.TextBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.panelToken = new System.Windows.Forms.Panel();
            this.panelToken.SuspendLayout();
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
            this.panelToken.Controls.Add(this.labelToken);
            this.panelToken.Controls.Add(this.buttonLoginByToken);
            this.panelToken.Location = new System.Drawing.Point(30, 30);
            this.panelToken.Name = "panelToken";
            this.panelToken.Size = new System.Drawing.Size(252, 113);
            this.panelToken.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 510);
            this.Controls.Add(this.panelToken);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelToken.ResumeLayout(false);
            this.panelToken.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLoginByToken;
        private System.Windows.Forms.TextBox textBoxToken;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Panel panelToken;
    }
}

