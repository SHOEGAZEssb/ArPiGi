using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArPiGi
{
  /// <summary>
  /// Static class used for getting MapTiles.
  /// </summary>
  static class Tiles
  {
    /// <summary>
    /// List which holds all available tiles.
    /// </summary>
    private static List<MapTile> _mapTiles = new List<MapTile>();

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
    public static void Add(MapTile tile)
    {
      _mapTiles.Add(tile);
    }
  }
}