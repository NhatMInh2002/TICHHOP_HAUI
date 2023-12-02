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

namespace WindowsFormsApp1
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
        string tentep = @"E:\kttx2\bai1_23112023\WindowsFormsApp1\Thuvien.xml";//copy full path cua file xml
        private void Hienthi()
        {
            datathuvien.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/thuvien/cuonsach");

            datathuvien.ColumnCount = 5;//so cot trong form 
            datathuvien.Rows.Add();//đẩy dòng vừa thêm xuống dưới
            int sd = 0;

            foreach (XmlNode s in ds)
            {
                XmlNode ma_tacgia = s.SelectSingleNode("tacgia/@matg");
                XmlNode ho_ten = s.SelectSingleNode("tacgia/hoten");
                XmlNode tuoi_tg = s.SelectSingleNode("tacgia/tuoi");
                XmlNode ma_sach = s.SelectSingleNode("masach");
                XmlNode ten_sach = s.SelectSingleNode("tensach");

                datathuvien.Rows[sd].Cells[0].Value = ma_tacgia.InnerText;
                datathuvien.Rows[sd].Cells[1].Value = ho_ten.InnerText;
                datathuvien.Rows[sd].Cells[2].Value = tuoi_tg.InnerText;
                datathuvien.Rows[sd].Cells[3].Value = ma_sach.InnerText;
                datathuvien.Rows[sd].Cells[4].Value = ten_sach.InnerText;

                datathuvien.Rows.Add();
                sd++;
            }
        }
        private void datathuvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaTG.Text = datathuvien.Rows[d].Cells[0].Value.ToString();
            txtHoTen.Text = datathuvien.Rows[d].Cells[1].Value.ToString();
            txtTuoi.Text = datathuvien.Rows[d].Cells[2].Value.ToString();
            txtMaSach.Text = datathuvien.Rows[d].Cells[3].Value.ToString();
            txtTenSach.Text = datathuvien.Rows[d].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkMS = goc.SelectSingleNode("/thuvien/cuonsach[masach = '" + txtMaSach.Text + "']");
            if (chkMS != null)
            {
                MessageBox.Show("Ma sach nay da ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            XmlNode s = doc.CreateElement("cuonsach");

            XmlNode tac_gia = doc.CreateElement("tacgia");
            XmlAttribute ma_tg = doc.CreateAttribute("matg");
            XmlNode ho_ten = doc.CreateElement("hoten");
            XmlNode tuoi_tg = doc.CreateElement("tuoi");
            XmlNode ma_sach = doc.CreateElement("masach");
            XmlNode ten_sach = doc.CreateElement("tensach");

            ma_tg.InnerText = txtMaTG.Text;
            ho_ten.InnerText = txtHoTen.Text;
            tuoi_tg.InnerText = txtTuoi.Text;
            ma_sach.InnerText = txtMaSach.Text;
            ten_sach.InnerText = txtTenSach.Text;

            s.AppendChild(tac_gia);
            tac_gia.Attributes.Append(ma_tg);
            tac_gia.AppendChild(ho_ten);
            tac_gia.AppendChild(tuoi_tg);
            s.AppendChild(ma_sach);
            s.AppendChild(ten_sach);

            goc.AppendChild(s);
            doc.Save(tentep);
            Hienthi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkMS = goc.SelectSingleNode("/thuvien/cuonsach[masach= '" + txtMaSach.Text + "']");
            if (chkMS == null)
            {
                MessageBox.Show("khong tim thay ma sach", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            goc.RemoveChild(chkMS);
            doc.Save(tentep);
            Hienthi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            datathuvien.Rows.Clear();
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            string maTG = txtMaTG.Text;

            XmlNodeList sachCT = goc.SelectNodes("/thuvien/cuonsach[tacgia/@matg = '" + maTG.ToLower() + "']");
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
                XmlNode ma_tacgia = s.SelectSingleNode("tacgia/@matg");
                XmlNode ho_ten = s.SelectSingleNode("tacgia/hoten");
                XmlNode tuoi_tg = s.SelectSingleNode("tacgia/tuoi");
                XmlNode ma_sach = s.SelectSingleNode("masach");
                XmlNode ten_sach = s.SelectSingleNode("tensach");

                datathuvien.Rows[sd].Cells[0].Value = ma_tacgia.InnerText;
                datathuvien.Rows[sd].Cells[1].Value = ho_ten.InnerText;
                datathuvien.Rows[sd].Cells[2].Value = tuoi_tg.InnerText;
                datathuvien.Rows[sd].Cells[3].Value = ma_sach.InnerText;
                datathuvien.Rows[sd].Cells[4].Value = ten_sach.InnerText;

                datathuvien.Rows.Add();
                sd++;
            }
        }
    }
}