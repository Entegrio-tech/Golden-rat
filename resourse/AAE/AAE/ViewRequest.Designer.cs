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
            this.labelError = new System.Windows.Forms.Label();
            this.buttonJournal = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
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
            this.gradientPanel1.Controls.Add(this.labelError);
            this.gradientPanel1.Controls.Add(this.buttonJournal);
            this.gradientPanel1.Controls.Add(this.buttonBack);
            this.gradientPanel1.Controls.Add(this.buttonExit);
            this.gradientPanel1.Controls.Add(this.buttonReject);
            this.gradientPanel1.Controls.Add(this.buttonAcсept);
            this.gradientPanel1.Controls.Add(this.richTextBoxRequest);
            this.gradientPanel1.Controls.Add(this.labelName);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1045, 567);
            this.gradientPanel1.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(375, 412);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(70, 17);
            this.labelError.TabIndex = 23;
            this.labelError.Text = "labelError";
            // 
            // buttonJournal
            // 
            this.buttonJournal.BackColor = System.Drawing.Color.Transparent;
            this.buttonJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJournal.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJournal.ForeColor = System.Drawing.Color.Black;
            this.buttonJournal.Location = new System.Drawing.Point(697, 55);
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.Size = new System.Drawing.Size(282, 43);
            this.buttonJournal.TabIndex = 22;
            this.buttonJournal.Text = "Журнал";
            this.buttonJournal.UseVisualStyleBackColor = false;
            // 
            // buttonBack
            // 
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.ForeColor = System.Drawing.Color.Black;
            this.buttonBack.Location = new System.Drawing.Point(4, 4);
            this.buttonBack.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(44, 32);
            this.buttonBack.TabIndex = 21;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(1001, 4);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 32);
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
            this.buttonReject.Location = new System.Drawing.Point(139, 458);
            this.buttonReject.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReject.Name = "buttonReject";
            this.buttonReject.Size = new System.Drawing.Size(340, 57);
            this.buttonReject.TabIndex = 20;
            this.buttonReject.Text = "Отклонить";
            this.buttonReject.UseVisualStyleBackColor = false;
            // 
            // buttonAcсept
            // 
            this.buttonAcсept.BackColor = System.Drawing.Color.Transparent;
            this.buttonAcсept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAcсept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAcсept.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAcсept.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAcсept.Location = new System.Drawing.Point(537, 458);
            this.buttonAcсept.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAcсept.Name = "buttonAcсept";
            this.buttonAcсept.Size = new System.Drawing.Size(340, 57);
            this.buttonAcсept.TabIndex = 19;
            this.buttonAcсept.Text = "Принять";
            this.buttonAcсept.UseVisualStyleBackColor = false;
            // 
            // richTextBoxRequest
            // 
            this.richTextBoxRequest.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxRequest.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxRequest.Location = new System.Drawing.Point(67, 142);
            this.richTextBoxRequest.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxRequest.Name = "richTextBoxRequest";
            this.richTextBoxRequest.Size = new System.Drawing.Size(912, 250);
            this.richTextBoxRequest.TabIndex = 17;
            this.richTextBoxRequest.Text = "";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(80, 55);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(341, 59);
            this.labelName.TabIndex = 16;
            this.labelName.Text = "Просморт заявки";
            // 
            // ViewRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 567);
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
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonJournal;
        private System.Windows.Forms.Label labelError;
    }
}