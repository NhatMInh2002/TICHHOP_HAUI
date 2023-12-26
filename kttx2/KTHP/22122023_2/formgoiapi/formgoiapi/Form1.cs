using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Json;


namespace formgoiapi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Loaddata();
        }

        private void Loaddata()
        {
            string link = "https://localhost:44399/api/sanpham";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Sanpham[]));
            object data = js.ReadObject(response.GetResponseStream());
            Sanpham[] arrsanpham = data as Sanpham[];
            dataGridView1.DataSource = arrsanpham;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMa.Text = Convert.ToString(row.Cells[0].Value);
            txtTen.Text = Convert.ToString(row.Cells[1].Value);
            txtDG.Text = Convert.ToString(row.Cells[2].Value);
            txtMDM.Text = Convert.ToString(row.Cells[3].Value);
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string post = string.Format("?masp={0}&ten={1}&dongia={2}&madm={3}", txtMa.Text, txtTen.Text, txtDG.Text, txtMDM.Text);
            string link = "https://localhost:44399/api/sanpham" + post;
            HttpWebRequest req = HttpWebRequest.CreateHttp(link);
            req.Method = "POST";
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
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            string delete = string.Format("?ma={0}", txtMa.Text);
            string link = "https://localhost:44380/api/sanpham/" + delete;
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

        private void btnsua_Click_1(object sender, EventArgs e)
        {
            string put = string.Format("?masp={0}&ten={1}&dongia={2}&madm={3}", txtMa.Text, txtTen.Text, txtDG.Text, txtMDM.Text);
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
