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

namespace bai5_23112023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument doc = new XmlDocument();
        string tentep = @"E:\kttx2\bai1_23112023\bai5_23112023\data.xml";

        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void Hienthi()
        {
            datasach.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/thuvien/sach");

            datasach.ColumnCount = 5;
            datasach.Rows.Add();
            int sd = 0;

            foreach (XmlNode sv in ds)
            {
                XmlNode ma_sach = sv.SelectSingleNode("@masach");
                XmlNode ten_sach = sv.SelectSingleNode("tensach");
                XmlNode so_trang = sv.SelectSingleNode("sotrang");
                XmlNode dia_chi = sv.SelectSingleNode("tacgia/diachi");
                XmlNode ho_ten = sv.SelectSingleNode("tacgia/hoten");

                datasach.Rows[sd].Cells[0].Value = ma_sach.InnerText;
                datasach.Rows[sd].Cells[1].Value = ten_sach.InnerText;
                datasach.Rows[sd].Cells[2].Value = so_trang.InnerText;
                datasach.Rows[sd].Cells[3].Value = ho_ten.InnerText;
                datasach.Rows[sd].Cells[4].Value = dia_chi.InnerText;

                datasach.Rows.Add();
                sd++;
            }
        }

        private void datasach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSach.Text = datasach.Rows[d].Cells[0].Value.ToString();
            txtTenSach.Text = datasach.Rows[d].Cells[1].Value.ToString();
            txtSoTrang.Text = datasach.Rows[d].Cells[2].Value.ToString();
            txtDiaChi.Text = datasach.Rows[d].Cells[3].Value.ToString();
            txtHoTen.Text = datasach.Rows[d].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                doc.Load(tentep);
                XmlElement goc = doc.DocumentElement;

                XmlNode chkMS = goc.SelectSingleNode("/thuvien/sach[@masach= '" + txtMaSach.Text + "']");
                if (chkMS != null)
                {
                    MessageBox.Show("Ma sach nay da ton tai", "Thong bao", MessageBoxButtons.OK);
                    return;
                }

                XmlNode s = doc.CreateElement("sach");

                XmlAttribute ma_sach = doc.CreateAttribute("masach");
                XmlElement ten_sach = doc.CreateElement("tensach");
                XmlElement so_trang = doc.CreateElement("sotrang");
                XmlElement tac_gia = doc.CreateElement("tacgia");
                XmlElement dia_chi = doc.CreateElement("diachi");
                XmlElement ho_ten = doc.CreateElement("hoten");

                ma_sach.InnerText = txtMaSach.Text;
                ten_sach.InnerText = txtTenSach.Text;
                so_trang.InnerText = txtSoTrang.Text;
                ho_ten.InnerText = txtHoTen.Text;
                dia_chi.InnerText = txtDiaChi.Text;

                s.Attributes.Append(ma_sach);
                s.AppendChild(ten_sach);
                s.AppendChild(so_trang);
                tac_gia.AppendChild(dia_chi);
                tac_gia.AppendChild(ho_ten);
                s.AppendChild(tac_gia);

                goc.AppendChild(s);
                doc.Save(tentep);
                Hienthi();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkMS = goc.SelectSingleNode("/thuvien/sach[@masach= '" + txtMaSach.Text + "']");
            if (chkMS == null)
            {
                MessageBox.Show("khong tim thay ma sach", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            goc.RemoveChild(chkMS);
            doc.Save(tentep);
            Hienthi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkMS = goc.SelectSingleNode("/thuvien/sach[@masach= '" + txtMaSach.Text + "']");
            if (chkMS == null)
            {
                MessageBox.Show("khong tim thay ma sach", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            chkMS.SelectSingleNode("tensach").InnerText = txtTenSach.Text;
            chkMS.SelectSingleNode("sotrang").InnerText = txtSoTrang.Text;
            chkMS.SelectSingleNode("tacgia/hoten").InnerText = txtHoTen.Text;
            chkMS.SelectSingleNode("tacgia/diachi").InnerText = txtDiaChi.Text;

            doc.Save(tentep);
            Hienthi();
        }
    }
}
