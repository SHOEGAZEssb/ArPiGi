namespace ArPiGi
{
  /// <summary>
  /// Represents a map in the game.
  /// </summary>
  public class Map
  {
    private int _width;
    private int _height;
    private int[,] _tiles;

    /// <summary>
    /// Gets/sets the width (in tiles) of this map.
    /// </summary>
    public int Width
    {
      get { return _width; }
      private set { _width = value; }
    }

    /// <summary>
    /// Gets/sets the height (in tiles) of this map.
    /// </summary>
    public int Height
    {
      get { return _height; }
      private set { _height = value; }
    }

    /// <summary>
    /// Gets/sets the tiles of this map.
    /// </summary>
    public int[,] Tiles
    {
      get { return _tiles; }
      private set { _tiles = value; }
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public Map(int width, int height)
    {
      Width = width;
      Height = height;
      Tiles = new int[Width, Height];
    }
  }
}