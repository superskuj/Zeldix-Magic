namespace Zeldix
{
    partial class form_parent
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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel_file = new System.Windows.Forms.ToolStripDropDownButton();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel_window = new System.Windows.Forms.ToolStripDropDownButton();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.worldMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monologuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.palettesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonMapsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dungeonPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuScreensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel_file,
            this.toolStripLabel_window,
            this.toolStripLabel4,
            this.toolStripLabel5});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(584, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripLabel_file
            // 
            this.toolStripLabel_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripLabel_file.Name = "toolStripLabel_file";
            this.toolStripLabel_file.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabel_file.Text = "Edit";
            this.toolStripLabel_file.Click += new System.EventHandler(this.toolStripLabel_file_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolStripLabel_window
            // 
            this.toolStripLabel_window.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem,
            this.worldMapsToolStripMenuItem,
            this.monologuesToolStripMenuItem,
            this.palettesToolStripMenuItem,
            this.dungeonMapsToolStripMenuItem,
            this.dungeonPropertiesToolStripMenuItem,
            this.menuScreensToolStripMenuItem});
            this.toolStripLabel_window.Enabled = false;
            this.toolStripLabel_window.Name = "toolStripLabel_window";
            this.toolStripLabel_window.Size = new System.Drawing.Size(64, 22);
            this.toolStripLabel_window.Text = "Window";
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.tileToolStripMenuItem.Text = "Overworld";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.cascadeToolStripMenuItem.Text = "Dungeon";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Music";
            // 
            // worldMapsToolStripMenuItem
            // 
            this.worldMapsToolStripMenuItem.Name = "worldMapsToolStripMenuItem";
            this.worldMapsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.worldMapsToolStripMenuItem.Text = "World maps";
            // 
            // monologuesToolStripMenuItem
            // 
            this.monologuesToolStripMenuItem.Name = "monologuesToolStripMenuItem";
            this.monologuesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.monologuesToolStripMenuItem.Text = "Monologues";
            this.monologuesToolStripMenuItem.Click += new System.EventHandler(this.monologuesToolStripMenuItem_Click);
            // 
            // palettesToolStripMenuItem
            // 
            this.palettesToolStripMenuItem.Name = "palettesToolStripMenuItem";
            this.palettesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.palettesToolStripMenuItem.Text = "Palettes";
            // 
            // dungeonMapsToolStripMenuItem
            // 
            this.dungeonMapsToolStripMenuItem.Name = "dungeonMapsToolStripMenuItem";
            this.dungeonMapsToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.dungeonMapsToolStripMenuItem.Text = "Dungeon Maps";
            // 
            // dungeonPropertiesToolStripMenuItem
            // 
            this.dungeonPropertiesToolStripMenuItem.Name = "dungeonPropertiesToolStripMenuItem";
            this.dungeonPropertiesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.dungeonPropertiesToolStripMenuItem.Text = "Dungeon properties";
            // 
            // menuScreensToolStripMenuItem
            // 
            this.menuScreensToolStripMenuItem.Name = "menuScreensToolStripMenuItem";
            this.menuScreensToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.menuScreensToolStripMenuItem.Text = "Menu screens";
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(41, 22);
            this.toolStripLabel4.Text = "Sound";
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(45, 22);
            this.toolStripLabel5.Text = "Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "Contents";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // form_parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.toolStrip);
            this.IsMdiContainer = true;
            this.Name = "form_parent";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zeldix Magic";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.form_parent_FormClosed);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel_file;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel_window;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem worldMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monologuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem palettesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonMapsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dungeonPropertiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuScreensToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripLabel5;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

