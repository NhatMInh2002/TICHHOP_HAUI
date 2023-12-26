using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace L122122023_formgoiapi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Hienthicb();
            Loaddata();

        }
        private void Loaddata()
        {
            string link = "https://localhost:44335/api/sanpham";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Sanpham[]));
            object data = js.ReadObject(response.GetResponseStream());
            Sanpham[] arrsanpham = data as Sanpham[];
            dataGridView1.DataSource = arrsanpham;
        }

        private void Hienthicb()
        {
            string link = "https://localhost:44335/api/danhmuc";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Danhmuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            Danhmuc[] ardanhmuc = data as Danhmuc[];
            cbDM.DataSource = ardanhmuc;
            cbDM.ValueMember = "MaDanhMuc";
            cbDM.DisplayMember = "TenDanhMuc";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int d = e.RowIndex;
            txtMaSP.Text = dataGridView1.Rows[d].Cells[0].ToString();
            txtTenSP.Text = dataGridView1.Rows[d].Cells[1].ToString();
            txtDonGia.Text = dataGridView1.Rows[d].Cells[2].ToString();
            cbDM.Text = dataGridView1.Rows[d].Cells[3].ToString();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            string post = string.Format("?masp={0}&ten={1}&gia={2}&madm={3}", txtMaSP.Text, txtTenSP.Text, txtDonGia.Text, cbDM.SelectedValue);
            string link = "https://localhost:44335/api/sanpham" + post;
            HttpWebRequest req = HttpWebRequest.CreateHttp(link);
            req.Method = "post";
            req.ContentType = "application/jso;";
            byte[] bytes = Encoding.UTF8.GetBytes(post);
            req.ContentLength = bytes.Length;
            Stream datastream = req.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                Loaddata();
                MessageBox.Show("them thanh cong");
            }
            else
            {
                MessageBox.Show("Them that bai");
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string delete = string.Format("?ma={0}", txtMaSP.Text);
            string link = "https://localhost:44335/api/sanpham" + delete;
            HttpWebRequest req = HttpWebRequest.CreateHttp(link);
            req.Method = "DELETE";
            req.ContentType = "application/jso;";
            byte[] bytes = Encoding.UTF8.GetBytes(delete);
            req.ContentLength = bytes.Length;
            Stream datastream = req.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                Loaddata();
                MessageBox.Show("xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string put = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}", txtMaSP.Text, txtTenSP.Text, txtDonGia.Text, cbDM.SelectedValue);
            string link = "https://localhost:44380/api/sanpham/" + put;
            HttpWebRequest req = HttpWebRequest.CreateHttp(link);
            req.Method = "PUT";
            req.ContentType = "application/jso;";
            byte[] bytes = Encoding.UTF8.GetBytes(put);
            req.ContentLength = bytes.Length;
            Stream datastream = req.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(req.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                Loaddata();
                MessageBox.Show("sua thanh cong");
            }
            else
            {
                MessageBox.Show("sua that bai");
            }
        }
    }
}
