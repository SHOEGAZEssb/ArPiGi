namespace ArPiGi
{
  partial class MapEditor
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
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mapPanel = new System.Windows.Forms.Panel();
      this.selectPanel = new System.Windows.Forms.Panel();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(984, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadMapToolStripMenuItem,
            this.saveMapToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
      this.fileToolStripMenuItem.Text = "File...";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.newToolStripMenuItem.Text = "New";
      this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
      // 
      // loadMapToolStripMenuItem
      // 
      this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
      this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.loadMapToolStripMenuItem.Text = "Load Map";
      // 
      // saveMapToolStripMenuItem
      // 
      this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
      this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.saveMapToolStripMenuItem.Text = "Save Map";
      this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
      // 
      // mapPanel
      // 
      this.mapPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.mapPanel.Dock = System.Windows.Forms.DockStyle.Right;
      this.mapPanel.Location = new System.Drawing.Point(206, 24);
      this.mapPanel.Name = "mapPanel";
      this.mapPanel.Size = new System.Drawing.Size(778, 444);
      this.mapPanel.TabIndex = 2;
      // 
      // selectPanel
      // 
      this.selectPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.selectPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.selectPanel.Location = new System.Drawing.Point(0, 24);
      this.selectPanel.Name = "selectPanel";
      this.selectPanel.Size = new System.Drawing.Size(200, 444);
      this.selectPanel.TabIndex = 3;
      // 
      // MapEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 468);
      this.Controls.Add(this.selectPanel);
      this.Controls.Add(this.mapPanel);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MapEditor";
      this.Text = "MapEditor";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
    private System.Windows.Forms.Panel mapPanel;
    private System.Windows.Forms.Panel selectPanel;
  }
}