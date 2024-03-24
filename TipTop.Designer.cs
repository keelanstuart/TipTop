
namespace TipTop
{
    partial class BrowserWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserWindow));
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.BrowserTabs = new System.Windows.Forms.TabControl();
            this.AddPageButton = new System.Windows.Forms.TabPage();
            this.BrowserTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusStrip.Size = new System.Drawing.Size(557, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            this.StatusStrip.Visible = false;
            // 
            // BrowserTabs
            // 
            this.BrowserTabs.AllowDrop = true;
            this.BrowserTabs.Controls.Add(this.AddPageButton);
            this.BrowserTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrowserTabs.HotTrack = true;
            this.BrowserTabs.ItemSize = new System.Drawing.Size(20, 18);
            this.BrowserTabs.Location = new System.Drawing.Point(0, 0);
            this.BrowserTabs.Name = "BrowserTabs";
            this.BrowserTabs.SelectedIndex = 0;
            this.BrowserTabs.ShowToolTips = true;
            this.BrowserTabs.Size = new System.Drawing.Size(557, 450);
            this.BrowserTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.BrowserTabs.TabIndex = 3;
            this.BrowserTabs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.BrowserTabs_DrawItem);
            this.BrowserTabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.BrowserTabs_Selected);
            // 
            // AddPageButton
            // 
            this.AddPageButton.AutoScroll = true;
            this.AddPageButton.BackColor = System.Drawing.Color.Transparent;
            this.AddPageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPageButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AddPageButton.Location = new System.Drawing.Point(4, 22);
            this.AddPageButton.Name = "AddPageButton";
            this.AddPageButton.Padding = new System.Windows.Forms.Padding(3);
            this.AddPageButton.Size = new System.Drawing.Size(549, 424);
            this.AddPageButton.TabIndex = 1;
            this.AddPageButton.Text = "   ֍";
            this.AddPageButton.ToolTipText = "Add a New Browser Panel";
            // 
            // BrowserWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 450);
            this.Controls.Add(this.BrowserTabs);
            this.Controls.Add(this.StatusStrip);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BrowserWindow";
            this.Text = "TipTop";
            this.TopMost = true;
            this.BrowserTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.TabControl BrowserTabs;
        private System.Windows.Forms.TabPage AddPageButton;
    }
}

