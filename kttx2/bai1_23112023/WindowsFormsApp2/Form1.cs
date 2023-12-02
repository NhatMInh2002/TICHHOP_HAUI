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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        string tentep = @"E:\kttx2\bai1_23112023\WindowsFormsApp2\Cuahang.xml";

        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthi();
        }

        private void Hienthi()
        {
            data_cuahang.Rows.Clear();
            doc.Load(tentep);

            XmlNodeList ds = doc.SelectNodes("/cuahang/chinhanh");
            data_cuahang.ColumnCount = 5;
            data_cuahang.Rows.Add();
            int sd = 0;

            foreach(XmlNode cn in ds)
            {
                XmlNode ma_cn = cn.SelectSingleNode("@macn");
                XmlNode ten_cn = cn.SelectSingleNode("tencn");
                XmlNode so_luong = cn.SelectSingleNode("sluongnv");
                XmlNode ma_sp = cn.SelectSingleNode("sanpham/masp");
                XmlNode ten_sp = cn.SelectSingleNode("sanpham/tensp");

                data_cuahang.Rows[sd].Cells[0].Value = ma_cn.InnerText;
                data_cuahang.Rows[sd].Cells[1].Value = ten_cn.InnerText;
                data_cuahang.Rows[sd].Cells[2].Value = so_luong.InnerText;
                data_cuahang.Rows[sd].Cells[3].Value = ma_sp.InnerText;
                data_cuahang.Rows[sd].Cells[4].Value = ten_sp.InnerText;

                data_cuahang.Rows.Add();
                sd++;
            }
        }

        private void data_cuahang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txt_MaCN.Text = data_cuahang.Rows[d].Cells[0].Value.ToString();    
            txt_TenCN.Text = data_cuahang.Rows[d].Cells[1].Value.ToString();    
            txt_SLNV.Text = data_cuahang.Rows[d].Cells[2].Value.ToString();    
            txt_MaSP.Text = data_cuahang.Rows[d].Cells[3].Value.ToString();    
            txt_TenSP.Text = data_cuahang.Rows[d].Cells[4].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkCN = goc.SelectSingleNode("/cuahang/chinhanh[@macn='" + txt_MaCN.Text + "']");
            if(chkCN != null)
            {
                MessageBox.Show("Trung ma chi nhanh roi", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            XmlNode cn = doc.CreateElement("chinhanh");
            XmlAttribute ma_cn = doc.CreateAttribute("macn");
            XmlNode ten_cn = doc.CreateElement("tencn");
            XmlNode so_luong = doc.CreateElement("sluongnv");
            XmlNode san_pham = doc.CreateElement("sanpham");
            XmlNode ma_sp = doc.CreateElement("masp");
            XmlNode ten_sp = doc.CreateElement("tensp");

            ma_cn.InnerText = txt_MaCN.Text;
            ten_cn.InnerText = txt_TenCN.Text;
            so_luong.InnerText = txt_SLNV.Text;
            ma_sp.InnerText = txt_MaSP.Text;
            ten_sp.InnerText = txt_TenSP.Text;

            cn.Attributes.Append(ma_cn);
            cn.AppendChild(ten_cn);
            cn.AppendChild(so_luong);
            cn.AppendChild(san_pham);
            san_pham.AppendChild(ma_sp);
            san_pham.AppendChild(ten_sp);

            goc.AppendChild(cn);
            doc.Save(tentep);
            Hienthi(); 
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkCN = goc.SelectSingleNode("/cuahang/chinhanh[@macn='" + txt_MaCN.Text + "']");
            if (chkCN == null)
            {
                MessageBox.Show("Chi nhanh chua ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            chkCN.SelectSingleNode("tencn").InnerText = txt_TenCN.Text;
            chkCN.SelectSingleNode("sluongnv").InnerText = txt_SLNV.Text;
            chkCN.SelectSingleNode("sanpham/masp").InnerText = txt_MaSP.Text;
            chkCN.SelectSingleNode("sanpham/tensp").InnerText = txt_TenSP.Text;

            doc.Save(tentep);
            Hienthi();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;

            XmlNode chkCN = goc.SelectSingleNode("/cuahang/chinhanh[@macn='" + txt_MaCN.Text + "']");
            if (chkCN == null)
            {
                MessageBox.Show("Ma chi nhanh khong ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }

            DialogResult res = MessageBox.Show("Bạn có muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                goc.RemoveChild(chkCN);
            }
            doc.Save(tentep);
            Hienthi();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            data_cuahang.Rows.Clear();
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;


            XmlNodeList chkCN = goc.SelectNodes("/cuahang/chinhanh[@macn='" + txt_MaCN.Text + "']");
            if (chkCN.Count == 0 )
            {
                MessageBox.Show("Ma chi nhanh khong ton tai", "Thong bao", MessageBoxButtons.OK);
                return;
            }
            data_cuahang.ColumnCount = 5;
            data_cuahang.Rows.Add();
            int sd = 0;

            foreach (XmlNode cn in chkCN)
            {
                XmlNode ma_cn = cn.SelectSingleNode("@macn");
                XmlNode ten_cn = cn.SelectSingleNode("tencn");
                XmlNode so_luong = cn.SelectSingleNode("sluongnv");
                XmlNode ma_sp = cn.SelectSingleNode("sanpham/masp");
                XmlNode ten_sp = cn.SelectSingleNode("sanpham/tensp");

                data_cuahang.Rows[sd].Cells[0].Value = ma_cn.InnerText;
                data_cuahang.Rows[sd].Cells[1].Value = ten_cn.InnerText;
                data_cuahang.Rows[sd].Cells[2].Value = so_luong.InnerText;
                data_cuahang.Rows[sd].Cells[3].Value = ma_sp.InnerText;
                data_cuahang.Rows[sd].Cells[4].Value = ten_sp.InnerText;

                data_cuahang.Rows.Add();
                sd++;
            }
        }

    }
}
