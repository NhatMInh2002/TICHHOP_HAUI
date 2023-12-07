namespace N822_6122023
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_Ho = new System.Windows.Forms.TextBox();
            this.txt_Ten = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Rd_Nam = new System.Windows.Forms.RadioButton();
            this.Rd_Nu = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dataBenhNhan = new System.Windows.Forms.DataGridView();
            this.makhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.songay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.txt_MaKhoa = new System.Windows.Forms.TextBox();
            this.cb_TenKhoa = new System.Windows.Forms.ComboBox();
            this.txt_MaBN = new System.Windows.Forms.TextBox();
            this.txt_SoNgay = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataBenhNhan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(298, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÍ BỆNH NHÂN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khoa :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khoa :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã bệnh nhân : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Họ tên: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Họ:";
            // 
            // txt_Ho
            // 
            this.txt_Ho.Location = new System.Drawing.Point(257, 162);
            this.txt_Ho.Name = "txt_Ho";
            this.txt_Ho.Size = new System.Drawing.Size(110, 22);
            this.txt_Ho.TabIndex = 6;
            // 
            // txt_Ten
            // 
            this.txt_Ten.Location = new System.Drawing.Point(432, 162);
            this.txt_Ten.Name = "txt_Ten";
            this.txt_Ten.Size = new System.Drawing.Size(110, 22);
            this.txt_Ten.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(386, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tên:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Giới tính: ";
            // 
            // Rd_Nam
            // 
            this.Rd_Nam.AutoSize = true;
            this.Rd_Nam.Location = new System.Drawing.Point(212, 203);
            this.Rd_Nam.Name = "Rd_Nam";
            this.Rd_Nam.Size = new System.Drawing.Size(58, 21);
            this.Rd_Nam.TabIndex = 10;
            this.Rd_Nam.TabStop = true;
            this.Rd_Nam.Text = "Nam";
            this.Rd_Nam.UseVisualStyleBackColor = true;
            // 
            // Rd_Nu
            // 
            this.Rd_Nu.AutoSize = true;
            this.Rd_Nu.Location = new System.Drawing.Point(344, 203);
            this.Rd_Nu.Name = "Rd_Nu";
            this.Rd_Nu.Size = new System.Drawing.Size(47, 21);
            this.Rd_Nu.TabIndex = 11;
            this.Rd_Nu.TabStop = true;
            this.Rd_Nu.Text = "Nữ";
            this.Rd_Nu.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 17);
            this.label9.TabIndex = 12;
            this.label9.Text = "Số ngày nằm viện :";
            // 
            // dataBenhNhan
            // 
            this.dataBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBenhNhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.makhoa,
            this.tenkhoa,
            this.mabn,
            this.hoten,
            this.gioitinh,
            this.songay});
            this.dataBenhNhan.Location = new System.Drawing.Point(91, 282);
            this.dataBenhNhan.Name = "dataBenhNhan";
            this.dataBenhNhan.RowHeadersWidth = 51;
            this.dataBenhNhan.RowTemplate.Height = 24;
            this.dataBenhNhan.Size = new System.Drawing.Size(648, 169);
            this.dataBenhNhan.TabIndex = 13;
            this.dataBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBenhNhan_CellClick);
            // 
            // makhoa
            // 
            this.makhoa.HeaderText = "Mã khoa";
            this.makhoa.MinimumWidth = 6;
            this.makhoa.Name = "makhoa";
            this.makhoa.Width = 50;
            // 
            // tenkhoa
            // 
            this.tenkhoa.HeaderText = "Tên khoa";
            this.tenkhoa.MinimumWidth = 6;
            this.tenkhoa.Name = "tenkhoa";
            this.tenkhoa.Width = 125;
            // 
            // mabn
            // 
            this.mabn.HeaderText = "Mã bệnh nhân";
            this.mabn.MinimumWidth = 6;
            this.mabn.Name = "mabn";
            this.mabn.Width = 125;
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            this.hoten.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 50;
            // 
            // songay
            // 
            this.songay.HeaderText = "Sô ngày";
            this.songay.MinimumWidth = 6;
            this.songay.Name = "songay";
            this.songay.Width = 125;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(601, 52);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(138, 23);
            this.btn_Them.TabIndex = 14;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(601, 97);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(138, 23);
            this.btn_Sua.TabIndex = 15;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(601, 142);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(138, 23);
            this.btn_Xoa.TabIndex = 16;
            this.btn_Xoa.Text = "Xoá";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(601, 187);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(138, 23);
            this.btn_Tim.TabIndex = 17;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // txt_MaKhoa
            // 
            this.txt_MaKhoa.Location = new System.Drawing.Point(212, 42);
            this.txt_MaKhoa.Name = "txt_MaKhoa";
            this.txt_MaKhoa.Size = new System.Drawing.Size(354, 22);
            this.txt_MaKhoa.TabIndex = 18;
            // 
            // cb_TenKhoa
            // 
            this.cb_TenKhoa.FormattingEnabled = true;
            this.cb_TenKhoa.Items.AddRange(new object[] {
            "Tai mũi họng",
            "Khoa nội",
            "Khoa ngoại"});
            this.cb_TenKhoa.Location = new System.Drawing.Point(212, 83);
            this.cb_TenKhoa.Name = "cb_TenKhoa";
            this.cb_TenKhoa.Size = new System.Drawing.Size(261, 24);
            this.cb_TenKhoa.TabIndex = 19;
            // 
            // txt_MaBN
            // 
            this.txt_MaBN.Location = new System.Drawing.Point(212, 122);
            this.txt_MaBN.Name = "txt_MaBN";
            this.txt_MaBN.Size = new System.Drawing.Size(354, 22);
            this.txt_MaBN.TabIndex = 20;
            // 
            // txt_SoNgay
            // 
            this.txt_SoNgay.Location = new System.Drawing.Point(214, 239);
            this.txt_SoNgay.Name = "txt_SoNgay";
            this.txt_SoNgay.Size = new System.Drawing.Size(354, 22);
            this.txt_SoNgay.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_SoNgay);
            this.Controls.Add(this.txt_MaBN);
            this.Controls.Add(this.cb_TenKhoa);
            this.Controls.Add(this.txt_MaKhoa);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataBenhNhan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Rd_Nu);
            this.Controls.Add(this.Rd_Nam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_Ten);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_Ho);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBenhNhan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Ho;
        private System.Windows.Forms.TextBox txt_Ten;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton Rd_Nam;
        private System.Windows.Forms.RadioButton Rd_Nu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataBenhNhan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.TextBox txt_MaKhoa;
        private System.Windows.Forms.TextBox txt_MaBN;
        private System.Windows.Forms.TextBox txt_SoNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn makhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn songay;
        protected System.Windows.Forms.ComboBox cb_TenKhoa;
    }
}

