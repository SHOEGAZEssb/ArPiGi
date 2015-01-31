using System.Drawing;

namespace ArPiGi
{
  //The base class that represents the characteristics for all entities and players
  abstract class EntityBase
  {
    private string _name;
    private Image[] _sprites;
    private Image _currentSprite;

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
    /// Creates a new EntityBase
    /// </summary>
    /// <param name="name">name of the base entity</param>
    /// <param name="sprites">all sprites of the entity</param>
    public EntityBase(string name, Image[] sprites)
    {
      Name = name;
      Sprites = sprites;
    }
  }
}