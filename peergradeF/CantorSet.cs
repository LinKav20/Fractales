using System;
using System.Drawing;

namespace peergradeF
{
    public class CantorSet : Fractal
    {
        int interval;
        int thickness;
        int x1, y1, x2, y2;

        /// <summary>
        /// Constructor of Cantor Set Fractal.
        /// </summary>
        /// <param name="countOfRec">Count of staps.</param>
        /// <param name="start">Start color for gradient.</param>
        /// <param name="end">End color for gradient.</param>
        /// <param name="g">Graphics to paint.</param>
        /// <param name="canvas">Place where paint.</param>
        /// <param name="interval">Interval between iterations.</param>
        public CantorSet(int countOfRec, Color start, Color end, Graphics g, Bitmap canvas, int interval)
         : base(countOfRec, start, end, g, canvas)
        {
            this.interval = interval*10;
            // Thinkness of blocks(?) depends on canvas size.
            thickness = (canvasHeight / countOfRec - interval)/5;
            x1 = 0; x2 = canvasWidth; y1 = 10; y2 = 10;
        }
        /// <summary>
        /// Function to draw the fractal.
        /// </summary>
        public override void Draw()
        {
            // Clearing our space for drawing.
            g.Clear(background);
            DrawCantorSet(x1, y1, x2, y2, countOfRec);
        }

        /// <summary>
        /// Drawing this fractal.
        /// </summary>
        /// <param name="x1">The first point X.</param>
        /// <param name="y1">The first point Y.</param>
        /// <param name="x2">The second point X.</param>
        /// <param name="y2">The second point Y.</param>
        /// <param name="rec">Count of iterations.</param>
        public void DrawCantorSet(int x1, int y1, int x2, int y2, int rec)
        {
            // If we should countinue drawing.
            if (rec > 0)
            {
                g.DrawLine(new Pen(colors[rec - 1], thickness), x1, y1, x2, y2);
                // Devide our line on 3 parts and draw again.
                DrawCantorSet(x1, y2 + interval , x1 + (int)((x2 - x1) / 3), y2 + interval , rec - 1);
                DrawCantorSet(x2 - (int)((x2 - x1) / 3), y2 + interval , x2, y2 + interval , rec - 1);
            }
        }

    }
}
