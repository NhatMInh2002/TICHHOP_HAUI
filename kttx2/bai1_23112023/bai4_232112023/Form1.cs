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

namespace bai4_232112023
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
        string tentep = @"E:\kttx2\bai1_23112023\bai4_232112023\lophoc.xml";

        private void Hienthi()
        {
            datasinhvien.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/lophoc/sinhvien");

            datasinhvien.ColumnCount = 6;
            datasinhvien.Rows.Add();
            int sd = 0;

            foreach (XmlNode sv in ds)
            {
                XmlNode ma_sv = sv.SelectSingleNode("@masv");
                XmlNode tuoi_sv = sv.SelectSingleNode("@tuoi");
                XmlNode ho_ten = sv.SelectSingleNode("hoten");
                XmlNode dia_chi = sv.SelectSingleNode("diachi");
                XmlNode ten_mon = sv.SelectSingleNode("monhoc/tenmon");
                XmlNode diem_sv = sv.SelectSingleNode("monhoc/diem");

                datasinhvien.Rows[sd].Cells[0].Value = ma_sv.InnerText;
                datasinhvien.Rows[sd].Cells[1].Value = tuoi_sv.InnerText;
                datasinhvien.Rows[sd].Cells[2].Value = ho_ten.InnerText;
                datasinhvien.Rows[sd].Cells[3].Value = dia_chi.InnerText;
                datasinhvien.Rows[sd].Cells[4].Value = ten_mon.InnerText;
                datasinhvien.Rows[sd].Cells[5].Value = diem_sv.InnerText;

                datasinhvien.Rows.Add();
                sd++;
            }
        }

        private void datasv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSV.Text = datasinhvien.Rows[d].Cells[0].Value.ToString();
            txtTuoi.Text = datasinhvien.Rows[d].Cells[1].Value.ToString();
            txtHoTen.Text = datasinhvien.Rows[d].Cells[2].Value.ToString();
            txtDiaChi.Text = datasinhvien.Rows[d].Cells[3].Value.ToString();
            txtTenMon.Text = datasinhvien.Rows[d].Cells[4].Value.ToString();
            txtDiem.Text = datasinhvien.Rows[d].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkSV = goc.SelectSingleNode("/lophoc/sinhvien[@masv = '" + txtMaSV.Text + "']");

            if (chkSV != null)
            {
                MessageBox.Show("Trung ma sinh vien roi", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            XmlNode sv = doc.CreateElement("sinhvien");

            XmlAttribute ma_sv = doc.CreateAttribute("masv");
            XmlAttribute tuoi_sv = doc.CreateAttribute("tuoi");
            XmlNode ho_ten = doc.CreateElement("hoten");
            XmlNode dia_chi = doc.CreateElement("diachi");
            XmlNode mon_hoc = doc.CreateElement("monhoc");
            XmlNode ten_mon = doc.CreateElement("tenmon");
            XmlNode diem_sv = doc.CreateElement("diem");


            ma_sv.InnerText = txtMaSV.Text;
            tuoi_sv.InnerText = txtTuoi.Text;
            ho_ten.InnerText = txtHoTen.Text;
            dia_chi.InnerText = txtDiaChi.Text;
            ten_mon.InnerText = txtTenMon.Text;
            diem_sv.InnerText = txtDiem.Text;

            sv.Attributes.Append(ma_sv);
            sv.Attributes.Append(tuoi_sv);
            sv.AppendChild(ho_ten);
            sv.AppendChild(dia_chi);
            mon_hoc.AppendChild(ten_mon);
            mon_hoc.AppendChild(diem_sv);
            sv.AppendChild(mon_hoc);

            goc.AppendChild(sv);

            doc.Save(tentep);
            Hienthi();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkSV = goc.SelectSingleNode("/lophoc/sinhvien[@masv = '" + txtMaSV.Text + "']");

            
            if (chkSV == null)
            {
                MessageBox.Show("Khong tim thay sinh vien", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            goc.RemoveChild(chkSV);

            doc.Save(tentep);
            Hienthi();

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            datasinhvien.Rows.Clear();
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;


            //Tìm theo tuổi
            //int tuoi1 = int.Parse(txtTuoi1.Text);
            //int tuoi2 = int.Parse(txtTuoi2.Text);

            //XmlNodeList Tuoi = goc.SelectNodes("/lophoc/sinhvien[(@tuoi >= " + tuoi1 + ") and (@tuoi <= " + tuoi2 + ")]");

            //if (Tuoi.Count == 0)
            //{
            //    MessageBox.Show("Khong tim thay", "thong bao", MessageBoxButtons.OK);
            //    return;
            //}

            string tenSVcantim = txtHoTen.Text;

            XmlNodeList TenSV = goc.SelectNodes($"/lophoc/sinhvien[hoten[contains(translate(., 'ABCDEFGHIJKLMNOPQRSTUVWXYZ', 'abcdefghijklmnopqrstuvwxyz'), '{tenSVcantim.ToLower()}')]]");

            if (TenSV.Count == 0)
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            datasinhvien.ColumnCount = 6;
            datasinhvien.Rows.Add();
            int sd = 0;

            foreach(XmlNode sv in TenSV)
            {
                XmlNode ma_sv = sv.SelectSingleNode("@masv");
                XmlNode tuoi_sv = sv.SelectSingleNode("@tuoi");
                XmlNode ho_ten = sv.SelectSingleNode("hoten");
                XmlNode dia_chi = sv.SelectSingleNode("diachi");
                XmlNode ten_mon = sv.SelectSingleNode("monhoc/tenmon");
                XmlNode diem_sv = sv.SelectSingleNode("monhoc/diem");

                datasinhvien.Rows[sd].Cells[0].Value = ma_sv.InnerText;
                datasinhvien.Rows[sd].Cells[1].Value = tuoi_sv.InnerText;
                datasinhvien.Rows[sd].Cells[2].Value = ho_ten.InnerText;
                datasinhvien.Rows[sd].Cells[3].Value = dia_chi.InnerText;
                datasinhvien.Rows[sd].Cells[4].Value = ten_mon.InnerText;
                datasinhvien.Rows[sd].Cells[5].Value = diem_sv.InnerText;


                datasinhvien.Rows.Add();
                sd++;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkSV = goc.SelectSingleNode("/lophoc/sinhvien[@masv = '" + txtMaSV.Text + "']");
           
            if (chkSV == null)
            {   
                MessageBox.Show("khong tim thay ma sinh vien", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            XmlNode sv = doc.CreateElement("sinhvien");

            XmlAttribute ma_sv = doc.CreateAttribute("masv");
            XmlAttribute tuoi_sv = doc.CreateAttribute("tuoi");
            XmlNode ho_ten = doc.CreateElement("hoten");
            XmlNode dia_chi = doc.CreateElement("diachi");
            XmlNode mon_hoc = doc.CreateElement("monhoc");
            XmlNode ten_mon = doc.CreateElement("tenmon");
            XmlNode diem_sv = doc.CreateElement("diem");


            ma_sv.InnerText = txtMaSV.Text;
            tuoi_sv.InnerText = txtTuoi.Text;
            ho_ten.InnerText = txtHoTen.Text;
            dia_chi.InnerText = txtDiaChi.Text;
            ten_mon.InnerText = txtTenMon.Text;
            diem_sv.InnerText = txtDiem.Text;

            sv.Attributes.Append(ma_sv);
            sv.Attributes.Append(tuoi_sv);
            sv.AppendChild(ho_ten);
            sv.AppendChild(dia_chi);
            sv.AppendChild(mon_hoc);
            mon_hoc.AppendChild(ten_mon);
            mon_hoc.AppendChild(diem_sv);
            

            goc.ReplaceChild(sv, chkSV);

            doc.Save(tentep);
            Hienthi();
        }
    }
}
