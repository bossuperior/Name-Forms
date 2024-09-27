using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sets;

namespace StudentForm
{
    public partial class NameForm : Form
    {
        public NameForm()
        {
            InitializeComponent();
        }
        Set name = new ArraySet(5);
        private void button1_Click(object sender, EventArgs e)
{
            if (textBox1.Text != null && textBox1.Text != "")
            {
                name.add(textBox1.Text);
                MessageBox.Show($"เพิ่มชื่อ {textBox1.Text} เข้าไปในรายการ");
            }
            else
            {
                MessageBox.Show("กรุณาใส่ชื่อที่ต้องการเพิ่ม");
            }
            textBox1.Clear();
            label1.Text = "จำนวน: " + name.size().ToString() + " คน";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (name.contains(textBox3.Text))
            {
                name.remove(textBox3.Text);
                MessageBox.Show($"ลบชื่อ {textBox3.Text} ออกจากรายการ");
            }else{
                MessageBox.Show($"ไม่สามารถลบได้เนื่องจากไม่มี {textBox3.Text} อยู่ในรายการ");
            }
            textBox3.Clear();
            label1.Text = "จำนวน: " + name.size().ToString() + " คน";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool contains = name.contains(textBox2.Text);  
            MessageBox.Show(contains ? $"เจอชื่อ {textBox2.Text} ในการค้นหา" : $"ไม่เจอชื่อ {textBox2.Text} ในการค้นหา");
        }
    }
}
