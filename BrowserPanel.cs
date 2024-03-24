using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2;

namespace TipTop
{
    public partial class BrowserPanel : UserControl
    {
        String currentUrl;
        bool browserReady;
        TabPage owningTab;

        public BrowserPanel(TabPage owner, String url = "")
        {
            InitializeComponent();

            owningTab = owner;
            currentUrl = (url.Length > 0) ? url : "about:blank";
            browserReady = false;

            WebViewer.EnsureCoreWebView2Async();
        }

        private void WebViewer_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            if (this.Parent == TopLevelControl)
            {

            }
        }

        private void WebViewer_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            owningTab.Text = WebViewer.CoreWebView2.DocumentTitle;
            AddressCombo.Text = WebViewer.Source.AbsoluteUri;

            TopLevelControl.Text = "TipTop - " + owningTab.Text;

            BackButton.Enabled = WebViewer.CanGoBack;
            ForwardButton.Enabled = WebViewer.CanGoForward;
        }

        private void WebViewer_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                WebViewer.Source = new System.Uri(currentUrl, System.UriKind.RelativeOrAbsolute);
                browserReady = true;
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            NavigateTo(AddressCombo.Text);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if (!browserReady)
                return;

            if (WebViewer.CanGoBack)
                WebViewer.GoBack();
        }

        private void ForwardButton_Click(object sender, EventArgs e)
        {
            if (!browserReady)
                return;

            if (WebViewer.CanGoForward)
                WebViewer.GoForward();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            if (!browserReady)
                return;

            WebViewer.Reload();
        }

        private void NavigateTo(string url)
        {
            if (!browserReady)
                return;

            // Check if the URL already has an HTTP or HTTPS scheme
            if (!url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) &&
                !url.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {
                // Prepend the URL with "https://" if it doesn't have a protocol
                url = "https://" + url;
            }

            currentUrl = url;
            WebViewer.Source = new System.Uri(currentUrl, System.UriKind.RelativeOrAbsolute);
        }

        private void AddressCombo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                NavigateTo(AddressCombo.Text);

                e.Handled = true;
            }
        }

        private void BrowserPanel_SizeChanged(object sender, EventArgs e)
        {
            int h = NavigationToolstrip.Height;
            NavigationToolstrip.Size = new Size(Width - (Margin.Horizontal * 2), h);
            int width = NavigationToolstrip.DisplayRectangle.Width;

            foreach (ToolStripItem tsi in NavigationToolstrip.Items)
            {
                if (!(tsi == AddressCombo))
                {
                    width -= tsi.Width;
                    width -= tsi.Margin.Horizontal;
                }
            }

            h = AddressCombo.Height;
            AddressCombo.Size = new Size(Math.Max(0, width - AddressCombo.Margin.Horizontal), h);
        }
    }
}
