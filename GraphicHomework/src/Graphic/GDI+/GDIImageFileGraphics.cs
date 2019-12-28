using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicHomework
{
    public class GDIImageFileGraphics : GDIPlusGraphic
    {
        Bitmap bitmap;
        public GDIImageFileGraphics(Graphics g) : base(g)
        {
            int width = (int)g.VisibleClipBounds.Width;
            int height = (int)g.VisibleClipBounds.Height;
            
            bitmap = new Bitmap(width, height);
            this.lib = Graphics.FromImage(bitmap);
            this.lib.Clear(Color.White);
            Console.WriteLine("mowrcdfshbnfcccccccccccccccccccccccgvbhnjmfcvghbnjmkccccccccc");
        }
        public override void Release()
        {

            Console.WriteLine("mowrcdfshbnfcccccccccccccccccccccccccccccccc");
            base.Release();
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName);
            }
  
        }
    }

}