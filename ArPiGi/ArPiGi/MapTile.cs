using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArPiGi
{
  /// <summary>
  /// The accessibility of this tile.
  /// </summary>
  enum Layer
  {
    /// <summary>
    /// Entities can walk <b>on</b> this.
    /// </summary>
    Lower,
    /// <summary>
    /// Entities can <b>not</b> walk on or under this. 
    /// </summary>
    Middle,
    /// <summary>
    /// Entities can walk <b>under</b> this.
    /// </summary>
    Upper
  }

  /// <summary>
  /// Represents a tile on the world map.
  /// </summary>
  class MapTile
  {
    private Layer _layer;
    private Image _sprite;

    /// <summary>
    /// The layer of this tile
    /// </summary>
    public Layer Layer
    {
      get { return _layer; }
      private set { _layer = value; }
    }

    /// <summary>
    /// The sprite of this tile.
    /// </summary>
    public Image Sprite
    {
      get { return _sprite; }
      private set { _sprite = value; }
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public MapTile(Layer layer, Image image)
    {
      Layer = layer;
      Sprite = image;
    }
  }
}