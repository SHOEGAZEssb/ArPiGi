namespace ArPiGi
{
    partial class MainForm
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.mapEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.startGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mapEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(3, 32);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1079, 631);
      this.panel1.TabIndex = 0;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapEditorToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1079, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // mapEditorToolStripMenuItem
      // 
      this.mapEditorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startGameToolStripMenuItem,
            this.mapEditorToolStripMenuItem1});
      this.mapEditorToolStripMenuItem.Name = "mapEditorToolStripMenuItem";
      this.mapEditorToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
      this.mapEditorToolStripMenuItem.Text = "File...";
      // 
      // startGameToolStripMenuItem
      // 
      this.startGameToolStripMenuItem.Name = "startGameToolStripMenuItem";
      this.startGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.startGameToolStripMenuItem.Text = "Start Game";
      this.startGameToolStripMenuItem.Click += new System.EventHandler(this.startGameToolStripMenuItem_Click);
      // 
      // mapEditorToolStripMenuItem1
      // 
      this.mapEditorToolStripMenuItem1.Name = "mapEditorToolStripMenuItem1";
      this.mapEditorToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
      this.mapEditorToolStripMenuItem1.Text = "Map Editor";
      this.mapEditorToolStripMenuItem1.Click += new System.EventHandler(this.mapEditorToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1079, 631);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mapEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapEditorToolStripMenuItem1;

    }
}