using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace ArPiGi
{
  /// <summary>
  /// Static class used for getting MapTiles.
  /// </summary>
  static class Tiles
  {
    private static List<MapTile> _mapTiles = new List<MapTile>();

    /// <summary>
    /// List which holds all available tiles.
    /// </summary>
    public static List<MapTile> MapTiles
    {
      get { return _mapTiles; }
      private set { _mapTiles = value; }
    }

    /// <summary>
    /// Constructor.
    /// Loads all tiles on first instanciation.
    /// </summary>
    static Tiles()
    {
      LoadTiles();
    }

    private static void LoadTiles()
    {
      string[] tileFiles = Directory.GetFiles(@"..\..\Tiles", "*.txt");
      foreach(string file in tileFiles)
      {
        string[] infos = File.ReadAllText(file).Split(';');
        MapTile tile = new MapTile((Layer)int.Parse(infos[0]), new Bitmap(@"..\..\Tiles\" + infos[1]), int.Parse(infos[2]));
        Add(tile);
      }
    }

    /// <summary>
    /// Gets the MapTile with the given id.
    /// </summary>
    /// <param name="id">ID of the MapTile to get.</param>
    /// <returns>MapTile with the given id.</returns>
    public static MapTile GetMapTile(int id)
    {
      return _mapTiles.Where<MapTile>(tile => tile.ID == id).FirstOrDefault();
    }

    /// <summary>
    /// Adds a MapTile to the MapTile list.
    /// </summary>
    /// <param name="tile">MapTile to add.</param>
    private static void Add(MapTile tile)
    {
      _mapTiles.Add(tile);
    }
  }
}