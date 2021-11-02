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
    
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();

            /*button2.Click += (sender, e) =>
            {
                try
                {
                    User user = new User()
                    {
                        Type = textBox1.Text,
                        Performance_Name = textBox2.Text
                    }; 
                    DataManager.Users.Add(user);
                    DataManager.Save();
                }
                catch (Exception ex) { }
            };*/
                dataGridView1.DataSource = DataManager.Performances;
            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                Performance performance = dataGridView1.CurrentRow.DataBoundItem as Performance ;
                textBox1.Text = performance.Type;
                textBox2.Text = performance.Name;
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e) // 추가
        {
           
            this.Hide();
            Form3 form3 = new Form3(textBox1.Text, textBox2.Text)
            {
                // new Form3().ShowDialog();
                Owner = this
            };
            form3.ShowDialog();
            this.Close();
        }
      


    }
}
