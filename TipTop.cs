using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipTop
{
    public partial class BrowserWindow : Form
    {
        public BrowserWindow()
        {
            InitializeComponent();

            AddPageButton.Width = 20;
            AddBrowserTab();
        }

        public BrowserPanel AddBrowserTab()
        {
            // this is grade-A bull-plop
            IntPtr h = this.BrowserTabs.Handle;

            int pidx = BrowserTabs.TabPages.Count - 1;

            TabPage tab = new TabPage();
            BrowserTabs.TabPages.Insert(pidx, tab);
            tab.Width = AddPageButton.Width * 6;

            BrowserPanel panel = new BrowserPanel(tab, "https://www.google.com");
            tab.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;

            BrowserTabs.SelectedTab = tab;

            return panel;
        }

        private void BrowserTabs_Selected(object sender, TabControlEventArgs e)
        {
            if (BrowserTabs.SelectedIndex == (BrowserTabs.TabCount - 1))
                AddBrowserTab();
            else
                TopLevelControl.Text = "TipTop - " + BrowserTabs.SelectedTab.Text;
        }

        private void BrowserTabs_DrawItem(object sender, DrawItemEventArgs e)
        {
            
        }
    }
}
