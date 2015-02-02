using System.Drawing;

namespace ArPiGi
{
  public enum MoveDirection
  {
    Up,
    Right,
    Down,
    Left
  }

  //The base class that represents the characteristics for all entities and players
  public abstract class EntityBase
  {
    private string _name;
    private Image[] _sprites;
    private Image _currentSprite;
    private Point _location;

    /// <summary>
    /// Gets/Sets the name
    /// </summary>
    public string Name
    {
      get { return _name; }
      private set { _name = value; }
    }

    /// <summary>
    /// Gets/Sets the entities sprites array
    /// 0 = Up; 1 = Right; 2 = Down; 3 = Left;
    /// </summary>
    public Image[] Sprites
    {
      get { return _sprites; }
      private set { _sprites = value; }
    }

    /// <summary>
    /// Gets/Sets the Imag of the current sprite
    /// </summary>
    public Image CurrentSprite
    {
      get { return _currentSprite; }
      private set { _currentSprite = value; }
    }

    /// <summary>
    /// Gets/sets the location of this entity.
    /// </summary>
    public Point Location
    {
      get { return _location; }
      set { _location = value; }
    }

    /// <summary>
    /// Creates a new EntityBase
    /// </summary>
    /// <param name="name">name of the base entity</param>
    /// <param name="sprites">all sprites of the entity</param>
    public EntityBase(string name, Image[] sprites)
    {
      Name = name;
      Sprites = sprites;
      CurrentSprite = Sprites[0];
    }

    /// <summary>
    /// Moves this entity and sets it's sprite to the direction it is now facing.
    /// </summary>
    /// <param name="direction">Direction to move.</param>
    public void Move(MoveDirection direction)
    {
      if (direction == MoveDirection.Up)
      {
        CurrentSprite = Sprites[0];
        Location = new Point(Location.X, Location.Y - 1);       
      }
      else if (direction == MoveDirection.Right)
      {
        CurrentSprite = Sprites[1];
        Location = new Point(Location.X + 1, Location.Y);        
      }
      else if (direction == MoveDirection.Down)
      {
        CurrentSprite = Sprites[2];
        Location = new Point(Location.X, Location.Y + 1);      
      }
      else if (direction == MoveDirection.Left)
      {
        CurrentSprite = Sprites[3];
        Location = new Point(Location.X - 1, Location.Y);
      }
    }
  }
}