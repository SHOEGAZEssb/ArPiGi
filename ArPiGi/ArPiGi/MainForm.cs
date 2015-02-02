using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArPiGi
{
  public partial class MainForm : Form
  {
    private Map _loadedMap;
    private Player _player;

    /// <summary>
    /// Constructor.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    /// <summary>
    /// Creates the MapPictureBoxes for the loaded map.
    /// </summary>
    private void InitializeMap()
    {
      panel1.Controls.Clear();

      int x = 0;
      int y = 0;

      foreach (int id in _loadedMap.Tiles)
      {
        MapPictureBox box = new MapPictureBox();
        box.Size = new Size(50, 50);
        box.Location = new Point(x, y);
        box.MapTileID = id;
        box.BorderStyle = BorderStyle.FixedSingle;
        box.Tag = new int[] { x / 50, y / 50 }; //Set the int[,] coordinates; Map => tiles
        panel1.Controls.Add(box);
        if (x == (_loadedMap.Width * 50) - 50)
        {
          x = 0;
          y += 50;
        }
        else
          x += 50;
      }
    }

    /// <summary>
    /// Moves the player.
    /// </summary>
    private void MainForm_KeyUp(object sender, KeyEventArgs e)
    {
      int index = _player.Location.X + (_player.Location.Y * _loadedMap.Width);
      ((MapPictureBox)panel1.Controls[index]).RemoveEntity(_player);

      if (e.KeyCode == Keys.Up)
      {
        _player.Move(MoveDirection.Up);
      }
      else if (e.KeyCode == Keys.Right)
      {
        _player.Move(MoveDirection.Right);
      }
      else if (e.KeyCode == Keys.Down)
      {
        _player.Move(MoveDirection.Down);
      }
      else if (e.KeyCode == Keys.Left)
      {
        _player.Move(MoveDirection.Left);
      }

      index = _player.Location.X + (_player.Location.Y * _loadedMap.Width);
      ((MapPictureBox)panel1.Controls[index]).AddEntity(_player);
    }

    /// <summary>
    /// Opens the map editor.
    /// </summary>
    private void mapEditorToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      MapEditor editor = new MapEditor();
      editor.ShowDialog();
    }

    /// <summary>
    /// Starts a new game.
    /// </summary>
    private void startGameToolStripMenuItem_Click(object sender, System.EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
      dlg.InitialDirectory = System.IO.Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "..\\Maps"));
      dlg.Filter = "ArPiGi Maps|*.mep";

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        _loadedMap = MapEditor.LoadMap(dlg.FileName);
        InitializeMap();
        Image[] sprites = new Image[] { new Bitmap(@"..\..\Sprites\Up.png"), new Bitmap(@"..\..\Sprites\Right.png"), new Bitmap(@"..\..\Sprites\Down.png"), new Bitmap(@"..\..\Sprites\Left.png"), };
        _player = new Player(1, 1, 1, 1, 1, new Skill[1], "Test", sprites);


        ((MapPictureBox)panel1.Controls[0]).AddEntity(_player);
      }
    }
  }
}