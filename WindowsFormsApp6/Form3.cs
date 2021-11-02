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
    public partial class Form3 : Form
    {

        string GetText;
        string GetText1;
        string GetText2;

        public Form3(string Form2Text, string Form2Text1)
        {
            this.GetText = Form2Text;
            this.GetText1 = Form2Text1;
           
           
            InitializeComponent();


            comboBox1_init();
            comboBox2_init();

            void comboBox1_init()
            {
                comboBox1.Items.Add("2021-11-03");
                comboBox1.Items.Add("2021-11-05");
                comboBox1.Items.Add("2021-11-10");
                comboBox1.Items.Add("2021-11-12");
                comboBox1.Items.Add("2021-11-27");
                comboBox1.Items.Add("2021-11-28");
            }

            void comboBox2_init()
            {
                comboBox2.Items.Add("1회차");
                comboBox2.Items.Add("2회차");

            }
            button45.Click += (sender, e) => 
                {

                try
                {
                   
                        User user = new User()
                        {
                            Type = textBox3.Text,
                            Performance_Name = textBox4.Text,
                            Tdate = comboBox1.SelectedItem.ToString(),
                            Ttime = comboBox2.SelectedItem.ToString(),
                            Tseat = textBox2.Text,
                            Price = 99000.ToString()
                        };

                        DataManager.Users.Add(user);
                        DataManager.Save();
                    
                }
                catch (Exception ex) { }
            };
           

           }
      
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("날짜를 선택해주세요.");
            }
            else if (comboBox2.SelectedItem == null)

            {
                MessageBox.Show("회차를 선택해주세요.");
            }
            else
            {
                this.Hide();
                Form5 form5 = new Form5(textBox4.Text,comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(),textBox2.Text)
                {
                    
                    Owner = this
                };
                form5.ShowDialog();
                this.Close();
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().ShowDialog();
            this.Close();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button1.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
            textBox3.Text = GetText;
            textBox4.Text = GetText1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
                
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button2.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button3.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button4.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button5.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button6.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button7.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button8.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button9.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button10.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button11.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button12.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button13.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button14.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button15.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button16.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button17.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button18_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button18.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button19.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button20.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button21_Click(object sender, EventArgs e) //B
        {
            Button btn = sender as Button;
            textBox2.Text = button21.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button22.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button23.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button24.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button25.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button26_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button26.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button27.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button28_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button28.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button29.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button30_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button30.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button31.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button32.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button33_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button33.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button34_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button34.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button35_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button35.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button36_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button36.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button37_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button37.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button38_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button38.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button39_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button39.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button40_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button40.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button41_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button41.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button42_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button42.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button43_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button43.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button44_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button44.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button46_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button46.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button47_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button47.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button48_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button48.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button49_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button49.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button50_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button50.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button51_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button51.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button52_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button52.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button53_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button53.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button75_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button75.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button76_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button76.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button77_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button77.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button78_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button78.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button54_Click(object sender, EventArgs e) //C
        {
            Button btn = sender as Button;
            textBox2.Text = button54.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button55_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button55.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button56.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button57_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button57.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button58.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button59_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button59.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button60_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button60.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button61_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button61.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button62_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button62.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button63_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button63.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button64.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button65.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button66.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button67.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button69.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button70_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button70.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button71_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button71.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button72_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button72.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button73_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button73.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void button74_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            textBox2.Text = button74.Text;
            try
            {
                if (DataManager.Users.Exists(x => x.Tseat == textBox2.Text))
                {
                    MessageBox.Show("이미 선택된 좌석입니다.");
                }
            }
            catch (Exception ex) { }

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    }

      
        
 

        
