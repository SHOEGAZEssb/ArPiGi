using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArPiGi
{
  class MapPictureBox : PictureBox
  {
    /// <summary>
    /// List of entities to be drawn.
    /// </summary>
    List<EntityBase> _entities;

    /// <summary>
    /// The final image after all entities have been drawn
    /// on top of eachother.
    /// </summary>
    Bitmap _finalImage;

    /// <summary>
    /// The MapTile of this pictureBox.
    /// </summary>
    MapTile _mapTile;

    /// <summary>
    /// Constructor.
    /// </summary>
    public MapPictureBox()
    {
      _entities = new List<EntityBase>();
      _finalImage = new Bitmap(20, 20);
    }

    /// <summary>
    /// Adds an entity to be drawn.
    /// </summary>
    /// <param name="image">Image to be added.</param>
    public void AddEntity(EntityBase entity)
    {
      if(entity != null)
      {
        _entities.Add(entity);
        ReDraw();
      }
      else
        throw new Exception("Entity is null.");
    }

    /// <summary>
    /// Removes an entity to be drawn.
    /// </summary>
    /// <param name="entity">Entity to remove.</param>
    public void RemoveEntity(EntityBase entity)
    {
      if (entity != null)
      {
        if (_entities.Contains(entity))
        {
          _entities.Remove(entity);
          ReDraw();
        }
        else
          throw new Exception("Entity to remove not found.");
      }
      else
        throw new Exception("Can't remove nothing.");
    }
    
    /// <summary>
    /// Draws all images in the <see cref="_images" on top of eachother./>
    /// </summary>
    private void ReDraw()
    {
      using(Graphics g = Graphics.FromImage(_finalImage))
      {
        if (_mapTile.Layer == Layer.Lower)
          g.DrawImage(_mapTile.Sprite, new Point(0, 0));

        foreach(EntityBase entity in _entities)
        {
          Image sprite = entity.CurrentSprite;
          g.DrawImage(sprite, new Rectangle(0, 0, sprite.Width, sprite.Height));
        }

        if(_mapTile.Layer == Layer.Upper)
          g.DrawImage(_mapTile.Sprite, new Point(0, 0));
      }

      Image = _finalImage;
    }
  }
}