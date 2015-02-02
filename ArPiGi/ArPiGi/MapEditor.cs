using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ArPiGi
{
  /// <summary>
  /// MapEditor used for creating and editing maps.
  /// </summary>
  public partial class MapEditor : Form
  {
    private MapPictureBox _selectedMapPictureBox;
    private Map _loadedMap;

    /// <summary>
    /// Constructor.
    /// </summary>
    public MapEditor()
    {
      InitializeComponent();
      LoadMapTiles();
    }

    /// <summary>
    /// Loads the available tiles.
    /// </summary>
    private void LoadMapTiles()
    {
      int x = 0;
      int y = 0;

      foreach(MapTile tile in Tiles.MapTiles)
      {
        MapPictureBox box = new MapPictureBox();
        box.MapTileID = tile.ID;
        box.Size = new Size(50, 50);
        box.Location = new Point(x, y);
        box.Click += new EventHandler(SelectMapPictureBoxes_Click);
        selectPanel.Controls.Add(box);

        if (x == 150)
        {
          x = 0;
          y += 50;
        }
        else
          x += 50;       
      }
    }

    /// <summary>
    /// Click event for the MapPictureBoxes which hold the available tiles.
    /// Selects the clicked tile.
    /// </summary>
    private void SelectMapPictureBoxes_Click(object sender, EventArgs e)
    {
      if(_selectedMapPictureBox != null)
        _selectedMapPictureBox.BorderStyle = BorderStyle.None;

      MapPictureBox clickedBox = (MapPictureBox)sender;
      _selectedMapPictureBox = clickedBox;
      clickedBox.BorderStyle = BorderStyle.Fixed3D;
    }

    /// <summary>
    /// Click event for the MapPictureBoxes which hold the tiles of the currently loaded map.
    /// Places the selected tile on the clicked MapPictureBox.
    /// </summary>
    private void MapPictureBoxes_Click(object sender, EventArgs e)
    {
      MapPictureBox clickedBox = (MapPictureBox)sender;
      clickedBox.MapTileID = _selectedMapPictureBox.MapTileID;


    }

    /// <summary>
    /// Creates a new map via the NewMapDialog.
    /// </summary>
    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
      NewMapDialog dlg = new NewMapDialog();
      dlg.ShowDialog();

      if(dlg.Map != null)
      {
        _loadedMap = dlg.Map;
        InitializeMap();
      }
    }  

    /// <summary>
    /// Creates the MapPictureBoxes for the loaded map.
    /// </summary>
    private void InitializeMap()
    {
      mapPanel.Controls.Clear();

      int x = 0;
      int y = 0;

      foreach(int id in _loadedMap.Tiles)
      {
        MapPictureBox box = new MapPictureBox();
        box.Size = new Size(50, 50);
        box.Location = new Point(x, y);
        box.MapTileID = id;
        box.BorderStyle = BorderStyle.FixedSingle;
        box.Click += new EventHandler(MapPictureBoxes_Click);
        box.MouseMove += new MouseEventHandler(MapPictureBox_MouseMove);
        box.Tag = new int[] { x / 50, y / 50 }; //Set the int[,] coordinates; Map => tiles
        mapPanel.Controls.Add(box);
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
    /// Fills the MapPictureBoxes even if the left mouse button is held down.
    /// </summary>
    private void MapPictureBox_MouseMove(object sender, MouseEventArgs e)
    {
      MapPictureBox box = (MapPictureBox)sender;

      if (e.Button == MouseButtons.Left)
      {
        Point pt = box.PointToClient(Cursor.Position);
        Rectangle rc = box.ClientRectangle;
        if (rc.Contains(pt))
        {
          box.MapTileID = _selectedMapPictureBox.MapTileID;
        }
      }

      box.Capture = false;
    }

    /// <summary>
    /// Saves the currently loaded map to a file.
    /// </summary>
    private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (_loadedMap == null)
        return;

      ApplyChanges();

      string mapHeader = _loadedMap.Name + ";" + _loadedMap.Width + ";" + _loadedMap.Height;
      

      string mapTiles = "";

      for(int y = 0; y < _loadedMap.Height; y++)
      {
        for(int x = 0; x < _loadedMap.Width; x++)
        {
          mapTiles += _loadedMap.Tiles[x, y];
        }

        mapTiles += "\r\n";
      }

      string[] mapInfo = new string[] { mapHeader, mapTiles };
      File.WriteAllLines(@"..\..\Maps\" + _loadedMap.Name + ".mep", mapInfo);
    }

    /// <summary>
    /// Applies the changes to the "real" map.
    /// </summary>
    private void ApplyChanges()
    {
      foreach(MapPictureBox box in mapPanel.Controls)
      {
        int[] coordinates = (int[])box.Tag;
        _loadedMap.Tiles[coordinates[0], coordinates[1]] = box.MapTileID;
      }
    }

    /// <summary>
    /// Loads a map from a file.
    /// </summary>
    private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();
      dlg.InitialDirectory = System.IO.Path.GetFullPath(Path.Combine(Path.GetDirectoryName(Directory.GetCurrentDirectory()), "..\\Maps"));
      dlg.Filter = "ArPiGi Maps|*.mep";

      if(dlg.ShowDialog() == DialogResult.OK)
      {
        string[] mapInfo = File.ReadAllLines(dlg.FileName);
        string[] mapHeader = mapInfo[0].Split(';');

        Map map = new Map(mapHeader[0], int.Parse(mapHeader[1]), int.Parse(mapHeader[2]));

        for(int y = 0; y < map.Height; y++)
        {
          for(int x = 0; x < map.Width; x++)
          {
            map.Tiles[y, x] = int.Parse(mapInfo[y + 1][x].ToString());
          }
        }

        _loadedMap = map;
        InitializeMap();
      }
    }
  }
}