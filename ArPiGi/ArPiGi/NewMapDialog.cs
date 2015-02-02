using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArPiGi
{
  public partial class NewMapDialog : Form
  {
    private Map _map;

    public Map Map
    {
      get { return _map; }
      private set { _map = value; }
    }

    public NewMapDialog()
    {
      InitializeComponent();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if(textBoxMapName.Text == "")
      {
        MessageBox.Show("Please enter a valid map name.");
        return;
      }

      Map = new Map(textBoxMapName.Text, (int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
      this.Close();
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Map = null;
      this.Close();
    }
  }
}
