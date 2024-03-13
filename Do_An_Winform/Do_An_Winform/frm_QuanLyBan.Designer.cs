namespace Do_An_Winform
{
    partial class frm_QuanLyBan
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_QuanLyBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_QuayLai = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.data_Ban = new System.Windows.Forms.DataGridView();
            this.btn_ChoThue = new System.Windows.Forms.Button();
            this.btn_TraBan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SoBan = new System.Windows.Forms.TextBox();
            this.txt_ViTri = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_LoaiBan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_GioThue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GioTra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_DonGia = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.btn_QuayLai);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, -15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 592);
            this.panel1.TabIndex = 0;
            // 
            // btn_QuayLai
            // 
            this.btn_QuayLai.BackColor = System.Drawing.Color.LightCyan;
            this.btn_QuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_QuayLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_QuayLai.ForeColor = System.Drawing.Color.ForestGreen;
            this.btn_QuayLai.Location = new System.Drawing.Point(0, 225);
            this.btn_QuayLai.Name = "btn_QuayLai";
            this.btn_QuayLai.Size = new System.Drawing.Size(188, 50);
            this.btn_QuayLai.TabIndex = 2;
            this.btn_QuayLai.Text = "Quay lại";
            this.btn_QuayLai.UseVisualStyleBackColor = false;
            this.btn_QuayLai.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.CustomFormat = " hh:mm:ss tt  dd/MM/yyyy";
            this.dateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(194, 12);
            this.dateTime.Name = "dateTime";
            this.dateTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTime.ShowUpDown = true;
            this.dateTime.Size = new System.Drawing.Size(362, 40);
            this.dateTime.TabIndex = 1;
            this.dateTime.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // data_Ban
            // 
            this.data_Ban.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.data_Ban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_Ban.Location = new System.Drawing.Point(213, 269);
            this.data_Ban.Name = "data_Ban";
            this.data_Ban.Size = new System.Drawing.Size(665, 279);
            this.data_Ban.TabIndex = 2;
            this.data_Ban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_Ban_CellClick);
            // 
            // btn_ChoThue
            // 
            this.btn_ChoThue.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_ChoThue.Location = new System.Drawing.Point(600, 210);
            this.btn_ChoThue.Name = "btn_ChoThue";
            this.btn_ChoThue.Size = new System.Drawing.Size(128, 53);
            this.btn_ChoThue.TabIndex = 3;
            this.btn_ChoThue.Text = "Cho Thuê";
            this.btn_ChoThue.UseVisualStyleBackColor = false;
            this.btn_ChoThue.Click += new System.EventHandler(this.btn_ChoThue_Click);
            // 
            // btn_TraBan
            // 
            this.btn_TraBan.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_TraBan.Location = new System.Drawing.Point(750, 210);
            this.btn_TraBan.Name = "btn_TraBan";
            this.btn_TraBan.Size = new System.Drawing.Size(128, 53);
            this.btn_TraBan.TabIndex = 4;
            this.btn_TraBan.Text = "Trả bàn";
            this.btn_TraBan.UseVisualStyleBackColor = false;
            this.btn_TraBan.Click += new System.EventHandler(this.btn_TraBan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(210, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số Bàn";
            // 
            // txt_SoBan
            // 
            this.txt_SoBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoBan.Location = new System.Drawing.Point(273, 66);
            this.txt_SoBan.Name = "txt_SoBan";
            this.txt_SoBan.Size = new System.Drawing.Size(87, 24);
            this.txt_SoBan.TabIndex = 7;
            // 
            // txt_ViTri
            // 
            this.txt_ViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ViTri.Location = new System.Drawing.Point(452, 66);
            this.txt_ViTri.Name = "txt_ViTri";
            this.txt_ViTri.ReadOnly = true;
            this.txt_ViTri.Size = new System.Drawing.Size(126, 24);
            this.txt_ViTri.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vị trí";
            // 
            // txt_LoaiBan
            // 
            this.txt_LoaiBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LoaiBan.Location = new System.Drawing.Point(669, 66);
            this.txt_LoaiBan.Name = "txt_LoaiBan";
            this.txt_LoaiBan.ReadOnly = true;
            this.txt_LoaiBan.Size = new System.Drawing.Size(141, 24);
            this.txt_LoaiBan.TabIndex = 11;
            this.txt_LoaiBan.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(597, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Loại Bàn";
            // 
            // txt_GioThue
            // 
            this.txt_GioThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioThue.Location = new System.Drawing.Point(280, 107);
            this.txt_GioThue.Name = "txt_GioThue";
            this.txt_GioThue.ReadOnly = true;
            this.txt_GioThue.Size = new System.Drawing.Size(196, 24);
            this.txt_GioThue.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(210, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Giờ thuê";
            // 
            // txt_GioTra
            // 
            this.txt_GioTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioTra.Location = new System.Drawing.Point(541, 107);
            this.txt_GioTra.Name = "txt_GioTra";
            this.txt_GioTra.ReadOnly = true;
            this.txt_GioTra.Size = new System.Drawing.Size(187, 24);
            this.txt_GioTra.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giờ trả";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TongTien.Location = new System.Drawing.Point(280, 167);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.ReadOnly = true;
            this.txt_TongTien.Size = new System.Drawing.Size(196, 24);
            this.txt_TongTien.TabIndex = 17;
            this.txt_TongTien.TextChanged += new System.EventHandler(this.txt_TongTien_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(210, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng tiền";
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Reset.Location = new System.Drawing.Point(213, 226);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(116, 37);
            this.btn_Reset.TabIndex = 18;
            this.btn_Reset.Text = "Reset time";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_DonGia
            // 
            this.txt_DonGia.BackColor = System.Drawing.Color.Honeydew;
            this.txt_DonGia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DonGia.Location = new System.Drawing.Point(280, 141);
            this.txt_DonGia.Name = "txt_DonGia";
            this.txt_DonGia.ReadOnly = true;
            this.txt_DonGia.Size = new System.Drawing.Size(68, 17);
            this.txt_DonGia.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(210, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "Đơn giá";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 18);
            this.label8.TabIndex = 21;
            this.label8.Text = "/ giờ";
            // 
            // frm_QuanLyBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(905, 569);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_DonGia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.txt_TongTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_GioTra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_GioThue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_LoaiBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ViTri);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SoBan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_TraBan);
            this.Controls.Add(this.btn_ChoThue);
            this.Controls.Add(this.data_Ban);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.panel1);
            this.Name = "frm_QuanLyBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bản";
            this.Load += new System.EventHandler(this.frm_QuanLyBan_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_Ban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_QuayLai;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView data_Ban;
        private System.Windows.Forms.Button btn_TraBan;
        private System.Windows.Forms.Button btn_ChoThue;
        private System.Windows.Forms.TextBox txt_ViTri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SoBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_LoaiBan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_GioThue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GioTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DonGia;
        private System.Windows.Forms.Label label7;
    }
}