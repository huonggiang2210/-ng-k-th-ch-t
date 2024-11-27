using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đăng_ký_thể_chất
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btt_phai_Click(object sender, EventArgs e)
        {
            string mon = listBox1.SelectedItem.ToString();
            listBox2.Items.Add(mon);
            listBox1.Items.Remove(mon);
        }

        private void btt_phaihet_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void btt_trai_Click(object sender, EventArgs e)
        {
            string mon = listBox2.SelectedItem.ToString();
            listBox1.Items.Add(mon);
            listBox2.Items.Remove(mon);    
        }

        private void btt_traihet_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear(); 
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            string hoten = txt_ten.Text;
            string ngaysinh = dateTimePicker1.Text;
            string monchon = listBox2.SelectedItems.ToString();

            if (hoten.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập họ tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Char.IsDigit(hoten[0]))
            {
                MessageBox.Show("Họ tên không được nhập bằng số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            textBox2.Text = txt_ten.Text + "\r\n";
            textBox2.Text += dateTimePicker1.Text + "\r\n";
            textBox2.Text += "***" + "\r\n";
            textBox2.Text += "Môn đã chọn" + "\r\n";
      


            foreach (string item in listBox2.Items)
            {
                textBox2.Text += item + ", ";
            }

        }

        private void btt_reset_Click(object sender, EventArgs e)
        {
            textBox2.ResetText();
            txt_ten.ResetText();
            dateTimePicker1.ResetText();
            listBox1.Items.AddRange(listBox2.Items);
            listBox2.Items.Clear();
        }

        private void btt_exit_Click(object sender, EventArgs e)
        {
          
            DialogResult h = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (h == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
