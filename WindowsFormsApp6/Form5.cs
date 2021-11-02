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
    public partial class Form5 : Form
    {
        string GetText;
        string GetText1;
        string GetText2;
        string GetText3;

        public Form5(string Form2Text, string Form2Text1, string Form2Text2, string Form2Text3)
        {
            this.GetText = Form2Text;
            this.GetText1 = Form2Text1;
            this.GetText2= Form2Text2;
            this.GetText3 = Form2Text3;

            InitializeComponent();
           
            comboBox1_init();
            comboBox2_init();
          

            void comboBox1_init()
            {
                comboBox1.Items.Add("국민카드");
                comboBox1.Items.Add("신한카드");
                comboBox1.Items.Add("농협카드");
                comboBox1.Items.Add("현대카드");
                comboBox1.Items.Add("삼성카드");
                comboBox1.Items.Add("우리카드");
            }

            void comboBox2_init()
            {
                comboBox2.Items.Add("국민은행");
                comboBox2.Items.Add("신한은행");
                comboBox2.Items.Add("농협은행");
                comboBox2.Items.Add("하나은행");
                comboBox2.Items.Add("우리은행");
                comboBox2.Items.Add("기업은행");

            }
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox8.Text = GetText;
            textBox7.Text = GetText1;
            textBox3.Text = GetText2;
            textBox4.Text = GetText3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == false)
            {
                MessageBox.Show("결제수단을 선택해주세요.");
            }
            if (comboBox1.SelectedItem == null && comboBox2.SelectedItem == null)
            {
                MessageBox.Show("결제수단을 선택해주세요.");
            }
            else
            {
                this.Hide();
                new Form6().ShowDialog();
                this.Close();
            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
           /// new Form3().ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
