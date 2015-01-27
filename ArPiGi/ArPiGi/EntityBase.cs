using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArPiGi
{
  abstract class EntityBase
  {
    private string _name;
    private Image[] _sprites;

    public string Name
    {
      get { return _name; }
      private set { _name = value; }
    }

    public Image[] Sprites
    {
      get { return _sprites; }
      private set { _sprites = value; }
    }

    public EntityBase(string name, Image[] sprites)
    {
      Name = name;
      Sprites = sprites;
    }
  }
}
