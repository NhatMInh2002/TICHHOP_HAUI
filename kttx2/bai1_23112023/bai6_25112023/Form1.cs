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

namespace bai6_25112023
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
        string tentep = @"E:\kttx2\bai1_23112023\bai6_25112023\data.xml";

        private void Hienthi()
        {
            datathuvien.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/thuvien/sach");

            datathuvien.ColumnCount = 5;
            datathuvien.Rows.Add();//đẩy dòng vừa thêm xuống dưới
            int sd = 0;

            foreach (XmlNode s in ds)
            {
                XmlNode ma_sach = s.SelectSingleNode("@masach");
                XmlNode ten_sach = s.SelectSingleNode("tensach");
                XmlNode so_trang = s.SelectSingleNode("sotrang");
                XmlNode ho_ten = s.SelectSingleNode("tacgia/@hoten");
                XmlNode dia_chi = s.SelectSingleNode("tacgia/diachi");

                datathuvien.Rows[sd].Cells[0].Value = ma_sach.InnerText;
                datathuvien.Rows[sd].Cells[1].Value = ten_sach.InnerText;
                datathuvien.Rows[sd].Cells[2].Value = so_trang.InnerText;
                datathuvien.Rows[sd].Cells[3].Value = ho_ten.InnerText;
                datathuvien.Rows[sd].Cells[4].Value = dia_chi.InnerText;

                datathuvien.Rows.Add();
                sd++;
            }
        }

        private void datathuvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSach.Text = datathuvien.Rows[d].Cells[0].Value.ToString();
            txtTenSach.Text = datathuvien.Rows[d].Cells[1].Value.ToString();
            txtSoTrang.Text = datathuvien.Rows[d].Cells[2].Value.ToString();
            txtHoTen.Text = datathuvien.Rows[d].Cells[3].Value.ToString();
            txtDiaChi.Text = datathuvien.Rows[d].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkMS = goc.SelectSingleNode("/thuvien/sach[@masach = '" + txtMaSach.Text + "']");
            if (chkMS != null)
            {
                MessageBox.Show("Ma sach nay da ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            XmlNode s = doc.CreateElement("sach");

            XmlAttribute ma_sach = doc.CreateAttribute("masach");
            XmlNode ten_sach = doc.CreateElement("tensach");
            XmlNode so_trang = doc.CreateElement("sotrang");
            XmlNode tac_gia = doc.CreateElement("tacgia");
            XmlAttribute ho_ten = doc.CreateAttribute("hoten");
            XmlNode dia_chi = doc.CreateElement("diachi");

            ma_sach.InnerText = txtMaSach.Text;
            ten_sach.InnerText = txtTenSach.Text;
            so_trang.InnerText = txtSoTrang.Text;
            ho_ten.InnerText = txtHoTen.Text;
            dia_chi.InnerText = txtDiaChi.Text;

            s.Attributes.Append(ma_sach);
            s.AppendChild(ten_sach);
            s.AppendChild(so_trang);
            tac_gia.Attributes.Append(ho_ten);
            tac_gia.AppendChild(dia_chi);
            s.AppendChild(tac_gia);

            goc.AppendChild(s);
            doc.Save(tentep);
            Hienthi();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkMS = goc.SelectSingleNode("/thuvien/sach[@masach = '" + txtMaSach.Text + "']");
            if (chkMS == null)
            {
                MessageBox.Show("Ma sach nay khong ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            chkMS.SelectSingleNode("tensach").InnerText = txtTenSach.Text;
            chkMS.SelectSingleNode("sotrang").InnerText = txtSoTrang.Text;
            chkMS.SelectSingleNode("tacgia/@hoten").InnerText = txtHoTen.Text;
            chkMS.SelectSingleNode("tacgia/diachi").InnerText = txtDiaChi.Text;


            doc.Save(tentep);
            Hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            datathuvien.Rows.Clear();
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            string tensachCT = txtTenSach.Text;

            XmlNodeList sachCT = goc.SelectNodes("/thuvien/sach[tensach = '"+tensachCT.ToLower()+"']");
            if (sachCT.Count == 0)
            {
                MessageBox.Show("Khong tim thay ten sach nao tuong tu ", "thong bao", MessageBoxButtons.OK);
                return;
            }

            datathuvien.ColumnCount = 5;
            datathuvien.Rows.Add();//đẩy dòng vừa thêm xuống dưới
            int sd = 0;

            foreach (XmlNode s in sachCT)
            {
                XmlNode ma_sach = s.SelectSingleNode("@masach");
                XmlNode ten_sach = s.SelectSingleNode("tensach");
                XmlNode so_trang = s.SelectSingleNode("sotrang");
                XmlNode ho_ten = s.SelectSingleNode("tacgia/@hoten");
                XmlNode dia_chi = s.SelectSingleNode("tacgia/diachi");

                datathuvien.Rows[sd].Cells[0].Value = ma_sach.InnerText;
                datathuvien.Rows[sd].Cells[1].Value = ten_sach.InnerText;
                datathuvien.Rows[sd].Cells[2].Value = so_trang.InnerText;
                datathuvien.Rows[sd].Cells[3].Value = ho_ten.InnerText;
                datathuvien.Rows[sd].Cells[4].Value = dia_chi.InnerText;

                datathuvien.Rows.Add();
                sd++;
            }
        }
    }
}
