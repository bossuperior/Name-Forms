using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using Sets;
using Lists;
using Collections;

namespace StudentFormV._2
{
    public partial class NameFormV2 : Form
    {
        public NameFormV2()
        {
            InitializeComponent();
        }
        List name = new ArrayList(5);
        private void searchButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                bool contains = name.contains(nameBox.Text);
                MessageBox.Show(contains ? $"เจอชื่อ {nameBox.Text} ในการค้นหา" : $"ไม่เจอชื่อ {nameBox.Text} ในการค้นหา");
            }
            else
            {
                MessageBox.Show("โปรดใส่ชื่อที่ต้องการค้นหา");
            }
            }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                name.add(nameBox.Text);
                MessageBox.Show($"เพิ่มชื่อ {nameBox.Text} เข้าไปในรายการ");
            }
            else
            {
                MessageBox.Show("กรุณาใส่ชื่อที่ต้องการเพิ่ม");
            }
            nameBox.Clear();
            countText.Text = "จำนวน: " + name.size().ToString() + " คน";
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                bool contains = name.contains(nameBox.Text);
                name.remove(nameBox.Text);
                MessageBox.Show(contains ? $"ลบชื่อ {nameBox.Text} ออกจากรายการ" : $"ไม่สามารถลบได้เนื่องจากไม่มี {nameBox.Text} อยู่ในรายการ");
            }
            else
            {
                MessageBox.Show("โปรดใส่ชื่อที่ต้องการลบ");
            }
            nameBox.Clear();
            countText.Text = "จำนวน: " + name.size().ToString() + " คน";
        }
        private void findNumberButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numberBox.Text, out int input)) input -= 1;
            if (input >= 0 && input < name.size())
            {
                displayEditBox.Text = name.get(input).ToString();
            }else{
                int SIZE = name.size();
                displayEditBox.Clear();
                MessageBox.Show(SIZE <= 0 ? "โปรดเพิ่มข้อมูลก่อนการต้นหา" : $"โปรดใส่ลำดับ 1-{name.size()}");
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numberBox.Text, out int input)) input -= 1;
            if (input >= 0 && input < name.size())
            {
                name.set(input, displayEditBox.Text);
            }
            else
            {
                int SIZE = name.size();
                displayEditBox.Clear();
                MessageBox.Show(SIZE <= 0 ? "โปรดเพิ่มข้อมูลก่อนแก้ไข" : $"โปรดใส่ลำดับ 1-{name.size()}");
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            displayAllBox.Clear();
            displayAllBox.ScrollBars = ScrollBars.Vertical;
            for (int i = 0; i < name.size(); i++)
                displayAllBox.AppendText($"{i+1}. "+name.get(i).ToString() + Environment.NewLine);
        }
    }
}
