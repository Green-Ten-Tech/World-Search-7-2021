using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace World_Search_7_2021
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://www.google.com/search?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://www.bing.com/search?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://search.yahoo.com/search?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://www.baidu.com/s?ie=utf-8&f=8&rsv_bp=1&rsv_idx=1&tn=baidu&wd=";
            Properties.Settings.Default.Save();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://yandex.com/search/?text=";
            Properties.Settings.Default.Save();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://duckduckgo.com/?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://www.ask.com/web?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://www.ecosia.org/search?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://search.aol.com/aol/search?q=";
            Properties.Settings.Default.Save();
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://archive.org/search.php?query=";
            Properties.Settings.Default.Save();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Search = "https://bing.com/search?q=";
            Properties.Settings.Default.Save();
            radioButton2.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDig = new ColorDialog();
            if (ColorDig.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FormBackround = ColorDig.Color;
                Properties.Settings.Default.Save();
                this.BackColor = ColorDig.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Homepage = textBox1.Text;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Homepage;

            button1.BackColor = Properties.Settings.Default.ButtonColor;
            button2.BackColor = Properties.Settings.Default.ButtonColor;
            button3.BackColor = Properties.Settings.Default.ButtonColor;
            button4.BackColor = Properties.Settings.Default.ButtonColor;
            button5.BackColor = Properties.Settings.Default.ButtonColor;
            button6.BackColor = Properties.Settings.Default.ButtonColor;
            button7.BackColor = Properties.Settings.Default.ButtonColor;
            button8.BackColor = Properties.Settings.Default.ButtonColor;
            button9.BackColor = Properties.Settings.Default.ButtonColor;
            button11.BackColor = Properties.Settings.Default.ButtonColor;
            textBox1.BackColor = Properties.Settings.Default.ButtonColor;

            this.BackColor = Properties.Settings.Default.FormBackround;

            groupBox1.Font = Properties.Settings.Default.FontStyle;
            groupBox2.Font = Properties.Settings.Default.FontStyle;
            button5.Font = Properties.Settings.Default.FontStyle;
            groupBox3.Font = Properties.Settings.Default.FontStyle;
            groupBox4.Font = Properties.Settings.Default.FontStyle;
            groupBox5.Font = Properties.Settings.Default.FontStyle;
            groupBox6.Font = Properties.Settings.Default.FontStyle;

            button1.ForeColor = Properties.Settings.Default.TextColor;
            button2.ForeColor = Properties.Settings.Default.TextColor;
            button3.ForeColor = Properties.Settings.Default.TextColor;
            button4.ForeColor = Properties.Settings.Default.TextColor;
            button5.ForeColor = Properties.Settings.Default.TextColor;
            button6.ForeColor = Properties.Settings.Default.TextColor;
            button7.ForeColor = Properties.Settings.Default.TextColor;
            button8.ForeColor = Properties.Settings.Default.TextColor;
            button9.ForeColor = Properties.Settings.Default.TextColor;
            button11.ForeColor = Properties.Settings.Default.TextColor;
            textBox1.ForeColor = Properties.Settings.Default.TextColor;
            radioButton1.ForeColor = Properties.Settings.Default.TextColor;
            radioButton2.ForeColor = Properties.Settings.Default.TextColor;
            radioButton3.ForeColor = Properties.Settings.Default.TextColor;
            radioButton4.ForeColor = Properties.Settings.Default.TextColor;
            radioButton5.ForeColor = Properties.Settings.Default.TextColor;
            radioButton6.ForeColor = Properties.Settings.Default.TextColor;
            radioButton7.ForeColor = Properties.Settings.Default.TextColor;
            radioButton8.ForeColor = Properties.Settings.Default.TextColor;
            radioButton9.ForeColor = Properties.Settings.Default.TextColor;
            radioButton10.ForeColor = Properties.Settings.Default.TextColor;
            groupBox1.ForeColor = Properties.Settings.Default.TextColor;
            groupBox2.ForeColor = Properties.Settings.Default.TextColor;
            groupBox3.ForeColor = Properties.Settings.Default.TextColor;
            groupBox4.ForeColor = Properties.Settings.Default.TextColor;
            groupBox5.ForeColor = Properties.Settings.Default.TextColor;
            groupBox6.ForeColor = Properties.Settings.Default.TextColor;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ColorDialog TextDig = new ColorDialog();
            if (TextDig.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.TextColor = TextDig.Color;
                Properties.Settings.Default.Save();
                button1.ForeColor = Properties.Settings.Default.TextColor;
                button2.ForeColor = Properties.Settings.Default.TextColor;
                button3.ForeColor = Properties.Settings.Default.TextColor;
                button4.ForeColor = Properties.Settings.Default.TextColor;
                button5.ForeColor = Properties.Settings.Default.TextColor;
                button6.ForeColor = Properties.Settings.Default.TextColor;
                button7.ForeColor = Properties.Settings.Default.TextColor;
                button8.ForeColor = Properties.Settings.Default.TextColor;
                button9.ForeColor = Properties.Settings.Default.TextColor;
                button11.ForeColor = Properties.Settings.Default.TextColor;
                textBox1.ForeColor = Properties.Settings.Default.TextColor;
                radioButton1.ForeColor = Properties.Settings.Default.TextColor;
                radioButton2.ForeColor = Properties.Settings.Default.TextColor;
                radioButton3.ForeColor = Properties.Settings.Default.TextColor;
                radioButton4.ForeColor = Properties.Settings.Default.TextColor;
                radioButton5.ForeColor = Properties.Settings.Default.TextColor;
                radioButton6.ForeColor = Properties.Settings.Default.TextColor;
                radioButton7.ForeColor = Properties.Settings.Default.TextColor;
                radioButton8.ForeColor = Properties.Settings.Default.TextColor;
                radioButton9.ForeColor = Properties.Settings.Default.TextColor;
                radioButton10.ForeColor = Properties.Settings.Default.TextColor;
                groupBox1.ForeColor = Properties.Settings.Default.TextColor;
                groupBox2.ForeColor = Properties.Settings.Default.TextColor;
                groupBox3.ForeColor = Properties.Settings.Default.TextColor;
                groupBox4.ForeColor = Properties.Settings.Default.TextColor;
                groupBox5.ForeColor = Properties.Settings.Default.TextColor;
                groupBox6.ForeColor = Properties.Settings.Default.TextColor;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FontDialog FontDig = new FontDialog();
            if (FontDig.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.FontStyle = FontDig.Font;
                FontDig.Font = Properties.Settings.Default.FontStyle;
                Properties.Settings.Default.Save();
                groupBox1.Font = FontDig.Font;
                groupBox2.Font = FontDig.Font;
                button5.Font = FontDig.Font;
                groupBox3.Font = FontDig.Font;
                groupBox4.Font = FontDig.Font;
                groupBox5.Font = FontDig.Font;
                groupBox6.Font = FontDig.Font;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            Properties.Settings.Default.FormBackround = Color.White;
            Properties.Settings.Default.Save();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ColorDialog ColorDigBtn = new ColorDialog();
            if (ColorDigBtn.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ButtonColor = ColorDigBtn.Color;
                Properties.Settings.Default.Save();
                button1.BackColor = ColorDigBtn.Color;
                button2.BackColor = ColorDigBtn.Color;
                button3.BackColor = ColorDigBtn.Color;
                button4.BackColor = ColorDigBtn.Color;
                button5.BackColor = ColorDigBtn.Color;
                button6.BackColor = ColorDigBtn.Color;
                button7.BackColor = ColorDigBtn.Color;
                button8.BackColor = ColorDigBtn.Color;
                button9.BackColor = ColorDigBtn.Color;
                button11.BackColor = ColorDigBtn.Color;
                textBox1.BackColor = ColorDigBtn.Color;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ButtonColor = Color.White;
            Properties.Settings.Default.Save();
            button1.ForeColor = Properties.Settings.Default.ButtonColor;
            button2.ForeColor = Properties.Settings.Default.ButtonColor;
            button3.ForeColor = Properties.Settings.Default.ButtonColor;
            button4.ForeColor = Properties.Settings.Default.ButtonColor;
            button5.ForeColor = Properties.Settings.Default.ButtonColor;
            button6.ForeColor = Properties.Settings.Default.ButtonColor;
            button7.ForeColor = Properties.Settings.Default.ButtonColor;
            button8.ForeColor = Properties.Settings.Default.ButtonColor;
            button9.ForeColor = Properties.Settings.Default.ButtonColor;
            button11.ForeColor = Properties.Settings.Default.ButtonColor;
            textBox1.ForeColor = Properties.Settings.Default.ButtonColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ButtonColor = Color.Black;
            Properties.Settings.Default.Save();
            button1.ForeColor = Properties.Settings.Default.ButtonColor;
            button2.ForeColor = Properties.Settings.Default.ButtonColor;
            button3.ForeColor = Properties.Settings.Default.ButtonColor;
            button4.ForeColor = Properties.Settings.Default.ButtonColor;
            button5.ForeColor = Properties.Settings.Default.ButtonColor;
            button6.ForeColor = Properties.Settings.Default.ButtonColor;
            button7.ForeColor = Properties.Settings.Default.ButtonColor;
            button8.ForeColor = Properties.Settings.Default.ButtonColor;
            button9.ForeColor = Properties.Settings.Default.ButtonColor;
            button11.ForeColor = Properties.Settings.Default.ButtonColor;
            textBox1.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton1.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton2.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton3.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton4.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton5.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton6.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton7.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton8.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton9.ForeColor = Properties.Settings.Default.ButtonColor;
            radioButton10.ForeColor = Properties.Settings.Default.ButtonColor;
            groupBox1.ForeColor = Properties.Settings.Default.ButtonColor;
            groupBox2.ForeColor = Properties.Settings.Default.ButtonColor;
            groupBox3.ForeColor = Properties.Settings.Default.ButtonColor;
            groupBox4.ForeColor = Properties.Settings.Default.ButtonColor;
            groupBox5.ForeColor = Properties.Settings.Default.ButtonColor;
            groupBox6.ForeColor = Properties.Settings.Default.ButtonColor;
        }
    } 
}
