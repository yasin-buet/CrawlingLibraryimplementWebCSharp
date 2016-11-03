using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrawlingLibrary;

namespace CrawlLibraryImplement
{
   
    public partial class Form1 : Form
    {
        private int _serialNo = 0 ;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var bbb = new CrawlingLibrary.CrawlingLibrary("http://www.bbb.org/search/?type=name&input=", textBox1.Text, textBox2.Text);
            var result = bbb.Show();
            foreach (var item in result)
            {
                dataGridView1.Rows.Add(++_serialNo, item.Name, item.Address, item.Location, item.ZipCode);
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
