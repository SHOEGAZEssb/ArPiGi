namespace ArPiGi
{
  partial class NewMapDialog
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
      this.lblMapName = new System.Windows.Forms.Label();
      this.textBoxMapName = new System.Windows.Forms.TextBox();
      this.lblWidth = new System.Windows.Forms.Label();
      this.lblHeight = new System.Windows.Forms.Label();
      this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
      this.SuspendLayout();
      // 
      // lblMapName
      // 
      this.lblMapName.AutoSize = true;
      this.lblMapName.Location = new System.Drawing.Point(12, 9);
      this.lblMapName.Name = "lblMapName";
      this.lblMapName.Size = new System.Drawing.Size(62, 13);
      this.lblMapName.TabIndex = 0;
      this.lblMapName.Text = "Map Name:";
      // 
      // textBoxMapName
      // 
      this.textBoxMapName.Location = new System.Drawing.Point(80, 6);
      this.textBoxMapName.Name = "textBoxMapName";
      this.textBoxMapName.Size = new System.Drawing.Size(192, 20);
      this.textBoxMapName.TabIndex = 1;
      // 
      // lblWidth
      // 
      this.lblWidth.AutoSize = true;
      this.lblWidth.Location = new System.Drawing.Point(36, 34);
      this.lblWidth.Name = "lblWidth";
      this.lblWidth.Size = new System.Drawing.Size(38, 13);
      this.lblWidth.TabIndex = 2;
      this.lblWidth.Text = "Width:";
      // 
      // lblHeight
      // 
      this.lblHeight.AutoSize = true;
      this.lblHeight.Location = new System.Drawing.Point(163, 34);
      this.lblHeight.Name = "lblHeight";
      this.lblHeight.Size = new System.Drawing.Size(41, 13);
      this.lblHeight.TabIndex = 3;
      this.lblHeight.Text = "Height:";
      // 
      // numericUpDownHeight
      // 
      this.numericUpDownHeight.Location = new System.Drawing.Point(210, 32);
      this.numericUpDownHeight.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericUpDownHeight.Name = "numericUpDownHeight";
      this.numericUpDownHeight.Size = new System.Drawing.Size(62, 20);
      this.numericUpDownHeight.TabIndex = 4;
      this.numericUpDownHeight.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // numericUpDownWidth
      // 
      this.numericUpDownWidth.Location = new System.Drawing.Point(80, 32);
      this.numericUpDownWidth.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
      this.numericUpDownWidth.Name = "numericUpDownWidth";
      this.numericUpDownWidth.Size = new System.Drawing.Size(62, 20);
      this.numericUpDownWidth.TabIndex = 5;
      this.numericUpDownWidth.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
      // 
      // btnOK
      // 
      this.btnOK.Location = new System.Drawing.Point(107, 73);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(75, 23);
      this.btnOK.TabIndex = 6;
      this.btnOK.Text = "OK";
      this.btnOK.UseVisualStyleBackColor = true;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.Location = new System.Drawing.Point(197, 73);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // NewMapDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 108);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.numericUpDownWidth);
      this.Controls.Add(this.numericUpDownHeight);
      this.Controls.Add(this.lblHeight);
      this.Controls.Add(this.lblWidth);
      this.Controls.Add(this.textBoxMapName);
      this.Controls.Add(this.lblMapName);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "NewMapDialog";
      this.Text = "Create New Map";
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblMapName;
    private System.Windows.Forms.TextBox textBoxMapName;
    private System.Windows.Forms.Label lblWidth;
    private System.Windows.Forms.Label lblHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownHeight;
    private System.Windows.Forms.NumericUpDown numericUpDownWidth;
    private System.Windows.Forms.Button btnOK;
    private System.Windows.Forms.Button btnCancel;
  }
}