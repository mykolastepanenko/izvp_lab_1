using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");

            fileItem.DropDownItems.Add("Закрити");
            fileItem.DropDownItems[0].Click += aboutItem_Click;
            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.DropDownItems.Add("Автор: Степаненко М.І. 471");
            menuStrip1.Items.Add(aboutItem);
            Random random = new Random();
            //создаю строки
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
            }

            //присваиваю значения ячейкам
            string[] names = new string[] {"Степаненко Микола", "Іванов Анатолій", "Куликов Данило", "Олексій Антонович", "Іван Іванович"};
            for (int i = 0; i < 5; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = names[i];
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 1; j < 4; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(0,6);
                }
            }
        }

        private void aboutItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double sumAll = 0;
            if (checkBox1.Checked == true)
            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                    }
                    sumAll += (sum / 3);
                    sum = 0;
                }
                label1.Text = label1.Text + " " + (sumAll / 5).ToString();
            }
            else
            {
                for(int i = 0; i < 5; i++)
                {
                    for (int j = 1; j < 4; j++)
                    {
                        sum += Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value);
                        dataGridView1.Rows[i].Cells[4].Value = sum/3;
                    }
                    sum = 0;
                }
            }
        }
    }
}
