
namespace TipTop
{
    partial class BrowserPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripContainer();
            this.NavigationToolstrip = new System.Windows.Forms.ToolStrip();
            this.BackButton = new System.Windows.Forms.ToolStripButton();
            this.ForwardButton = new System.Windows.Forms.ToolStripButton();
            this.ReloadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddressCombo = new System.Windows.Forms.ToolStripComboBox();
            this.GoButton = new System.Windows.Forms.ToolStripButton();
            this.WebViewer = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.TopToolStripPanel.TopToolStripPanel.SuspendLayout();
            this.TopToolStripPanel.SuspendLayout();
            this.NavigationToolstrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // TopToolStripPanel
            // 
            // 
            // TopToolStripPanel.ContentPanel
            // 
            this.TopToolStripPanel.ContentPanel.Size = new System.Drawing.Size(613, 1);
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Size = new System.Drawing.Size(613, 27);
            this.TopToolStripPanel.TabIndex = 1;
            this.TopToolStripPanel.Text = "TopToolStripPanel";
            // 
            // TopToolStripPanel.TopToolStripPanel
            // 
            this.TopToolStripPanel.TopToolStripPanel.Controls.Add(this.NavigationToolstrip);
            // 
            // NavigationToolstrip
            // 
            this.NavigationToolstrip.AutoSize = false;
            this.NavigationToolstrip.Dock = System.Windows.Forms.DockStyle.None;
            this.NavigationToolstrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.NavigationToolstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackButton,
            this.ForwardButton,
            this.ReloadButton,
            this.toolStripSeparator1,
            this.AddressCombo,
            this.GoButton});
            this.NavigationToolstrip.Location = new System.Drawing.Point(3, 0);
            this.NavigationToolstrip.Name = "NavigationToolstrip";
            this.NavigationToolstrip.Size = new System.Drawing.Size(147, 26);
            this.NavigationToolstrip.TabIndex = 2;
            this.NavigationToolstrip.Text = "toolStrip1";
            // 
            // BackButton
            // 
            this.BackButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackButton.Enabled = false;
            this.BackButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.BackButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(27, 23);
            this.BackButton.Text = "ï";
            this.BackButton.ToolTipText = "Go Back";
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ForwardButton
            // 
            this.ForwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ForwardButton.Enabled = false;
            this.ForwardButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ForwardButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ForwardButton.Name = "ForwardButton";
            this.ForwardButton.Size = new System.Drawing.Size(27, 23);
            this.ForwardButton.Text = "ð";
            this.ForwardButton.ToolTipText = "Go Forward";
            this.ForwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ReloadButton.Enabled = false;
            this.ReloadButton.Font = new System.Drawing.Font("Webdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.ReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(29, 23);
            this.ReloadButton.Text = "q";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
            // 
            // AddressCombo
            // 
            this.AddressCombo.MaxDropDownItems = 100;
            this.AddressCombo.Name = "AddressCombo";
            this.AddressCombo.Size = new System.Drawing.Size(321, 23);
            this.AddressCombo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddressCombo_KeyPress);
            // 
            // GoButton
            // 
            this.GoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GoButton.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.GoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(29, 21);
            this.GoButton.Text = "Ê";
            this.GoButton.ToolTipText = "Navigate to the Given Address";
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // WebViewer
            // 
            this.WebViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebViewer.CreationProperties = null;
            this.WebViewer.DefaultBackgroundColor = System.Drawing.Color.White;
            this.WebViewer.Location = new System.Drawing.Point(0, 27);
            this.WebViewer.Name = "WebViewer";
            this.WebViewer.Size = new System.Drawing.Size(613, 381);
            this.WebViewer.Source = new System.Uri("about:blank", System.UriKind.Absolute);
            this.WebViewer.TabIndex = 2;
            this.WebViewer.ZoomFactor = 1D;
            this.WebViewer.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.WebViewer_CoreWebView2InitializationCompleted);
            this.WebViewer.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.WebViewer_NavigationCompleted);
            // 
            // BrowserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WebViewer);
            this.Controls.Add(this.TopToolStripPanel);
            this.Name = "BrowserPanel";
            this.Size = new System.Drawing.Size(613, 408);
            this.SizeChanged += new System.EventHandler(this.BrowserPanel_SizeChanged);
            this.TopToolStripPanel.TopToolStripPanel.ResumeLayout(false);
            this.TopToolStripPanel.ResumeLayout(false);
            this.TopToolStripPanel.PerformLayout();
            this.NavigationToolstrip.ResumeLayout(false);
            this.NavigationToolstrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WebViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolStripContainer TopToolStripPanel;
        public Microsoft.Web.WebView2.WinForms.WebView2 WebViewer;
        private System.Windows.Forms.ToolStrip NavigationToolstrip;
        private System.Windows.Forms.ToolStripButton BackButton;
        private System.Windows.Forms.ToolStripButton ForwardButton;
        private System.Windows.Forms.ToolStripButton ReloadButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox AddressCombo;
        private System.Windows.Forms.ToolStripButton GoButton;
    }
}
