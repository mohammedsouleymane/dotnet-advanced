using System;
using System.Linq;
using System.Windows.Forms;

namespace oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int[] arr = new int[int.Parse(txtBoven.Text) - int.Parse(txtOnder.Text) +1];
            for (int i = int.Parse(txtOnder.Text); i < int.Parse(txtBoven.Text)+1; i++)
            {
                arr[i - int.Parse(txtOnder.Text)] = i;
            }

            foreach (var number in arr.Where(n => n % 2 == 0))
            {
                listBox1.Items.Add(number);
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtRes.Text = "";
            string[] arr = txtReeks.Text.Split(txtTeken.Text);
            if (rBegin.Checked)
                arr = arr.Where(n => n.StartsWith(txtFilter.Text)).ToArray();
            else if (rEinde.Checked)
                arr = arr.Where(n => n.EndsWith(txtFilter.Text)).ToArray();
            else if (rBevat.Checked)
                arr = arr.Where(n => n.Contains(txtFilter.Text)).ToArray();

            foreach (var s in arr)
            {
                txtRes.Text += s + Environment.NewLine;
            }

           
        }
    }
}
