using System;
using System.Collections.Generic;
using System.Drawing;

namespace peergradeF
{
    abstract public class Fractal
    {
        protected int countOfRec;
        protected int canvasWidth, canvasHeight;
        protected Color background;
        protected Graphics g;
        protected List<Color> colors;
        /// <summary>
        /// Create a list of colors from start to end.
        /// </summary>
        /// <param name="start">Start color.</param>
        /// <param name="end">End color.</param>
        /// <param name="steps">Steps of recurtion.</param>
        /// <returns></returns>
        public static List<Color> GetGradients(Color start, Color end, int steps)
        {
            List<Color> c = new List<Color>();
            int stepA = ((end.A - start.A) / (steps - 1));
            int stepR = ((end.R - start.R) / (steps - 1));
            int stepG = ((end.G - start.G) / (steps - 1));
            int stepB = ((end.B - start.B) / (steps - 1));

            for (int i = 0; i < steps; i++)
            {
                c.Add( Color.FromArgb(start.A + (stepA * i),
                                            start.R + (stepR * i),
                                            start.G + (stepG * i),
                                            start.B + (stepB * i)));
            }
            return c;
        }
        /// <summary>
        /// Creating just a fractal.
        /// </summary>
        /// <param name="countOfRec">Count of steps.</param>
        /// <param name="start">Start color.</param>
        /// <param name="end">End color.</param>
        /// <param name="g">Instrument for drawing</param>
        /// <param name="canvas">Space for drawing.</param>
        public Fractal(int countOfRec, Color start, Color end, Graphics g, Bitmap canvas)
        {
            this.countOfRec = countOfRec;
            // Create the list with one element if we can't do gradient.
            if (countOfRec > 1)
            {
                this.colors = GetGradients(start, end, countOfRec);
            }
            else
            {
                colors = new List<Color>();
                colors.Add(start);
            }
            background = Color.FromArgb(12, 0, 30);
            this.g = g;
            canvasHeight = canvas.Height;
            canvasWidth = canvas.Width;
        }
        /// <summary>
        /// Drawing fractal.
        /// </summary>
       public virtual void Draw()
        {

        }
    }
}
