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
namespace L26_12_2023_form
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
            LoadCB();

        }

        private void LoadCB()
        {
            string link = "https://localhost:44374/api/phongban";
            HttpWebRequest rq = HttpWebRequest.CreateHttp(link);
            WebResponse rs = rq.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Phongban[]));
            object data = js.ReadObject(rs.GetResponseStream());
            Phongban[] arr = data as Phongban[];
            cbPhongBan.DataSource = arr;
            cbPhongBan.ValueMember = "MaPhong";
            cbPhongBan.DisplayMember = "TenPhong";

        }


        private void Hienthi()
        {
            string link = "https://localhost:44374/api/nhanvien";
            HttpWebRequest rq = HttpWebRequest.CreateHttp(link);
            WebResponse rs = rq.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Nhanvien[]));
            object data = js.ReadObject(rs.GetResponseStream());
            Nhanvien[] arr = data as Nhanvien[];
            dataGridView1.DataSource = arr;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txtMaNV.Text = Convert.ToString(row.Cells[0].Value);
            txtTenNV.Text = Convert.ToString(row.Cells[1].Value);
            txtLuong.Text = Convert.ToString(row.Cells[2].Value);
            cbPhongBan.Text = Convert.ToString(row.Cells[3].Value);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string post = string.Format("?ma={0}&ten={1}&luong={2}&map={3}",txtMaNV.Text,txtTenNV.Text,txtLuong.Text,cbPhongBan.SelectedValue);
            string link = "https://localhost:44374/api/nhanvien/" + post;
            HttpWebRequest rq = HttpWebRequest.CreateHttp(link);
            rq.Method = "POST";
            rq.ContentType = "application/json";
            byte[] bytes = Encoding.UTF8.GetBytes(post);
            rq.ContentLength = bytes.Length;
            Stream datastream = rq.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(rq.GetResponse().GetResponseStream());
            bool kq = (bool) data;
            if (kq)
            {
                MessageBox.Show("Them thanh cong ");
                Hienthi();
            }
            else
            {
                MessageBox.Show("Them that bai"); 
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string post = string.Format("?ma={0}", txtMaNV.Text);
            string link = "https://localhost:44374/api/nhanvien/" + post;
            HttpWebRequest rq = HttpWebRequest.CreateHttp(link);
            rq.Method = "DELETE";
            rq.ContentType = "application/json";
            byte[] bytes = Encoding.UTF8.GetBytes(post);
            rq.ContentLength = bytes.Length;
            Stream datastream = rq.GetRequestStream();
            datastream.Write(bytes, 0, bytes.Length);
            datastream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(rq.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                MessageBox.Show("Xoa thanh cong ");
                Hienthi();
            }
            else
            {
                MessageBox.Show("Xoa that bai");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {


        }
    }
}
