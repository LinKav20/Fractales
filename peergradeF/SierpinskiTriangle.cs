using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace peergradeF
{
    public class SierpinskiTriangle : Fractal
    {
        /// <summary>
        /// Constructor of Sierpinski Triangle Fractal.
        /// </summary>
        /// <param name="countOfRec">Count of staps.</param>
        /// <param name="start">Start color for gradient.</param>
        /// <param name="end">End color for gradient.</param>
        /// <param name="g">Graphics to paint.</param>
        /// <param name="canvas">Place where paint.</param>
        public SierpinskiTriangle(int countOfRec, Color start, Color end, Graphics g, Bitmap canvas)
         : base(countOfRec, start, end, g, canvas)
        {
        }
        /// <summary>
        /// Drawing this fractal.
        /// </summary>
        public override void Draw()
        {
            g.Clear(background);
            // The height of the biggest triangle.
            int h = canvasHeight - 40;
            // The coords of thr biggest triangle.
            int x1, x2, x3, y1, y2, y3;
            x1 = (int)(canvasWidth / 2);
            y1 = 0;
            x2 = (int)(canvasWidth / 2 + h / Math.Sqrt(3));
            y2 = h;
            x3 = (int)(canvasWidth / 2 - h / Math.Sqrt(3));
            y3 = h;
            countOfRec--;
            // Draw the biggest triange.
            g.DrawLine(new Pen(colors[colors.Count - 1], 2), x1, y1, x2, y2);
            g.DrawLine(new Pen(colors[colors.Count - 1], 2), x2, y2, x3, y3);
            g.DrawLine(new Pen(colors[colors.Count - 1], 2), x3, y3, x1, y1);
            // Start recurtion.
            DrawStep(x1, y1, x2, y2, x3, y3, countOfRec);
        }
        /// <summary>
        /// Recurtion for this fractal.
        /// </summary>
        /// <param name="x1">The first point X.</param>
        /// <param name="y1">The first point Y.</param>
        /// <param name="x2">The second point X.</param>
        /// <param name="y2">The second point Y.</param>
        /// <param name="x3">The third point X.</param>
        /// <param name="y3">The third point Y.</param>
        /// <param name="rec">Count of iterations.</param>
        public void DrawStep(int x1, int y1, int x2, int y2, int x3, int y3, int rec)
        {
            if (rec > 0)
            {
                // The coords of middle of every size.
                int ax1, ax2, ax3, ay1, ay2, ay3;
                ax1 = (int)((x1 + x3) / 2);
                ay1 = (int)((y1 + y3) / 2);
                ax2 = (int)((x1 + x2) / 2);
                ay2 = (int)((y1 + y2) / 2);
                ax3 = (int)((x2 + x3) / 2);
                ay3 = (int)((y2 + y3) / 2);
                // Drawing new triangle by middles.
                g.DrawLine(new Pen(colors[rec - 1], 1), ax1, ay1, ax2, ay2);
                g.DrawLine(new Pen(colors[rec - 1], 1), ax2, ay2, ax3, ay3);
                g.DrawLine(new Pen(colors[rec - 1], 1), ax3, ay3, ax1, ay1);
                // Draw again triangles.
                DrawStep(ax1, ay1, ax3, ay3, x3, y3, rec - 1);
                DrawStep(x1, y1, ax2, ay2, ax1, ay1, rec - 1);
                DrawStep(ax2, ay2, x2, y2, ax3, ay3, rec - 1);
            }
        }
    }
}
