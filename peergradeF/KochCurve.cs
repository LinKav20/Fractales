using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace peergradeF
{
    public class KochCurve : Fractal
    {
        /// <summary>
        /// Constructor of Koch Curve Fractal.
        /// </summary>
        /// <param name="countOfRec">Count of staps.</param>
        /// <param name="start">Start color for gradient.</param>
        /// <param name="end">End color for gradient.</param>
        /// <param name="g">Graphics to paint.</param>
        /// <param name="canvas">Place where paint.</param>
        /// <param name="interval">Interval between iterations.</param>
        public KochCurve(int countOfRec, Color start, Color end,  Graphics g, Bitmap canvas)
         : base(countOfRec, start, end, g, canvas)
        {
        }
        /// <summary>
        /// Drawing this fractal.
        /// </summary>
        public override void Draw()
        {
            // Clear the place for drawing.
            g.Clear(background);
            // Coords of line.
            int x1, x2, y1, y2;
            x1 = 0;
            x2 = (int)(canvasWidth);
            y1 = (int)(5 * canvasHeight / 6);
            y2 = (int)(5 * canvasHeight / 6); 
            // Drawing two parts of starting line.
            g.DrawLine(new Pen(colors[countOfRec - 1], 2), 0, 5 * canvasHeight / 6, canvasWidth / 3, 5 * canvasHeight / 6);
            g.DrawLine(new Pen(colors[countOfRec - 1], 2), 2 * canvasWidth / 3, 5 * canvasHeight / 6, canvasWidth, 5 * canvasHeight / 6);
            // Start recurtions.
            DrawKoch(new PointF(x1,y1),new PointF(x2,y2),new PointF(canvasWidth/2,canvasWidth), countOfRec--);
        }
        /// <summary>
        /// Drawing thi fractal recurtion.
        /// </summary>
        /// <param name="p1">Point of the start.</param>
        /// <param name="p2">Point of the end.</param>
        /// <param name="p3">Point of the top.</param>
        /// <param name="rec">Count of iteration.</param>
        public void DrawKoch(PointF p1, PointF p2, PointF p3, int rec)
        {
            // If we need to draw.
            if (rec > 0) 
            {
                // Points of middle of the line.
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                // Points of the top of triangle.
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);
                // Drawing this triangle.
                g.DrawLine(new Pen(colors[rec - 1], 2), p4, pn);
                g.DrawLine(new Pen(colors[rec - 1], 2), p5, pn);
                // Hidden the center part of the base line with background color.
                g.DrawLine(new Pen(background, 2), p4, p5);
                // Drawing next iteration.
                DrawKoch(p4, pn, p5, rec - 1);
                DrawKoch(pn, p5, p4, rec - 1);
                DrawKoch(p1, p4, new PointF((2 * p1.X + p3.X) / 3, (2 * p1.Y + p3.Y) / 3), rec - 1);
                DrawKoch(p5, p2, new PointF((2 * p2.X + p3.X) / 3, (2 * p2.Y + p3.Y) / 3), rec - 1);
            }
        }
    }
}
