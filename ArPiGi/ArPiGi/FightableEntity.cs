using System.Drawing;

namespace ArPiGi
{
  /// <summary>
  /// Represents an entity that can fight and can be fought.
  /// </summary>
  public abstract class FightableEntity : EntityBase
  {
    private int _level;
    private int _hp;
    private int _mp;
    private int _strength;
    private int _defense;
    private int _speed;
    private Skill[] _skills;

    /// <summary>
    /// The level of this entity.
    /// </summary>
    public int Level
    {
      get { return _level; }
      private set { _level = value; }
    }

    /// <summary>
    /// The health points of this entity.
    /// </summary>
    public int HP
    {
      get { return _hp; }
      private set { _hp = value; }
    }

    /// <summary>
    /// The magic points of this entity.
    /// </summary>
    public int MP
    {
      get { return _mp; }
      private set { _mp = value; }
    }

    /// <summary>
    /// The strength stat of this entity.
    /// </summary>
    public int Strength
    {
      get { return _strength; }
      private set { _strength = value; }
    }

    /// <summary>
    /// The defense stat of this entity.
    /// </summary>
    public int Defense
    {
      get { return _defense; }
      private set { _defense = value; }
    }

    /// <summary>
    /// The speed stat of this entity.
    /// </summary>
    public int Speed
    {
      get { return _speed; }
      private set { _speed = value; }
    }

    /// <summary>
    /// The learned skills of this entity.
    /// </summary>
    public Skill[] Skills
    {
      get { return _skills; }
      private set { _skills = value; }
    }

    /// <summary>
    /// Constructor.
    /// </summary>
    public FightableEntity(int level, int hp, int mp, int strength, int defense, int speed, Skill[] skills, string name, Image[] sprites)
      : base(name, sprites)
    {
      Level = level;
      HP = hp;
      MP = mp;
      Strength = strength;
      Defense = defense;
      Speed = speed;
      Skills = skills;
    }
  }
}