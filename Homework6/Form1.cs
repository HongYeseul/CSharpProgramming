using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string[] row = { txtName.Text, txtAddress.Text, txtNumber.Text };
            var listViewItem = new ListViewItem(row);
            listView.Items.Add(listViewItem);
        }

        private void btnReadAddr_Click(object sender, EventArgs e)
        {
            Console.WriteLine("click");
            try
            {
                StreamReader sr = new StreamReader(new FileStream("Address.txt", FileMode.OpenOrCreate));

                while (sr.EndOfStream == false)
                {
                    dynamic name = sr.ReadLine();
                    dynamic addr = sr.ReadLine();
                    dynamic number = sr.ReadLine();

                    string[] row = { name, addr, number };
                    var rowItem = new ListViewItem(row);
                    listView.Items.Add(rowItem);
                }
                sr.Close();
            }
            catch
            {
                MessageBox.Show("파일 열기 에러");
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Click");
            try
            {
                StreamWriter sw = new StreamWriter(new FileStream("Address.txt", FileMode.Create));

                for (dynamic i = 0; i < listView.Items.Count; i++)
                {
                    Console.WriteLine(listView.Items[i].SubItems[0].Text);
                    Console.WriteLine(listView.Items[i].SubItems[1].Text);
                    Console.WriteLine(listView.Items[i].SubItems[2].Text);
                    sw.WriteLine(listView.Items[i].SubItems[0].Text);
                    sw.WriteLine(listView.Items[i].SubItems[1].Text);
                    sw.WriteLine(listView.Items[i].SubItems[2].Text);
                }

                sw.Close();
            }
            catch
            {
                MessageBox.Show("파일 저장 오류");
            }
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    ListView.SelectedListViewItemCollection items = listView.SelectedItems;
                    ListViewItem lvItem = items[0];
                    string name = lvItem.SubItems[0].Text;
                    string addr = lvItem.SubItems[1].Text;
                    string number = lvItem.SubItems[2].Text;
                    Console.WriteLine(name + " " + addr + " " + number);

                    txtName.Text = name;
                    txtAddress.Text = addr;
                    txtNumber.Text = number;
                }
            }
            catch
            {
                MessageBox.Show("리스트 상세 정보 읽기 오류");
            }
            
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    ListView.SelectedListViewItemCollection items = listView.SelectedItems;
                    ListViewItem lvItem = items[0];
                    lvItem.SubItems[0].Text = txtName.Text;
                    lvItem.SubItems[1].Text = txtAddress.Text;
                    lvItem.SubItems[2].Text = txtNumber.Text;
                }
            }
            catch
            {
                MessageBox.Show("리스트 상세 정보 수정 오류");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView.SelectedItems.Count == 1)
                {
                    dynamic index = listView.FocusedItem.Index;
                    listView.Items.RemoveAt(index);
                }
            }
            catch
            {
                MessageBox.Show("리스트 정보 삭제 오류");
            }
        }
    }
}
