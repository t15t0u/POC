using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POCTurningText
{
    class Try
    {
        public void DispText(PaintEventArgs e, string Direction, int x, int y, Form1 form)
        {

            string text = "Essai";
            string colorfromgestion = "Blue";
            double rotationAngle = 0;

            switch (Direction)
            {
                case "Haut":
                    {
                        rotationAngle = 0;
                        break;
                    }
                case "Bas":
                    {
                        rotationAngle = 180;
                        break;
                    }
                case "Droite":
                    {
                        rotationAngle = 90;
                        break;
                    }
                case "Gauche":
                    {
                        rotationAngle = 270;
                        break;
                    }
            }

            Graphics graphics = e.Graphics;

            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.Trimming = StringTrimming.None;
            var textBrush = new SolidBrush(Color.FromName(colorfromgestion));

            //Getting the width and height of the text, which we are going to write
            float width = graphics.MeasureString(text, form.Font).Width;
            float height = graphics.MeasureString(text, form.Font).Height;
            double angle = (rotationAngle / 180) * Math.PI;
           
            graphics.TranslateTransform(form.Width / 2 - 150, form.Height / 2 - 150);
            graphics.RotateTransform((float)rotationAngle);
            graphics.DrawString(text, form.Font, textBrush, x, y);
            graphics.ResetTransform();


        }
    }
}
