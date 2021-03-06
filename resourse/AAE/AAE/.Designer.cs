﻿namespace Регистрация
{
    partial class RecoveryPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecoveryPassword));
            this.gradientPanel1 = new Регистрация.GradientPanel();
            this.textBoxNewPassword2 = new System.Windows.Forms.TextBox();
            this.buttonAcceptCode = new System.Windows.Forms.Button();
            this.buttonSendMail = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonRecovery = new System.Windows.Forms.Button();
            this.labelNotification = new System.Windows.Forms.Label();
            this.textBoxNewPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Blue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.gradientPanel1.Controls.Add(this.textBoxNewPassword2);
            this.gradientPanel1.Controls.Add(this.buttonAcceptCode);
            this.gradientPanel1.Controls.Add(this.buttonSendMail);
            this.gradientPanel1.Controls.Add(this.textBoxLogin);
            this.gradientPanel1.Controls.Add(this.buttonExit);
            this.gradientPanel1.Controls.Add(this.buttonBack);
            this.gradientPanel1.Controls.Add(this.buttonRecovery);
            this.gradientPanel1.Controls.Add(this.labelNotification);
            this.gradientPanel1.Controls.Add(this.textBoxNewPassword1);
            this.gradientPanel1.Controls.Add(this.textBoxCode);
            this.gradientPanel1.Controls.Add(this.labelName);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(645, 444);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GradientPanel1_MouseDown);
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GradientPanel1_MouseMove);
            // 
            // textBoxNewPassword2
            // 
            this.textBoxNewPassword2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxNewPassword2.Enabled = false;
            this.textBoxNewPassword2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassword2.Location = new System.Drawing.Point(103, 253);
            this.textBoxNewPassword2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNewPassword2.Name = "textBoxNewPassword2";
            this.textBoxNewPassword2.Size = new System.Drawing.Size(454, 34);
            this.textBoxNewPassword2.TabIndex = 18;
            this.textBoxNewPassword2.TextChanged += new System.EventHandler(this.TextBoxNewPassword2_TextChanged);
            // 
            // buttonAcceptCode
            // 
            this.buttonAcceptCode.BackColor = System.Drawing.Color.Transparent;
            this.buttonAcceptCode.Enabled = false;
            this.buttonAcceptCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcceptCode.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcceptCode.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAcceptCode.Location = new System.Drawing.Point(391, 170);
            this.buttonAcceptCode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAcceptCode.Name = "buttonAcceptCode";
            this.buttonAcceptCode.Size = new System.Drawing.Size(167, 34);
            this.buttonAcceptCode.TabIndex = 17;
            this.buttonAcceptCode.Text = "Подтвердить";
            this.buttonAcceptCode.UseVisualStyleBackColor = false;
            this.buttonAcceptCode.Click += new System.EventHandler(this.ButtonAcceptCode_Click);
            // 
            // buttonSendMail
            // 
            this.buttonSendMail.BackColor = System.Drawing.Color.Transparent;
            this.buttonSendMail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendMail.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendMail.ForeColor = System.Drawing.Color.Transparent;
            this.buttonSendMail.Location = new System.Drawing.Point(391, 129);
            this.buttonSendMail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSendMail.Name = "buttonSendMail";
            this.buttonSendMail.Size = new System.Drawing.Size(167, 34);
            this.buttonSendMail.TabIndex = 16;
            this.buttonSendMail.Text = "Получить код";
            this.buttonSendMail.UseVisualStyleBackColor = false;
            this.buttonSendMail.Click += new System.EventHandler(this.ButtonSendMail_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(104, 130);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.MaxLength = 30;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(271, 34);
            this.textBoxLogin.TabIndex = 15;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(601, 4);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 32);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(0, 4);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(44, 32);
            this.buttonBack.TabIndex = 13;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonRecovery
            // 
            this.buttonRecovery.BackColor = System.Drawing.Color.Transparent;
            this.buttonRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRecovery.Enabled = false;
            this.buttonRecovery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRecovery.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRecovery.ForeColor = System.Drawing.Color.Transparent;
            this.buttonRecovery.Location = new System.Drawing.Point(151, 322);
            this.buttonRecovery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonRecovery.Name = "buttonRecovery";
            this.buttonRecovery.Size = new System.Drawing.Size(340, 57);
            this.buttonRecovery.TabIndex = 11;
            this.buttonRecovery.Text = "Восстановить";
            this.buttonRecovery.UseVisualStyleBackColor = false;
            this.buttonRecovery.Click += new System.EventHandler(this.ButtonRecovery_Click);
            // 
            // labelNotification
            // 
            this.labelNotification.AutoSize = true;
            this.labelNotification.BackColor = System.Drawing.Color.Transparent;
            this.labelNotification.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNotification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelNotification.Location = new System.Drawing.Point(80, 267);
            this.labelNotification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNotification.Name = "labelNotification";
            this.labelNotification.Size = new System.Drawing.Size(0, 38);
            this.labelNotification.TabIndex = 10;
            // 
            // textBoxNewPassword1
            // 
            this.textBoxNewPassword1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxNewPassword1.Enabled = false;
            this.textBoxNewPassword1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassword1.Location = new System.Drawing.Point(104, 213);
            this.textBoxNewPassword1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNewPassword1.MaxLength = 30;
            this.textBoxNewPassword1.Name = "textBoxNewPassword1";
            this.textBoxNewPassword1.Size = new System.Drawing.Size(453, 34);
            this.textBoxNewPassword1.TabIndex = 9;
            this.textBoxNewPassword1.TextChanged += new System.EventHandler(this.TextBoxNewPassword1_TextChanged);
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBoxCode.Enabled = false;
            this.textBoxCode.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCode.Location = new System.Drawing.Point(104, 170);
            this.textBoxCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxCode.MaxLength = 4;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(271, 34);
            this.textBoxCode.TabIndex = 7;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(93, 44);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(448, 59);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Восстановление пароля";
            // 
            // RecoveryPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RecoveryPassword";
            this.Text = "Восстановление пароля";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label labelNotification;
        private System.Windows.Forms.TextBox textBoxNewPassword1;
        private System.Windows.Forms.Button buttonRecovery;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Button buttonSendMail;
        private System.Windows.Forms.Button buttonAcceptCode;
        private System.Windows.Forms.TextBox textBoxNewPassword2;
    }
}