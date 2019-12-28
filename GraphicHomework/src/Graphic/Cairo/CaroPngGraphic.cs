using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cairo;
namespace GraphicHomework
{
    public class CaroPngGraphic : CairoGraphic
    {
        Surface Surface1;
        private Bitmap bitmap;
        string fileName;
        public CaroPngGraphic(System.Drawing.Graphics g) : base(g)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files ( *.png) | *.png";
            Bitmap bitmap = new Bitmap((int)g.VisibleClipBounds.Width, (int)g.VisibleClipBounds.Height);
            (System.Drawing.Graphics.FromImage(bitmap)).Clear(System.Drawing.Color.White); 
        

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(dialog.FileName, ImageFormat.Png);
                this.fileName = dialog.FileName;
            }
            // ----------------------------------------
            Surface1 = new ImageSurface(dialog.FileName);
            lib = new Context(Surface1);
        }
        public override void Release()
        {
            base.Release();
            Surface1.WriteToPng(fileName);
          
        }
    }
}