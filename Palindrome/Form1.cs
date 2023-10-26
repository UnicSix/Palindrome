using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindrome
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            string inputFile = "text.txt";
            InitializeComponent();
            System.IO.StreamReader inputData = new System.IO.StreamReader(inputFile);
            string line = "";
            int row = 0;
            line = inputData.ReadLine();
            while (line != null)
            {
                string rev_str="";
                for(int i=0; i<line.Length; i++)
                {
                    rev_str += line[line.Length - i - 1];
                }
                dataGridView1.Rows.Add("");
                dataGridView1.Rows[row].Cells[0].Value = line;
                if(rev_str == line)
                    dataGridView1.Rows[row].Cells[1].Value = "是";
                else
                    dataGridView1.Rows[row].Cells[1].Value = "否";
                row++;
                line = inputData.ReadLine();
            }
            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Font = new System.Drawing.Font("Times New Roman", 15, System.Drawing.FontStyle.Regular); // Change the font size and style
            dataGridView1.DefaultCellStyle = cellStyle;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.ColumnHeadersVisible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
