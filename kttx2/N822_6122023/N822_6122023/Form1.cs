using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace N822_6122023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi();
        }
        XmlDocument doc = new XmlDocument();
        string tentep = @"E:\kttx2\N822_6122023\N822_6122023\benhvien.xml";

        private void Hienthi()
        {
            dataBenhNhan.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/benhvien/khoa");

            dataBenhNhan.ColumnCount = 6;
            dataBenhNhan.Rows.Add();
            int sd = 0;
            foreach (XmlNode bn in ds)
            {
                XmlNode ma_khoa = bn.SelectSingleNode("@makhoa");
                XmlNode ten_khoa = bn.SelectSingleNode("tenkhoa");
                XmlNode ma_bn = bn.SelectSingleNode("benhnhan/mabn");
                XmlNode ho_bn = bn.SelectSingleNode("benhnhan/hoten/ho");
                XmlNode ten_bn = bn.SelectSingleNode("benhnhan/hoten/ten");
                XmlNode gioi_tinh = bn.SelectSingleNode("benhnhan/gioitinh");
                XmlNode so_ngay = bn.SelectSingleNode("benhnhan/songay");

                dataBenhNhan.Rows[sd].Cells[0].Value = ma_khoa.InnerText;
                dataBenhNhan.Rows[sd].Cells[1].Value = ten_khoa.InnerText;
                dataBenhNhan.Rows[sd].Cells[2].Value = ma_bn.InnerText;
                dataBenhNhan.Rows[sd].Cells[3].Value = ho_bn.InnerText + " " + ten_bn.InnerText;
                dataBenhNhan.Rows[sd].Cells[4].Value = gioi_tinh.InnerText;
                dataBenhNhan.Rows[sd].Cells[5].Value = so_ngay.InnerText;

                dataBenhNhan.Rows.Add();
                sd++;
            }
        }
        private void dataBenhNhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_MaKhoa.Text = dataBenhNhan.Rows[d].Cells[0].Value.ToString();
            cb_TenKhoa.Text = dataBenhNhan.Rows[d].Cells[1].Value.ToString();
            txt_MaBN.Text = dataBenhNhan.Rows[d].Cells[2].Value.ToString();
            string hoTen = dataBenhNhan.Rows[d].Cells[3].Value.ToString();
            string[] HoTen = hoTen.Split(' ');
            txt_Ho.Text = HoTen[0]; // Họ
            txt_Ten.Text = HoTen[1]; // Tên
            string gioitinh = dataBenhNhan.Rows[d].Cells[4].Value.ToString();
            if (gioitinh == "Nam" ? Rd_Nam.Checked = true : Rd_Nu.Checked = true) ;
            txt_SoNgay.Text = dataBenhNhan.Rows[d].Cells[5].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkBN = goc.SelectSingleNode("/benhvien/khoa[@makhoa='" + txt_MaKhoa.Text + "']");
            if (chkBN != null)
            {
                MessageBox.Show("Trung ma khoa roi", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            XmlNode bn = doc.CreateElement("khoa");
            XmlAttribute ma_khoa = doc.CreateAttribute("makhoa");
            XmlNode ten_khoa = doc.CreateElement("tenkhoa");
            XmlNode benh_nhan = doc.CreateElement("benhnhan");
            XmlNode ma_bn = doc.CreateElement("mabn");
            XmlNode ho_ten = doc.CreateElement("hoten");
            XmlNode ho_bn = doc.CreateElement("ho");
            XmlNode ten_bn = doc.CreateElement("ten");
            XmlNode gioi_tinh = doc.CreateElement("gioitinh");
            XmlNode so_ngay = doc.CreateElement("songay");

            ma_khoa.InnerText = txt_MaKhoa.Text;
            ten_khoa.InnerText = cb_TenKhoa.Text;
            ma_bn.InnerText = txt_MaBN.Text;
            ho_bn.InnerText = txt_Ho.Text;
            ten_bn.InnerText = txt_Ho.Text;
            if (Rd_Nam.Checked) gioi_tinh.InnerText = "Nam";
            if (Rd_Nu.Checked) gioi_tinh.InnerText = "Nữ";
            so_ngay.InnerText = txt_SoNgay.Text;

            bn.Attributes.Append(ma_khoa);
            bn.AppendChild(ten_khoa);
            bn.AppendChild(benh_nhan);
            benh_nhan.AppendChild(ma_bn);
            benh_nhan.AppendChild(ho_ten);
            ho_ten.AppendChild(ho_bn);
            ho_ten.AppendChild(ten_bn);
            benh_nhan.AppendChild(gioi_tinh);
            benh_nhan.AppendChild(so_ngay);

            goc.AppendChild(bn);
            doc.Save(tentep);
            Hienthi();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkBN = goc.SelectSingleNode("/benhvien/khoa[@makhoa='" + txt_MaKhoa.Text + "']");
            if (chkBN == null)
            {
                MessageBox.Show("Ma chua ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            chkBN.SelectSingleNode("tenkhoa").InnerText = cb_TenKhoa.Text;
            chkBN.SelectSingleNode("benhnhan/mabn").InnerText = txt_MaBN.Text;
            chkBN.SelectSingleNode("benhnhan/hoten/ho").InnerText = txt_Ho.Text;
            chkBN.SelectSingleNode("benhnhan/hoten/ten").InnerText = txt_Ten.Text;
            chkBN.SelectSingleNode("benhnhan/gioitinh").InnerText = Rd_Nam.Checked ? "Nam" : "Nữ";
            chkBN.SelectSingleNode("benhnhan/songay").InnerText = txt_SoNgay.Text;

            doc.Save(tentep);
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkBN = goc.SelectSingleNode("/benhvien/khoa[@makhoa='" + txt_MaKhoa.Text + "']");
            if (chkBN == null)
            {
                MessageBox.Show("Ma chua ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                goc.RemoveChild(chkBN);
            }
            doc.Save(tentep);
            Hienthi();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            dataBenhNhan.Rows.Clear();


            XmlNodeList BN = goc.SelectNodes("/benhvien/khoa[@makhoa='" + txt_MaKhoa.Text + "']");
            if (BN.Count == 0)
            {
                MessageBox.Show("Khong co benh nhan trong khoa nay ", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            dataBenhNhan.ColumnCount = 6;
            dataBenhNhan.Rows.Add();
            int sd = 0;

            foreach (XmlNode bn in BN )
            {
                XmlNode ma_khoa = bn.SelectSingleNode("@makhoa");
                XmlNode ten_khoa = bn.SelectSingleNode("tenkhoa");
                XmlNode ma_bn = bn.SelectSingleNode("benhnhan/mabn");
                XmlNode ho_bn = bn.SelectSingleNode("benhnhan/hoten/ho");
                XmlNode ten_bn = bn.SelectSingleNode("benhnhan/hoten/ten");
                XmlNode gioi_tinh = bn.SelectSingleNode("benhnhan/gioitinh");
                XmlNode so_ngay = bn.SelectSingleNode("benhnhan/songay");

                dataBenhNhan.Rows[sd].Cells[0].Value = ma_khoa.InnerText;
                dataBenhNhan.Rows[sd].Cells[1].Value = ten_khoa.InnerText;
                dataBenhNhan.Rows[sd].Cells[2].Value = ma_bn.InnerText;
                dataBenhNhan.Rows[sd].Cells[3].Value = ho_bn.InnerText + " " + ten_bn.InnerText;
                dataBenhNhan.Rows[sd].Cells[4].Value = gioi_tinh.InnerText;
                dataBenhNhan.Rows[sd].Cells[5].Value = so_ngay.InnerText;

                dataBenhNhan.Rows.Add();
                sd++;
            }
        }


    }
}
