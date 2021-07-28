using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CefSharp.WinForms;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;

namespace World_Search_7_2021
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Contains("."))
            {
                chromiumWebBrowser1.Load(textBox1.Text);
            }
            else
            {
                chromiumWebBrowser1.Load(Properties.Settings.Default.Search + textBox1.Text);
            }
        }
        private void frmBrowser_Load(object sender, EventArgs e)
        {
            textBox1.Text = Properties.Settings.Default.Homepage;
            chromiumWebBrowser1.Load(Properties.Settings.Default.Homepage);
            chromiumWebBrowser1.AddressChanged += chromiumWebBrowser1_AddressChanged;
            
            menuStrip1.BackColor = Properties.Settings.Default.FormBackround;

            button1.BackColor = Properties.Settings.Default.ButtonColor;
            btnBack.BackColor = Properties.Settings.Default.ButtonColor;
            button3.BackColor = Properties.Settings.Default.ButtonColor;
            button4.BackColor = Properties.Settings.Default.ButtonColor;
            button5.BackColor = Properties.Settings.Default.ButtonColor;

            uoToolStripMenuItem.Font = Properties.Settings.Default.FontStyle;
        }

        private void chromiumWebBrowser1_AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                textBox1.Text = e.Address;
            }));
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void uoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings f2 = new Settings();
            f2.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            {
                if (chromiumWebBrowser1.CanGoBack)
                    chromiumWebBrowser1.Back();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (chromiumWebBrowser1.CanGoForward)
                    chromiumWebBrowser1.Forward();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                    chromiumWebBrowser1.Reload();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load(Properties.Settings.Default.Homepage);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void googleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://google.com");
        }

        private void yahooToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://yahoo.com");
        }

        private void bingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://bing.com");
        }

        private void duckDuckGoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://duckduckgo.com");
        }

        private void internetArciveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://archive.org/index.php");
        }

        private void aOLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://aol.com");
        }

        private void baiduToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://baidu.com");
        }

        private void yandexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://yandex.com");
        }

        private void askToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://ask.com");
        }

        private void ecosiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://ecosia.com");
        }

        private void wikipediaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://wikipedia.org");
        }

        private void kiddleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://kiddle.co");
        }

        private void largeCompenysToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void microsoftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://microsoft.com");
        }

        private void appleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://apple.com");
        }

        private void logitechToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://logitech.com");
        }

        private void acerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://acer.com");
        }

        private void hPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://hp.com");
        }

        private void googleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://google.com");
        }

        private void dellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://dell.com");
        }

        private void disneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://disney.com");
        }

        private void mozillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://mozilla.org");
        }

        private void theRedCrossToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://redcross.org");
        }

        private void yMCAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://ymca.org");
        }

        private void feedingAmericaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://secure.feedingamerica.org");
        }

        private void youTubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://youtube.com");
        }

        private void disneyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://disneyplus.com");
        }

        private void huluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://hulu.com");
        }

        private void pultoTVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://tv.pluto.com");
        }

        private void peacookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://peacook.com");
        }

        private void netflixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://netflix.com");
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://mail.google.com");
        }

        private void outlookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://outlook.com");
        }

        private void yahooMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://mail.yahoo.com");
        }

        private void aolMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://aol.com");
        }

        private void zohoMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://zoho.com/mail/");
        }

        private void mailcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://mail.com");
        }

        private void yandexMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://mail.yandex.com");
        }

        private void protonMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://protonmail.com");
        }

        private void gMXEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://gmx.com");
        }

        private void iCloudMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://icloud.com/mail/");
        }

        private void mSNSportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://msn.com/sports/");
        }

        private void eSPNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://espn.com");
        }
    }
}
