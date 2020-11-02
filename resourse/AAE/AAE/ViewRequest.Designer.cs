namespace Регистрация
{
    partial class ViewRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewRequest));
            this.gradientPanel1 = new Регистрация.GradientPanel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDateName = new System.Windows.Forms.Label();
            this.labelEquipmentID = new System.Windows.Forms.Label();
            this.labelEquipmentIDName = new System.Windows.Forms.Label();
            this.labelEmployeeID = new System.Windows.Forms.Label();
            this.labelEmployeeIDName = new System.Windows.Forms.Label();
            this.labelRequestID = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelRequestIDName = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonReject = new System.Windows.Forms.Button();
            this.buttonAcсept = new System.Windows.Forms.Button();
            this.richTextBoxRequest = new System.Windows.Forms.RichTextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Blue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.labelDate);
            this.gradientPanel1.Controls.Add(this.labelDateName);
            this.gradientPanel1.Controls.Add(this.labelEquipmentID);
            this.gradientPanel1.Controls.Add(this.labelEquipmentIDName);
            this.gradientPanel1.Controls.Add(this.labelEmployeeID);
            this.gradientPanel1.Controls.Add(this.labelEmployeeIDName);
            this.gradientPanel1.Controls.Add(this.labelRequestID);
            this.gradientPanel1.Controls.Add(this.textBoxTitle);
            this.gradientPanel1.Controls.Add(this.labelRequestIDName);
            this.gradientPanel1.Controls.Add(this.labelError);
            this.gradientPanel1.Controls.Add(this.buttonExit);
            this.gradientPanel1.Controls.Add(this.buttonReject);
            this.gradientPanel1.Controls.Add(this.buttonAcсept);
            this.gradientPanel1.Controls.Add(this.richTextBoxRequest);
            this.gradientPanel1.Controls.Add(this.labelName);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1036, 588);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseDown);
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gradientPanel1_MouseMove);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(113, 136);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(16, 17);
            this.labelDate.TabIndex = 32;
            this.labelDate.Text = "1";
            // 
            // labelDateName
            // 
            this.labelDateName.AutoSize = true;
            this.labelDateName.Location = new System.Drawing.Point(38, 136);
            this.labelDateName.Name = "labelDateName";
            this.labelDateName.Size = new System.Drawing.Size(42, 17);
            this.labelDateName.TabIndex = 31;
            this.labelDateName.Text = "Дата";
            // 
            // labelEquipmentID
            // 
            this.labelEquipmentID.AutoSize = true;
            this.labelEquipmentID.Location = new System.Drawing.Point(789, 279);
            this.labelEquipmentID.Name = "labelEquipmentID";
            this.labelEquipmentID.Size = new System.Drawing.Size(16, 17);
            this.labelEquipmentID.TabIndex = 30;
            this.labelEquipmentID.Text = "1";
            // 
            // labelEquipmentIDName
            // 
            this.labelEquipmentIDName.AutoSize = true;
            this.labelEquipmentIDName.Location = new System.Drawing.Point(609, 279);
            this.labelEquipmentIDName.Name = "labelEquipmentIDName";
            this.labelEquipmentIDName.Size = new System.Drawing.Size(149, 17);
            this.labelEquipmentIDName.TabIndex = 29;
            this.labelEquipmentIDName.Text = "Номер оборудование";
            // 
            // labelEmployeeID
            // 
            this.labelEmployeeID.AutoSize = true;
            this.labelEmployeeID.Location = new System.Drawing.Point(789, 236);
            this.labelEmployeeID.Name = "labelEmployeeID";
            this.labelEmployeeID.Size = new System.Drawing.Size(16, 17);
            this.labelEmployeeID.TabIndex = 28;
            this.labelEmployeeID.Text = "1";
            // 
            // labelEmployeeIDName
            // 
            this.labelEmployeeIDName.AutoSize = true;
            this.labelEmployeeIDName.Location = new System.Drawing.Point(609, 236);
            this.labelEmployeeIDName.Name = "labelEmployeeIDName";
            this.labelEmployeeIDName.Size = new System.Drawing.Size(131, 17);
            this.labelEmployeeIDName.TabIndex = 27;
            this.labelEmployeeIDName.Text = "Номер сотрудника";
            // 
            // labelRequestID
            // 
            this.labelRequestID.AutoSize = true;
            this.labelRequestID.Location = new System.Drawing.Point(789, 198);
            this.labelRequestID.Name = "labelRequestID";
            this.labelRequestID.Size = new System.Drawing.Size(16, 17);
            this.labelRequestID.TabIndex = 26;
            this.labelRequestID.Text = "1";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(41, 168);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.ReadOnly = true;
            this.textBoxTitle.Size = new System.Drawing.Size(514, 22);
            this.textBoxTitle.TabIndex = 25;
            // 
            // labelRequestIDName
            // 
            this.labelRequestIDName.AutoSize = true;
            this.labelRequestIDName.Location = new System.Drawing.Point(609, 198);
            this.labelRequestIDName.Name = "labelRequestIDName";
            this.labelRequestIDName.Size = new System.Drawing.Size(100, 17);
            this.labelRequestIDName.TabIndex = 24;
            this.labelRequestIDName.Text = "Номер заявки";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(609, 136);
            this.labelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(70, 17);
            this.labelError.TabIndex = 23;
            this.labelError.Text = "labelError";
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(969, 14);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(53, 39);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonReject
            // 
            this.buttonReject.BackColor = System.Drawing.Color.Transparent;
            this.buttonReject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReject.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReject.ForeColor = System.Drawing.Color.Transparent;
            this.buttonReject.Location = new System.Drawing.Point(41, 499);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(5);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(453, 70);
            this.buttonReject.TabIndex = 20;
            this.buttonReject.Text = "Отклонить";
            this.buttonReject.UseVisualStyleBackColor = false;
            this.buttonReject.Click += new System.EventHandler(this.buttonReject_Click);
            // 
            // buttonAcсept
            // 
            this.buttonAcсept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAcсept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcсept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcсept.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcсept.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAcсept.Location = new System.Drawing.Point(537, 499);
            this.buttonAcсept.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAcсept.Name = "buttonAcсept";
            this.buttonAcсept.Size = new System.Drawing.Size(453, 70);
            this.buttonAcсept.TabIndex = 19;
            this.buttonAcсept.Text = "Принять";
            this.buttonAcсept.UseVisualStyleBackColor = false;
            this.buttonAcсept.Click += new System.EventHandler(this.buttonAcсept_Click);
            // 
            // richTextBoxRequest
            // 
            this.richTextBoxRequest.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxRequest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxRequest.Location = new System.Drawing.Point(41, 198);
            this.richTextBoxRequest.Margin = new System.Windows.Forms.Padding(5);
            this.richTextBoxRequest.Name = "richTextBoxRequest";
            this.richTextBoxRequest.ReadOnly = true;
            this.richTextBoxRequest.Size = new System.Drawing.Size(514, 274);
            this.richTextBoxRequest.TabIndex = 17;
            this.richTextBoxRequest.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(106, 52);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(341, 59);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Просморт заявки";
            // 
            // ViewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 588);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewRequest";
            this.Text = "Просмотр запроса";
            this.Load += new System.EventHandler(this.ViewRequest_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.RichTextBox richTextBoxRequest;
        private System.Windows.Forms.Button buttonReject;
        private System.Windows.Forms.Button buttonAcсept;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelRequestIDName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDateName;
        private System.Windows.Forms.Label labelEquipmentID;
        private System.Windows.Forms.Label labelEquipmentIDName;
        private System.Windows.Forms.Label labelEmployeeID;
        private System.Windows.Forms.Label labelEmployeeIDName;
        private System.Windows.Forms.Label labelRequestID;
    }
}