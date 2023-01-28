using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using System.Windows.Forms;

namespace EBSBingSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        Thread th;
        ChromeDriver drv;
        string URL = "https://www.bing.com/";
        private void button1_Click(object sender, EventArgs e)
        {
            th = new Thread(EBSGo); th.Start();
        }

        private void EBSGo()
        {
            drv = new ChromeDriver();
            drv.Navigate().GoToUrl(URL);
            Thread.Sleep(3000);
            drv.FindElements(By.XPath("//*[@type='search']"))[0].SendKeys("Ebubekir Bastama" + OpenQA.Selenium.Keys.Enter);

        }
    }
}
