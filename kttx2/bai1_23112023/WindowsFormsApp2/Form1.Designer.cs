namespace WindowsFormsApp2
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
            this.txt_TenCN = new System.Windows.Forms.TextBox();
            this.txt_SLNV = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaCN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Capnhat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.data_cuahang = new System.Windows.Forms.DataGridView();
            this.macn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tencn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sluongnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Tim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_cuahang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ten chi nhanh: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "So luong nhan vien: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ma san pham";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ten san pham: ";
            // 
            // txt_TenCN
            // 
            this.txt_TenCN.Location = new System.Drawing.Point(236, 142);
            this.txt_TenCN.Name = "txt_TenCN";
            this.txt_TenCN.Size = new System.Drawing.Size(407, 22);
            this.txt_TenCN.TabIndex = 4;
            // 
            // txt_SLNV
            // 
            this.txt_SLNV.Location = new System.Drawing.Point(236, 187);
            this.txt_SLNV.Name = "txt_SLNV";
            this.txt_SLNV.Size = new System.Drawing.Size(407, 22);
            this.txt_SLNV.TabIndex = 5;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(236, 232);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(407, 22);
            this.txt_MaSP.TabIndex = 6;
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(236, 277);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(407, 22);
            this.txt_TenSP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ma chi nhanh: ";
            // 
            // txt_MaCN
            // 
            this.txt_MaCN.Location = new System.Drawing.Point(236, 97);
            this.txt_MaCN.Name = "txt_MaCN";
            this.txt_MaCN.Size = new System.Drawing.Size(407, 22);
            this.txt_MaCN.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(367, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "QUAN LI CHI NHANH ";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(668, 142);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(147, 43);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Them";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Capnhat
            // 
            this.btn_Capnhat.Location = new System.Drawing.Point(668, 206);
            this.btn_Capnhat.Name = "btn_Capnhat";
            this.btn_Capnhat.Size = new System.Drawing.Size(147, 43);
            this.btn_Capnhat.TabIndex = 12;
            this.btn_Capnhat.Text = "Cap nhat";
            this.btn_Capnhat.UseVisualStyleBackColor = true;
            this.btn_Capnhat.Click += new System.EventHandler(this.btn_Capnhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(836, 142);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(147, 43);
            this.btn_Xoa.TabIndex = 13;
            this.btn_Xoa.Text = "Xoa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // data_cuahang
            // 
            this.data_cuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_cuahang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.macn,
            this.tencn,
            this.sluongnv,
            this.masp,
            this.tensp});
            this.data_cuahang.Location = new System.Drawing.Point(91, 323);
            this.data_cuahang.Name = "data_cuahang";
            this.data_cuahang.RowHeadersWidth = 51;
            this.data_cuahang.RowTemplate.Height = 24;
            this.data_cuahang.Size = new System.Drawing.Size(745, 170);
            this.data_cuahang.TabIndex = 14;
            this.data_cuahang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_cuahang_CellClick);
            // 
            // macn
            // 
            this.macn.HeaderText = "Ma chi nhanh";
            this.macn.MinimumWidth = 6;
            this.macn.Name = "macn";
            this.macn.Width = 125;
            // 
            // tencn
            // 
            this.tencn.HeaderText = "Ten chi nhanh";
            this.tencn.MinimumWidth = 6;
            this.tencn.Name = "tencn";
            this.tencn.Width = 125;
            // 
            // sluongnv
            // 
            this.sluongnv.HeaderText = "So luong nhan vien";
            this.sluongnv.MinimumWidth = 6;
            this.sluongnv.Name = "sluongnv";
            this.sluongnv.Width = 125;
            // 
            // masp
            // 
            this.masp.HeaderText = "Ma san pham";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.Width = 125;
            // 
            // tensp
            // 
            this.tensp.HeaderText = "Ten san pham";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.Width = 125;
            // 
            // btn_Tim
            // 
            this.btn_Tim.Location = new System.Drawing.Point(836, 206);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(147, 43);
            this.btn_Tim.TabIndex = 15;
            this.btn_Tim.Text = "Tim";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 522);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.data_cuahang);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Capnhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_MaCN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.txt_SLNV);
            this.Controls.Add(this.txt_TenCN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_cuahang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_TenCN;
        private System.Windows.Forms.TextBox txt_SLNV;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaCN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Capnhat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView data_cuahang;
        private System.Windows.Forms.DataGridViewTextBoxColumn macn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tencn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sluongnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.Button btn_Tim;
    }
}

