namespace WinFormsApp1
{
    partial class Form9
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
            menuStrip1 = new MenuStrip();
            mnuNewWindow = new ToolStripMenuItem();
            mnuWindow = new ToolStripMenuItem();
            titleToolStripMenuItem = new ToolStripMenuItem();
            cascadeToolStripMenuItem = new ToolStripMenuItem();
            arrangeziconsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuNewWindow, mnuWindow });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.MdiWindowListItem = mnuWindow;
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(530, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuNewWindow
            // 
            mnuNewWindow.Name = "mnuNewWindow";
            mnuNewWindow.Size = new Size(58, 24);
            mnuNewWindow.Text = "새 창";
            mnuNewWindow.Click += mnuNewWindow_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.DropDownItems.AddRange(new ToolStripItem[] { titleToolStripMenuItem, cascadeToolStripMenuItem, arrangeziconsToolStripMenuItem });
            mnuWindow.Name = "mnuWindow";
            mnuWindow.Size = new Size(38, 24);
            mnuWindow.Text = "창";
            // 
            // titleToolStripMenuItem
            // 
            titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            titleToolStripMenuItem.Size = new Size(224, 26);
            titleToolStripMenuItem.Text = "Title";
            // 
            // cascadeToolStripMenuItem
            // 
            cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            cascadeToolStripMenuItem.Size = new Size(224, 26);
            cascadeToolStripMenuItem.Text = "Cascade";
            // 
            // arrangeziconsToolStripMenuItem
            // 
            arrangeziconsToolStripMenuItem.Name = "arrangeziconsToolStripMenuItem";
            arrangeziconsToolStripMenuItem.Size = new Size(224, 26);
            arrangeziconsToolStripMenuItem.Text = "Arrangezicons";
            // 
            // Form9
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 410);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form9";
            Text = "Form9";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuNewWindow;
        private ToolStripMenuItem mnuWindow;
        private ToolStripMenuItem titleToolStripMenuItem;
        private ToolStripMenuItem cascadeToolStripMenuItem;
        private ToolStripMenuItem arrangeziconsToolStripMenuItem;
    }
}