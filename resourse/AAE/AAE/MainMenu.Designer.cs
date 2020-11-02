namespace Регистрация
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.gradientPanel1 = new Регистрация.GradientPanel();
            this.buttonJournal = new System.Windows.Forms.Button();
            this.buttonEquipment = new System.Windows.Forms.Button();
            this.buttonViewRequest = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateRequest = new System.Windows.Forms.Button();
            this.gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.AutoSize = true;
            this.gradientPanel1.ColorBottom = System.Drawing.Color.Blue;
            this.gradientPanel1.ColorTop = System.Drawing.Color.White;
            this.gradientPanel1.Controls.Add(this.buttonJournal);
            this.gradientPanel1.Controls.Add(this.buttonEquipment);
            this.gradientPanel1.Controls.Add(this.buttonViewRequest);
            this.gradientPanel1.Controls.Add(this.buttonBack);
            this.gradientPanel1.Controls.Add(this.buttonExit);
            this.gradientPanel1.Controls.Add(this.dataGridView1);
            this.gradientPanel1.Controls.Add(this.label1);
            this.gradientPanel1.Controls.Add(this.buttonCreateRequest);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(1088, 587);
            this.gradientPanel1.TabIndex = 0;
            this.gradientPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GradientPanel1_MouseDown);
            this.gradientPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GradientPanel1_MouseMove);
            // 
            // buttonEquipment
            // 
            this.buttonEquipment.BackColor = System.Drawing.Color.Transparent;
            this.buttonEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipment.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquipment.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEquipment.Location = new System.Drawing.Point(527, 436);
            this.buttonEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEquipment.Name = "buttonEquipment";
            this.buttonEquipment.Size = new System.Drawing.Size(340, 57);
            this.buttonEquipment.TabIndex = 20;
            this.buttonEquipment.Text = "Оборудование";
            this.buttonEquipment.UseVisualStyleBackColor = false;
            this.buttonEquipment.Click += new System.EventHandler(this.ButtonEquipment_Click);
            // 
            // buttonJournal
            // 
            this.buttonJournal.BackColor = System.Drawing.Color.Transparent;
            this.buttonJournal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonJournal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonJournal.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonJournal.ForeColor = System.Drawing.Color.Transparent;
            this.buttonJournal.Location = new System.Drawing.Point(395, 406);
            this.buttonJournal.Name = "buttonJournal";
            this.buttonJournal.Size = new System.Drawing.Size(255, 46);
            this.buttonJournal.TabIndex = 21;
            this.buttonJournal.Text = "Журнал";
            this.buttonJournal.UseVisualStyleBackColor = false;
            this.buttonJournal.Click += new System.EventHandler(this.ButtonJournal_Click);
            // 
            // buttonEquipment
            // 
            this.buttonEquipment.BackColor = System.Drawing.Color.Transparent;
            this.buttonEquipment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipment.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEquipment.ForeColor = System.Drawing.Color.Transparent;
            this.buttonEquipment.Location = new System.Drawing.Point(395, 354);
            this.buttonEquipment.Name = "buttonEquipment";
            this.buttonEquipment.Size = new System.Drawing.Size(255, 46);
            this.buttonEquipment.TabIndex = 20;
            this.buttonEquipment.Text = "Оборудование";
            this.buttonEquipment.UseVisualStyleBackColor = false;
            this.buttonEquipment.Click += new System.EventHandler(this.ButtonEquipment_Click);
            // 
            // buttonViewRequest
            // 
            this.buttonViewRequest.BackColor = System.Drawing.Color.Transparent;
            this.buttonViewRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewRequest.Enabled = false;
            this.buttonViewRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonViewRequest.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewRequest.ForeColor = System.Drawing.Color.Transparent;
            this.buttonViewRequest.Location = new System.Drawing.Point(179, 436);
            this.buttonViewRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonViewRequest.Name = "buttonViewRequest";
            this.buttonViewRequest.Size = new System.Drawing.Size(340, 57);
            this.buttonViewRequest.TabIndex = 19;
            this.buttonViewRequest.Text = "Просмотр заявки";
            this.buttonViewRequest.UseVisualStyleBackColor = false;
            this.buttonViewRequest.Click += new System.EventHandler(this.ButtonViewRequest_Click);
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
            this.buttonBack.TabIndex = 18;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.ForeColor = System.Drawing.Color.Black;
            this.buttonExit.Location = new System.Drawing.Point(1000, 4);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 32);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(41, 142);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 260);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(44, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 59);
            this.label1.TabIndex = 14;
            this.label1.Text = "Заявки";
            // 
            // buttonCreateRequest
            // 
            this.buttonCreateRequest.BackColor = System.Drawing.Color.Transparent;
            this.buttonCreateRequest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateRequest.Font = new System.Drawing.Font("Segoe Print", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreateRequest.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCreateRequest.Location = new System.Drawing.Point(361, 500);
            this.buttonCreateRequest.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateRequest.Name = "buttonCreateRequest";
            this.buttonCreateRequest.Size = new System.Drawing.Size(340, 57);
            this.buttonCreateRequest.TabIndex = 12;
            this.buttonCreateRequest.Text = "Создать заявку";
            this.buttonCreateRequest.UseVisualStyleBackColor = false;
            this.buttonCreateRequest.Click += new System.EventHandler(this.Button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 587);
            this.Controls.Add(this.gradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GradientPanel gradientPanel1;
        private System.Windows.Forms.Button buttonCreateRequest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonViewRequest;
        private System.Windows.Forms.Button buttonEquipment;
        private System.Windows.Forms.Button buttonJournal;
    }
}