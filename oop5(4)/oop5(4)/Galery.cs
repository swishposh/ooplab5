using oop5_4_.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop5_4_
{
    class Galery : Button
    {
        string text = "";

        private int i = 0;

        public List<Bitmap> images = new List<Bitmap>();

        private StringFormat stringFormat;

        public Galery() : base()
        {
            ForeColor = Color.White;
            Font = new Font("Arial",
                20.25F,
                FontStyle.Bold,
                GraphicsUnit.Point,
                0);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);

            //Bitmap bitmap = new Bitmap(Resources.zzz);
            //pevent.Graphics.DrawImage(bitmap, ClientRectangle);
            // отрисовка прямоугольника     
            //pevent.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
            // отрисовка текста      

            if (images.Count != 0)
                pevent.Graphics.DrawImage(images[i], 0, 0);

            pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), ClientRectangle, stringFormat);

            stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            stringFormat.LineAlignment = StringAlignment.Center;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            //color = Color.Blue;
            text = "images " + (i + 1);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            //color = Color.SkyBlue;
            text = "";
        }

        protected override void OnClick(EventArgs e)
        {
            i++;
            if (i > 2) i = 0;
        }
    }
}
