using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArPiGi
{
  class MapPictureBox : PictureBox
  {
    /// <summary>
    /// List of images to be drawn.
    /// </summary>
    List<Image> _images;

    /// <summary>
    /// The final image after all images have been drawn
    /// on top of eachother.
    /// </summary>
    Bitmap _finalImage;

    /// <summary>
    /// Constructor.
    /// </summary>
    public MapPictureBox()
    {
      _images = new List<Image>();
      _finalImage = new Bitmap(20, 20);
    }

    /// <summary>
    /// Adds an image to be drawn.
    /// </summary>
    /// <param name="image">Image to be added.</param>
    public void AddImage(Image image)
    {
      if(image != null)
      {
        _images.Add(image);
        ReDraw();
      }
      else
        throw new Exception("Image is null.");
    }

    public void RemoveImage(Image image)
    {
      if (image != null)
      {
        _images.Remove(image);
        ReDraw();
      }
      else
        throw new Exception("Image not found.");
    }
    
    /// <summary>
    /// Draws all images in the <see cref="_images" on top of eachother./>
    /// </summary>
    private void ReDraw()
    {
      using(Graphics g = Graphics.FromImage(_finalImage))
      {
        foreach(Image image in _images)
        {
          g.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height));
        }
      }

      Image = _finalImage;
    }
  }
}