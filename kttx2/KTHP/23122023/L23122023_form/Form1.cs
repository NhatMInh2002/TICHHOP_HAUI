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
using System.IO;
using System.Runtime.Serialization.Json;

namespace L23122023_form
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
            string link = "https://localhost:44350/api/nhanvien";
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            WebResponse respone = request.GetResponse();  
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Nhanvien[]));
            object data = js.ReadObject(respone.GetResponseStream());
            Nhanvien[] arrnv = data as Nhanvien[];
            dataGridView1.DataSource = arrnv;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];   
            tbMa.Text = Convert.ToString(row.Cells[0].Value);
            tbTen.Text = Convert.ToString(row.Cells[1].Value);
            tbTD.Text = Convert.ToString(row.Cells[2].Value);
            tbLuong.Text = Convert.ToString(row.Cells[3].Value);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //
            string post = string.Format("?ma={0}&ten={1}&trinhdo={2}&luong={3}", tbMa.Text, tbTen.Text, tbTD.Text, tbLuong.Text);
            //
            string link = "https://localhost:44350/api/nhanvien/" + post;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            //
            request.Method = "POST";
            request.ContentType = "application/jso";
            byte[] bytes = Encoding.UTF8.GetBytes(link);
            request.ContentLength = bytes.Length;
            Stream datastream = request.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            //
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            //
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            //
            bool kq = (bool)data;
            if (kq)
            {
                Loaddata();
                MessageBox.Show("Them thanh cong");
            }
            else
            {
                MessageBox.Show("Khong thanh cong");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //
            string put= string.Format("?ma={0}&ten={1}&trinhdo={2}&luong={3}", tbMa.Text, tbTen.Text, tbTD.Text, tbLuong.Text);
            //
            string link = "https://localhost:44350/api/nhanvien/" + put;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            //
            request.Method = "PUT";
            request.ContentType = "application/jso";
            byte[] bytes = Encoding.UTF8.GetBytes(link);
            request.ContentLength = bytes.Length;
            Stream datastream = request.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            //
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            //
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            //
            bool kq = (bool)data;
            if (kq)
            {
                Loaddata();
                MessageBox.Show("Sua thanh cong");
            }
            else
            {
                MessageBox.Show("Sua that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //
            string dele = string.Format("?ma={0}", tbMa.Text);
            //
            string link = "https://localhost:44350/api/nhanvien/" + dele;
            HttpWebRequest request = HttpWebRequest.CreateHttp(link);
            //
            request.Method = "DELETE";
            request.ContentType = "application/jso";
            byte[] bytes = Encoding.UTF8.GetBytes(link);
            request.ContentLength = bytes.Length;
            Stream datastream = request.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            //
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            //
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            //
            bool kq = (bool)data;
            if (kq)
            {
                Loaddata();
                MessageBox.Show("Xoa thanh cong");
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }


    }
}
