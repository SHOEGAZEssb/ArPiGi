using System.Drawing;

namespace ArPiGi
{
  //Represents the players character
  class Player : FightableEntity
  {
    private int _xp;
    private Point _location;

    /// <summary>
    /// Gets/Sets a players experience-points
    /// </summary>
    public int XP
    {
      get { return _xp; }
      private set { _xp = value; }
    }

    /// <summary>
    /// Gets/Sets the players location on the map
    /// </summary>
    public Point Location
    {
      get { return _location; }
      private set { _location = value; }
    }

    /// <summary>
    /// Creates a new player
    /// </summary>
    /// <param name="hp">Healthpower</param>
    /// <param name="mp">Manapower</param>
    /// <param name="strength">Strentgh</param>
    /// <param name="defense">Defensepower</param>
    /// <param name="speed">Speed</param>
    /// <param name="skills">Name of players skills-array</param>
    /// <param name="name">The players name</param>
    /// <param name="sprites">An array with the players sprites</param>
    public Player(int hp, int mp, int strength, int defense, int speed, Skill[] skills, string name, Image[] sprites)
      : base(1, hp, mp, strength, defense, speed, skills, name, sprites)
    {   
      XP = 0;
    }
  }
}