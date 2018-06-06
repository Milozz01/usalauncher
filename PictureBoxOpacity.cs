using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USALauncher
{
    class PictureBoxOpacity : PictureBox
    {

        // Opacity in percent
        private float opacity = 1F;

        public float Opacity
        {
            get
            {
                return opacity;
            }
            set
            {
                opacity = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            if (this.Image != null)
            {
                Bitmap bmp = new Bitmap(this.Image, new Size(this.Width, this.Height));
                ImageAttributes attributes = new ImageAttributes();
                ColorMatrix matrix = new ColorMatrix();

                matrix.Matrix33 = opacity;
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
                pe.Graphics.Clear(Color.FromKnownColor(KnownColor.ButtonFace));
                pe.Graphics.DrawImage(this.Image, new Rectangle(0, 0, bmp.Width, bmp.Height), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);

            }
            else
            {
                base.OnPaint(pe);
            }
            //base.OnPaint(pe);
        }
    }
}
