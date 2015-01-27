using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArPiGi
{
  abstract class FightableEntity : EntityBase
  {
    private int _hp;
    private int _mp;
    private int _strength;
    private int _defense;
    private Skill[] _skills;

    public int HP
    {
      get { return _hp; }
      private set { _mp = value; }
    }

    public int MP
    {
      get { return _mp; }
      private set { _mp = value; }
    }

    public int Strength
    {
      get { return _strength; }
      private set { _strength = value; }
    }

    public int Defense
    {
      get { return _defense; }
      private set { _defense = value; }
    }

    public Skill[] Skills
    {
      get { return _skills; }
      private set { _skills = value; }
    }

    public FightableEntity(int hp, int mp, int strength, int defense, Skill[] skills, string name, Image[] sprites)
      : base(name, sprites)
    {
      HP = hp;
      MP = mp;
      Strength = strength;
      Defense = defense;
      Skills = skills;
    }
  }
}
