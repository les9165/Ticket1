using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{

    public partial class Form1 : Form
    {
        public string user;

        public Form1()
        {
            
            InitializeComponent();

            dataGridView1.DataSource = DataManager.Performances;

          /*  button1.Click += (sender, e) =>
            {
                try
                {
                    if (DataManager.Users.Exists(x => x.Id == textBox1.Text))
                    {
                        MessageBox.Show("이미 존재하는 ID입니다.");
                    }
                   else
                    {
                        User user = new User()
                        {
                            Id = textBox1.Text
                        };
                        DataManager.Users.Add(user);
                        DataManager.Save();

                    }
                }
                catch (Exception ex) { }
            };*/
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Performance performance = dataGridView1.CurrentRow.DataBoundItem as Performance;

            }
            catch (Exception ex) { }
        }

        private void 예매하기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
            this.Close();

        }

        private void 공연ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }

}
