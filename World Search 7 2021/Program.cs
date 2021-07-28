using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using ApplicationContext = System.Windows.Forms.ApplicationContext;

namespace World_Search_7_2021
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            // Add the initial
            container.Tabs.Add(
                //  Our First Tab created by defualt in the application will have as content the Form1
                new TitleBarTab(container)
                {
                    Content = new frmBrowser
                    {
                        Text = "World Search 7"
                    }
                }
             );

            // Set initian tab the first one
            container.SelectedTabIndex = 0;

            // Create tabs and start application
            TitleBarTabsApplicationContext applicataionContext = new TitleBarTabsApplicationContext();
            applicataionContext.Start(container);
            Application.Run(applicataionContext);
        }
    }
}

