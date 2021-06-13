using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace peergradeF
{
    public partial class Form1 : Form
    {
        // Starting params and constants.
        Bitmap bmap;
        Graphics g;
        public Size pic;
        public int zoom = 1;
        public int countOfClickedDrawButton = 0;
        public Fractal f;
        Color background = Color.FromArgb(12, 0, 30);

        const int MAX_ZOOM = 8, MIN_ZOOM = 1;
        const int MAX_REC_TREE = 15, MAX_REC_SET = 8, MAX_REC_TRI = 7, MAX_REC_SQ = 7, MAX_REC_CURVE = 8;
        const int MAX_ANGLE_VALUE = 90, MIN_ANGLE_VALUE = 0;
        const int MIN_REC = 1;
        const int MAX_LEN_R = 75, MIN_LEN_R = 50;
        const int MAX_INTERVAL = 20, MIN_INTERVAL = 5;
        /// <summary>
        /// Constructer of the form.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            // Set maximum and minimum size of the window.
            MaximumSize = SystemInformation.PrimaryMonitorSize;
            MinimumSize = new Size(MaximumSize.Width / 2, MaximumSize.Height / 2);
            // Set our place for drawing.
            pic = canvas.Size;
            bmap = new Bitmap(pic.Width * zoom, pic.Height * zoom);
            g = Graphics.FromImage(bmap);
            pictureBox1.Image = bmap;
            pictureBox1.Size = bmap.Size;
            // Settings for color window.
            colorDialogDraw.FullOpen = true;
            colorDialogDraw.Color = this.BackColor;
            // Saying hello.
            MessageBox.Show("Привет!\nВроде тут по интерфейсу все понятно...\n" +
                "Только хотела предупредить, что иногда весь фрактал не помещается на плоскость.\n" +
                "Попробуй увеличить простанство^^" +
                "Только не увеличивай сразу, сначала нарисуй, чтобы точно все ок было. Спасибо!)");
        }
        /// <summary>
        /// Change the size of pictureBox in dependence of the zoom.
        /// </summary>
        /// <param name="zoom">Current zoom.</param>
        public void ChangeZoom(int zoom)
        {
            bmap = new Bitmap(pic.Width * zoom, pic.Height * zoom);
            g = Graphics.FromImage(bmap);
            pictureBox1.Image = bmap;
            pictureBox1.Size = bmap.Size;
        }
        /// <summary>
        /// Function to set start color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartColor_Click(object sender, EventArgs e)
        {
            if (colorDialogDraw.ShowDialog() == DialogResult.Cancel)
                return;
            // Set the forecolor in depence on backcolor.
            if (1 - (0.299 * colorDialogDraw.Color.R + 0.587 * colorDialogDraw.Color.G + 0.114 * colorDialogDraw.Color.B) / 255 < 0.5)
            {
                startColor.ForeColor = Color.Black;
            }
            else
            {
                startColor.ForeColor = Color.White;
            }
            // Set backcolor of the button.
            startColor.BackColor = colorDialogDraw.Color;
        }
        /// <summary>
        /// Changing label of recutrion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CountOfRec_ValueChanged(object sender, EventArgs e)
        {
            countOfRecLabel.Text = "Глубина рекурсии: " + countOfRec.Value;
            // Redrawing fractal.
            if (drawButton.Text == "Настроить новый фрактал")
            {
                ChangeZoom(zoom);
                DrawFractal(nameOfFrac.SelectedItem.ToString());
            }
        }
        /// <summary>
        /// Function to set end color.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndColor_Click(object sender, EventArgs e)
        {
            if (colorDialogDraw.ShowDialog() == DialogResult.Cancel)
                return;
            // Set the forecolor in depence on backcolor.
            if (1 - (0.299 * colorDialogDraw.Color.R + 0.587 * colorDialogDraw.Color.G + 0.114 * colorDialogDraw.Color.B) / 255 < 0.5)
            {
                endColor.ForeColor = Color.Black;
            }
            else
            {
                endColor.ForeColor = Color.White;
            }
            // Set backcolor of the button.
            endColor.BackColor = colorDialogDraw.Color;
        }
        /// <summary>
        /// Function to save fractal as image.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFractal_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            if (sv.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(sv.FileName, ImageFormat.Jpeg);
            }
        }
        /// <summary>
        /// To make picter smaller.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeSmaller_Click(object sender, EventArgs e)
        {
            // If we can zoom something.
            if (drawButton.Text == "Настроить новый фрактал")
            {
                // If zoom is bigger then minimum.
                if (zoom > MIN_ZOOM)
                {
                    zoom--;
                }
                else
                {
                    MessageBox.Show(
                    "Минимальный размер",
                    "Иу",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
                // Redrawing the fractal.
                ChangeZoom(zoom);
                DrawFractal(nameOfFrac.SelectedItem.ToString());
            }
        }
        /// <summary>
        /// To make picter bigger.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MakeBigger_Click(object sender, EventArgs e)
        {
            // If we can zoom something.
            if (drawButton.Text == "Настроить новый фрактал")
            {
                // If zoom is smaller then maximum.
                if (zoom < MAX_ZOOM)
                {
                    zoom++;
                }
                else
                {
                    MessageBox.Show(
                   "Максиммальный размер",
                   "Иу",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information,
                   MessageBoxDefaultButton.Button1,
                   MessageBoxOptions.DefaultDesktopOnly);
                }
                // Redrawing the fractal.
                ChangeZoom(zoom);
                DrawFractal(nameOfFrac.SelectedItem.ToString());
            }
        }
        /// <summary>
        /// The functional depends on click.
        /// If it is even click, we can draw the fractal.
        /// In other way, all params object reset.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DrawButton_Click(object sender, EventArgs e)
        {
            // What type of click.
            if (countOfClickedDrawButton % 2 != 0)
            {
                ChangeZoom(zoom);
                countOfClickedDrawButton++;
                drawButton.Text = "Рисуй!";
                nameOfFrac.Enabled = true;
                startColor.Enabled = true;
                endColor.Enabled = true;
                startColor.BackColor = Color.White;
                endColor.BackColor = Color.White;
                endColor.ForeColor = Color.Black;
                startColor.ForeColor = Color.Black;
                countOfRec.Value = MIN_REC;
                // Reset the value of the listBox.
                nameOfFrac.SelectedIndex = -1;
                g.Clear(background);
                canvas.Invalidate();
            }
            else
            {
                ChangeZoom(zoom);
                // If the fractal is choosen.
                if (nameOfFrac.SelectedIndex != -1)
                {
                    countOfClickedDrawButton++;
                    drawButton.Text = "Настроить новый фрактал";
                    nameOfFrac.Enabled = false;
                    startColor.Enabled = false;
                    endColor.Enabled = false;
                    OptionsCantorSetHide();
                    OptionsTreeFractalHide();
                    DrawFractal(nameOfFrac.SelectedItem.ToString());
                }
                else
                {
                    MessageBox.Show(
                    "Не выбран ни один вид фрактала",
                    "Иу",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }
        /// <summary>
        /// Drawing the fractal by name.
        /// </summary>
        /// <param name="name">Name of the fractal.</param>
        public void DrawFractal(string name)
        {
            // Creating fractal by name.
            switch (name)
            {
                case "Обдуваемое ветром фрактальное дерево":
                    f = new TreeFractal(countOfRec.Value, endColor.BackColor,
                        startColor.BackColor, g, bmap);
                    (f as TreeFractal).LengthScale = firstOptionTrack.Value * 0.01;
                    (f as TreeFractal).SecAngle = Math.PI * thirdOptionTrack.Value / 180;
                    (f as TreeFractal).FirstAngle = Math.PI * secondOptionTrack.Value / 180;
                    break;
                case "Кривая Коха":
                    f = new KochCurve(countOfRec.Value, endColor.BackColor,
                        startColor.BackColor, g, bmap);
                    break;
                case "Ковер Серпинского":
                    f = new SierpinskiCarpet(countOfRec.Value, endColor.BackColor,
                        startColor.BackColor, g, bmap);
                    break;
                case "Треугольник Серпинского":
                    f = new SierpinskiTriangle(countOfRec.Value, endColor.BackColor,
                        startColor.BackColor, g, bmap);
                    break;
                case "Множество Кантора":
                    f = new CantorSet(countOfRec.Value, endColor.BackColor,
                        startColor.BackColor, g, bmap, firstOptionTrack.Value);
                    break;
                default:
                    f = new CantorSet(countOfRec.Value, startColor.BackColor,
                        endColor.BackColor, g, bmap, firstOptionTrack.Value);
                    break;
            }
            // Draw our fractal.
            f.Draw();
            canvas.Invalidate();
        }
        /// <summary>
        /// Set needed setting for each type of fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nameOfFrac_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (nameOfFrac.SelectedItem)
            {
                case "Обдуваемое ветром фрактальное дерево":
                    countOfRec.Maximum = MAX_REC_TREE;
                    OptionsCantorSetHide();
                    OptionsTreeFractalOpen();
                    break;
                case "Кривая Коха":
                    countOfRec.Maximum = MAX_REC_CURVE;
                    OptionsCantorSetHide();
                    OptionsTreeFractalHide();
                    break;
                case "Ковер Серпинского":
                    countOfRec.Maximum = MAX_REC_SQ;
                    OptionsCantorSetHide();
                    OptionsTreeFractalHide();
                    break;
                case "Треугольник Серпинского":
                    countOfRec.Maximum = MAX_REC_TRI;
                    OptionsCantorSetHide();
                    OptionsTreeFractalHide();
                    break;
                case "Множество Кантора":
                    countOfRec.Maximum = MAX_REC_SET;
                    OptionsTreeFractalHide();
                    OptionsCantorSetOpen();
                    break;
                default:
                    OptionsCantorSetHide();
                    OptionsTreeFractalHide();
                    break;
            }
        }
        /// <summary>
        /// Options for tree fractal open.
        /// </summary>
        public void OptionsTreeFractalOpen()
        {
            firstOptionLabel.Visible = true;
            firstOptionLabel.Text = "След отрезок меньше в ";
            secondOptionLabel.Visible = true;
            secondOptionLabel.Text = "Первый угол (правый): ";
            thirdOptionLabel.Visible = true;
            thirdOptionLabel.Text = "Второй угол (левый): ";
            firstOptionTrack.Visible = true;
            secondOptionTrack.Visible = true;
            thirdOptionTrack.Visible = true;
            firstOptionTrack.Maximum = MAX_LEN_R;
            secondOptionTrack.Maximum = MAX_ANGLE_VALUE;
            thirdOptionTrack.Maximum = MAX_ANGLE_VALUE;
            firstOptionTrack.Minimum = MIN_LEN_R;
            secondOptionTrack.Minimum = MIN_ANGLE_VALUE;
            thirdOptionTrack.Minimum = MIN_ANGLE_VALUE;
        }
        /// <summary>
        /// Options for tree fractal hide.
        /// </summary>
        public void OptionsTreeFractalHide()
        {
            firstOptionLabel.Visible = false;
            secondOptionLabel.Visible = false;
            thirdOptionLabel.Visible = false;
            firstOptionTrack.Visible = false;
            secondOptionTrack.Visible = false;
            thirdOptionTrack.Visible = false;
        }
        /// <summary>
        /// Options for cantor set fractal open.
        /// </summary>
        public void OptionsCantorSetOpen()
        {
            firstOptionLabel.Visible = true;
            firstOptionTrack.Visible = true;
            firstOptionLabel.Text = "Расстояние между отрезками: ";
            firstOptionTrack.Maximum = MAX_INTERVAL;
            firstOptionTrack.Minimum = MIN_INTERVAL;
        }
        /// <summary>
        /// Options for cantor set fractal hide.
        /// </summary>
        public void OptionsCantorSetHide()
        {
            firstOptionLabel.Visible = false;
            firstOptionTrack.Visible = false;
        }
        /// <summary>
        /// Change the text of the label in dependence on selected fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstOptionTrack_ValueChanged(object sender, EventArgs e)
        {
            switch (nameOfFrac.SelectedItem)
            {
                case "Обдуваемое ветром фрактальное дерево":
                    firstOptionLabel.Text = "След отрезок больше в " + firstOptionTrack.Value * 0.01 + " раз(а)";
                    break;
                case "Множество Кантора":
                    firstOptionLabel.Text = "Расстояние между отрезками: " + firstOptionTrack.Value;
                    break;
                default:
                    firstOptionLabel.Text = "";
                    break;
            }
        }
        /// <summary>
        /// Change the text of the label in dependence on selected fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondOptionTrack_ValueChanged(object sender, EventArgs e)
        {
            switch (nameOfFrac.SelectedItem)
            {
                case "Обдуваемое ветром фрактальное дерево":
                    secondOptionLabel.Text = "Первый угол (правый): " + secondOptionTrack.Value + "°";
                    break;
                default:
                    secondOptionLabel.Text = "";
                    break;
            }
        }
        /// <summary>
        /// Change the text of the label in dependence on selected fractal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thirdOptionTrack_ValueChanged(object sender, EventArgs e)
        {
            switch (nameOfFrac.SelectedItem)
            {
                case "Обдуваемое ветром фрактальное дерево":
                    thirdOptionLabel.Text = "Второй угол (левый): " + thirdOptionTrack.Value + "°";
                    break;
                default:
                    thirdOptionLabel.Text = "";
                    break;
            }
        }
        /// <summary>
        /// Changing size in dependence of size of the form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_SizeChanged_1(object sender, EventArgs e)
        {
            if (drawButton.Text == "Настроить новый фрактал")
            {
                DrawFractal(nameOfFrac.SelectedItem.ToString());
            }
        }
    }
}
