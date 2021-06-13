using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace peergradeF
{
    public class TreeFractal : Fractal
    {
        public double LengthScale { get; set; }
        public double FirstAngle { get; set; }
        public double SecAngle { get; set; }
        public double currentAngle = Math.PI / 2;
        /// <summary>
        /// Constructor of Tree Fractal.
        /// </summary>
        /// <param name="countOfRec">Count of staps.</param>
        /// <param name="start">Start color for gradient.</param>
        /// <param name="end">End color for gradient.</param>
        /// <param name="g">Graphics to paint.</param>
        /// <param name="canvas">Place where paint.</param>
        public TreeFractal(int countOfRec, Color start, Color end, Graphics g, Bitmap canvas)
         : base(countOfRec, start, end, g, canvas)
        {
        }
        /// <summary>
        /// Drawing fractal.
        /// </summary>
        public override void Draw()
        {
            // Clear the place for drawing.
            g.Clear(background);
            // Start recurtion.
            DrawFractalTree(canvasWidth / 2, canvasHeight, canvasWidth / 8, currentAngle, countOfRec);
        }
        /// <summary>
        /// Drawing this fractal by recurtion.
        /// </summary>
        /// <param name="x">The X coord of start point.</param>
        /// <param name="y">The Y coord of start point.</param>
        /// <param name="length">The lenght of the line.</param>
        /// <param name="currectAngle">The angle from yLine.</param>
        /// <param name="rec">Count of steps.</param>
        public void DrawFractalTree(int x, int y, double length, double currectAngle, int rec)
        {
            // If we should draw.
            if (rec > 0)
            {
                // If we can draw.
                if (length > 1)
                {
                    // New lenght.
                    length *= LengthScale;
                    g.DrawLine(new Pen(colors[rec - 1], 1), x, y, (int)(x + length * Math.Cos(currectAngle)), (int)(y - length * Math.Sin(currectAngle)));
                    // Move ccods from start point to end.
                    x = (int)(x + length * Math.Cos(currectAngle));
                    y = (int)(y - length * Math.Sin(currectAngle));
                    // New steps of recurtions.
                    DrawFractalTree(x, y, length, currectAngle + FirstAngle, rec - 1);
                    DrawFractalTree(x, y, length, currectAngle - SecAngle, rec - 1);
                }
            }
        }
    }

}
