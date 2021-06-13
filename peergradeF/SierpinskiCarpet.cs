using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace peergradeF
{
    public class SierpinskiCarpet : Fractal
    {
        /// <summary>
        /// Constructor of Sierpinski Carpet Fractal.
        /// </summary>
        /// <param name="countOfRec">Count of staps.</param>
        /// <param name="start">Start color for gradient.</param>
        /// <param name="end">End color for gradient.</param>
        /// <param name="g">Graphics to paint.</param>
        /// <param name="canvas">Place where paint.</param>
        /// <param name="interval">Interval between iterations.</param>
        public SierpinskiCarpet(int countOfRec, Color start, Color end,  Graphics g, Bitmap canvas)
         : base(countOfRec, start, end,  g, canvas)
        {
        }
        /// <summary>
        /// Drawing this fractal.
        /// </summary>
        public override void Draw()
        {
            // Clear the place for drawing.
            g.Clear(background);
            int x1, y1, x2, y2, x3, y3, x4, y4;
            // The side of the biggest square.
            int h = (int)canvasHeight - 10;
            x1 = (int)canvasWidth / 2 - h / 2;
            y1 = 0;
            x2 = (int)canvasWidth / 2 + h / 2;
            y2 = 0;
            x4 = (int)canvasWidth / 2 - h / 2;
            y4 = h;
            x3 = (int)canvasWidth / 2 + h / 2;
            y3 = h;
            int a = (int)(x2 - x1);
            // Drawing the biggest square.
            g.DrawLine(new Pen(Color.White, 1), x1, y1, x2, y2);
            g.DrawLine(new Pen(Color.White, 1), x2, y2, x3, y3);
            g.DrawLine(new Pen(Color.White, 1), x3, y3, x4, y4);
            g.DrawLine(new Pen(Color.White, 1), x4, y4, x1, y1);
            // Start recurtion.
            Step(x1, y1, a, countOfRec);
        }
        /// <summary>
        /// Drawing this fractal recurtion.
        /// </summary>
        /// <param name="x1">The coord of X top left point of square.</param>
        /// <param name="y1">The coord of Y top left point of square.</param>
        /// <param name="a">Lenght of the side.</param>
        /// <param name="rec">Count of steps.</param>
        public void Step(int x1, int y1,
                         int a, int rec)
        {
            // If we should draw.
            if (rec > 0)
            {
                // Devide out square on 9 squares.
                // The center square coords an side.
                int nx1, ny1, na;
                nx1 = (int)(x1 + a / 3);
                ny1 = (int)(y1 + a / 3);
                na = (int)(a / 3);
                // Draw the center square.
                var r = new Rectangle(nx1, ny1, na, na);
                g.FillRectangle(new SolidBrush(colors[rec - 1]), r);
                // New steps of recurtion.
                Step(x1, y1, na, rec - 1);
                Step(x1 + na, y1, na, rec - 1);
                Step(x1 + 2 * na, y1, na, rec - 1);
                Step(x1, y1 + na, na, rec - 1);
                Step(x1 + 2 * na, y1 + na, na, rec - 1);
                Step(x1, y1 + 2 * na, na, rec - 1);
                Step(x1 + na, y1 + 2 * na, na, rec - 1);
                Step(x1 + 2 * na, y1 + 2 * na, na, rec - 1);
            }
        }
    }
}
