namespace peergradeF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.upPanel = new System.Windows.Forms.TableLayoutPanel();
            this.colorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startColor = new System.Windows.Forms.Button();
            this.endColor = new System.Windows.Forms.Button();
            this.recPanel = new System.Windows.Forms.TableLayoutPanel();
            this.countOfRecLabel = new System.Windows.Forms.Label();
            this.countOfRec = new System.Windows.Forms.TrackBar();
            this.nameOfFrac = new System.Windows.Forms.ListBox();
            this.lowPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sizePanel = new System.Windows.Forms.TableLayoutPanel();
            this.makeBigger = new System.Windows.Forms.Button();
            this.makeSmaller = new System.Windows.Forms.Button();
            this.drawButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.canvas = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.optionsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstOptionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.firstOptionLabel = new System.Windows.Forms.Label();
            this.firstOptionTrack = new System.Windows.Forms.TrackBar();
            this.secondOptionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.secondOptionLabel = new System.Windows.Forms.Label();
            this.secondOptionTrack = new System.Windows.Forms.TrackBar();
            this.thirdOptionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.thirdOptionLabel = new System.Windows.Forms.Label();
            this.thirdOptionTrack = new System.Windows.Forms.TrackBar();
            this.colorDialogDraw = new System.Windows.Forms.ColorDialog();
            this.mainPanel.SuspendLayout();
            this.upPanel.SuspendLayout();
            this.colorPanel.SuspendLayout();
            this.recPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countOfRec)).BeginInit();
            this.lowPanel.SuspendLayout();
            this.sizePanel.SuspendLayout();
            this.canvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.optionsPanel.SuspendLayout();
            this.firstOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstOptionTrack)).BeginInit();
            this.secondOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondOptionTrack)).BeginInit();
            this.thirdOptionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdOptionTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.ColumnCount = 1;
            this.mainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.Controls.Add(this.upPanel, 0, 0);
            this.mainPanel.Controls.Add(this.lowPanel, 0, 3);
            this.mainPanel.Controls.Add(this.canvas, 0, 2);
            this.mainPanel.Controls.Add(this.optionsPanel, 0, 1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.RowCount = 4;
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.mainPanel.Size = new System.Drawing.Size(800, 572);
            this.mainPanel.TabIndex = 0;
            // 
            // upPanel
            // 
            this.upPanel.ColumnCount = 3;
            this.upPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.upPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.upPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.upPanel.Controls.Add(this.colorPanel, 2, 0);
            this.upPanel.Controls.Add(this.recPanel, 1, 0);
            this.upPanel.Controls.Add(this.nameOfFrac, 0, 0);
            this.upPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upPanel.Location = new System.Drawing.Point(3, 3);
            this.upPanel.Name = "upPanel";
            this.upPanel.RowCount = 1;
            this.upPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.upPanel.Size = new System.Drawing.Size(794, 64);
            this.upPanel.TabIndex = 1;
            // 
            // colorPanel
            // 
            this.colorPanel.ColumnCount = 2;
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.colorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.colorPanel.Controls.Add(this.startColor);
            this.colorPanel.Controls.Add(this.endColor, 1, 0);
            this.colorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.colorPanel.Location = new System.Drawing.Point(531, 3);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.RowCount = 1;
            this.colorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.colorPanel.Size = new System.Drawing.Size(260, 58);
            this.colorPanel.TabIndex = 0;
            // 
            // startColor
            // 
            this.startColor.BackColor = System.Drawing.Color.White;
            this.startColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startColor.Location = new System.Drawing.Point(3, 3);
            this.startColor.Name = "startColor";
            this.startColor.Size = new System.Drawing.Size(124, 52);
            this.startColor.TabIndex = 0;
            this.startColor.Text = "Начальный цвет";
            this.startColor.UseVisualStyleBackColor = false;
            this.startColor.Click += new System.EventHandler(this.StartColor_Click);
            // 
            // endColor
            // 
            this.endColor.BackColor = System.Drawing.Color.White;
            this.endColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endColor.Location = new System.Drawing.Point(133, 3);
            this.endColor.Name = "endColor";
            this.endColor.Size = new System.Drawing.Size(124, 52);
            this.endColor.TabIndex = 1;
            this.endColor.Text = "Конечный цвет";
            this.endColor.UseVisualStyleBackColor = false;
            this.endColor.Click += new System.EventHandler(this.EndColor_Click);
            // 
            // recPanel
            // 
            this.recPanel.ColumnCount = 1;
            this.recPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.recPanel.Controls.Add(this.countOfRecLabel, 0, 0);
            this.recPanel.Controls.Add(this.countOfRec, 0, 1);
            this.recPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recPanel.Location = new System.Drawing.Point(267, 3);
            this.recPanel.Name = "recPanel";
            this.recPanel.RowCount = 2;
            this.recPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.recPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.recPanel.Size = new System.Drawing.Size(258, 58);
            this.recPanel.TabIndex = 1;
            // 
            // countOfRecLabel
            // 
            this.countOfRecLabel.AutoSize = true;
            this.countOfRecLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countOfRecLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.countOfRecLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.countOfRecLabel.Location = new System.Drawing.Point(3, 0);
            this.countOfRecLabel.Name = "countOfRecLabel";
            this.countOfRecLabel.Size = new System.Drawing.Size(252, 23);
            this.countOfRecLabel.TabIndex = 0;
            this.countOfRecLabel.Text = "Глубина рекурсии: -";
            // 
            // countOfRec
            // 
            this.countOfRec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countOfRec.Location = new System.Drawing.Point(3, 26);
            this.countOfRec.Maximum = 20;
            this.countOfRec.Minimum = 1;
            this.countOfRec.Name = "countOfRec";
            this.countOfRec.Size = new System.Drawing.Size(252, 29);
            this.countOfRec.TabIndex = 1;
            this.countOfRec.Value = 2;
            this.countOfRec.ValueChanged += new System.EventHandler(this.CountOfRec_ValueChanged);
            // 
            // nameOfFrac
            // 
            this.nameOfFrac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.nameOfFrac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameOfFrac.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameOfFrac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameOfFrac.ForeColor = System.Drawing.SystemColors.Control;
            this.nameOfFrac.FormattingEnabled = true;
            this.nameOfFrac.ItemHeight = 28;
            this.nameOfFrac.Items.AddRange(new object[] {
            "Обдуваемое ветром фрактальное дерево",
            "Кривая Коха",
            "Ковер Серпинского",
            "Треугольник Серпинского",
            "Множество Кантора"});
            this.nameOfFrac.Location = new System.Drawing.Point(3, 3);
            this.nameOfFrac.Name = "nameOfFrac";
            this.nameOfFrac.Size = new System.Drawing.Size(258, 58);
            this.nameOfFrac.TabIndex = 2;
            this.nameOfFrac.SelectedIndexChanged += new System.EventHandler(this.nameOfFrac_SelectedIndexChanged);
            // 
            // lowPanel
            // 
            this.lowPanel.ColumnCount = 3;
            this.lowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lowPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lowPanel.Controls.Add(this.sizePanel, 1, 0);
            this.lowPanel.Controls.Add(this.drawButton, 2, 0);
            this.lowPanel.Controls.Add(this.saveButton, 0, 0);
            this.lowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.lowPanel.Location = new System.Drawing.Point(3, 495);
            this.lowPanel.Name = "lowPanel";
            this.lowPanel.RowCount = 1;
            this.lowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lowPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.lowPanel.Size = new System.Drawing.Size(794, 74);
            this.lowPanel.TabIndex = 4;
            // 
            // sizePanel
            // 
            this.sizePanel.ColumnCount = 2;
            this.sizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sizePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.sizePanel.Controls.Add(this.makeBigger, 1, 0);
            this.sizePanel.Controls.Add(this.makeSmaller, 0, 0);
            this.sizePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sizePanel.Location = new System.Drawing.Point(267, 3);
            this.sizePanel.Name = "sizePanel";
            this.sizePanel.RowCount = 1;
            this.sizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sizePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.sizePanel.Size = new System.Drawing.Size(258, 68);
            this.sizePanel.TabIndex = 0;
            // 
            // makeBigger
            // 
            this.makeBigger.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.makeBigger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeBigger.ForeColor = System.Drawing.SystemColors.Control;
            this.makeBigger.Location = new System.Drawing.Point(132, 3);
            this.makeBigger.Name = "makeBigger";
            this.makeBigger.Size = new System.Drawing.Size(123, 62);
            this.makeBigger.TabIndex = 1;
            this.makeBigger.Text = "+";
            this.makeBigger.UseVisualStyleBackColor = false;
            this.makeBigger.Click += new System.EventHandler(this.MakeBigger_Click);
            // 
            // makeSmaller
            // 
            this.makeSmaller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.makeSmaller.Dock = System.Windows.Forms.DockStyle.Fill;
            this.makeSmaller.ForeColor = System.Drawing.SystemColors.Control;
            this.makeSmaller.Location = new System.Drawing.Point(3, 3);
            this.makeSmaller.Name = "makeSmaller";
            this.makeSmaller.Size = new System.Drawing.Size(123, 62);
            this.makeSmaller.TabIndex = 0;
            this.makeSmaller.Text = "-";
            this.makeSmaller.UseVisualStyleBackColor = false;
            this.makeSmaller.Click += new System.EventHandler(this.MakeSmaller_Click);
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.drawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawButton.ForeColor = System.Drawing.SystemColors.Control;
            this.drawButton.Location = new System.Drawing.Point(531, 3);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(260, 68);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Рисуй!";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(258, 68);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить!";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveFractal_Click);
            // 
            // canvas
            // 
            this.canvas.AutoScroll = true;
            this.canvas.Controls.Add(this.pictureBox1);
            this.canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.canvas.Location = new System.Drawing.Point(3, 133);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(794, 356);
            this.canvas.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(180, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // optionsPanel
            // 
            this.optionsPanel.ColumnCount = 3;
            this.optionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.optionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.optionsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.optionsPanel.Controls.Add(this.firstOptionPanel, 0, 0);
            this.optionsPanel.Controls.Add(this.secondOptionPanel, 1, 0);
            this.optionsPanel.Controls.Add(this.thirdOptionPanel, 2, 0);
            this.optionsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsPanel.Location = new System.Drawing.Point(3, 73);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.RowCount = 1;
            this.optionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.optionsPanel.Size = new System.Drawing.Size(794, 54);
            this.optionsPanel.TabIndex = 5;
            // 
            // firstOptionPanel
            // 
            this.firstOptionPanel.ColumnCount = 1;
            this.firstOptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.firstOptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.firstOptionPanel.Controls.Add(this.firstOptionLabel, 0, 0);
            this.firstOptionPanel.Controls.Add(this.firstOptionTrack, 0, 1);
            this.firstOptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstOptionPanel.Location = new System.Drawing.Point(3, 3);
            this.firstOptionPanel.Name = "firstOptionPanel";
            this.firstOptionPanel.RowCount = 2;
            this.firstOptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.firstOptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.firstOptionPanel.Size = new System.Drawing.Size(258, 48);
            this.firstOptionPanel.TabIndex = 0;
            // 
            // firstOptionLabel
            // 
            this.firstOptionLabel.AutoSize = true;
            this.firstOptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.firstOptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.firstOptionLabel.Location = new System.Drawing.Point(3, 0);
            this.firstOptionLabel.Name = "firstOptionLabel";
            this.firstOptionLabel.Size = new System.Drawing.Size(48, 19);
            this.firstOptionLabel.TabIndex = 0;
            this.firstOptionLabel.Text = "label1";
            this.firstOptionLabel.Visible = false;
            // 
            // firstOptionTrack
            // 
            this.firstOptionTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstOptionTrack.Location = new System.Drawing.Point(3, 22);
            this.firstOptionTrack.Name = "firstOptionTrack";
            this.firstOptionTrack.Size = new System.Drawing.Size(252, 23);
            this.firstOptionTrack.TabIndex = 1;
            this.firstOptionTrack.Visible = false;
            this.firstOptionTrack.ValueChanged += new System.EventHandler(this.firstOptionTrack_ValueChanged);
            // 
            // secondOptionPanel
            // 
            this.secondOptionPanel.ColumnCount = 1;
            this.secondOptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.secondOptionPanel.Controls.Add(this.secondOptionLabel, 0, 0);
            this.secondOptionPanel.Controls.Add(this.secondOptionTrack, 0, 1);
            this.secondOptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondOptionPanel.Location = new System.Drawing.Point(267, 3);
            this.secondOptionPanel.Name = "secondOptionPanel";
            this.secondOptionPanel.RowCount = 2;
            this.secondOptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.secondOptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.secondOptionPanel.Size = new System.Drawing.Size(258, 48);
            this.secondOptionPanel.TabIndex = 1;
            // 
            // secondOptionLabel
            // 
            this.secondOptionLabel.AutoSize = true;
            this.secondOptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.secondOptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.secondOptionLabel.Location = new System.Drawing.Point(3, 0);
            this.secondOptionLabel.Name = "secondOptionLabel";
            this.secondOptionLabel.Size = new System.Drawing.Size(48, 19);
            this.secondOptionLabel.TabIndex = 0;
            this.secondOptionLabel.Text = "label2";
            this.secondOptionLabel.Visible = false;
            // 
            // secondOptionTrack
            // 
            this.secondOptionTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondOptionTrack.Location = new System.Drawing.Point(3, 22);
            this.secondOptionTrack.Name = "secondOptionTrack";
            this.secondOptionTrack.Size = new System.Drawing.Size(252, 23);
            this.secondOptionTrack.TabIndex = 1;
            this.secondOptionTrack.Visible = false;
            this.secondOptionTrack.ValueChanged += new System.EventHandler(this.secondOptionTrack_ValueChanged);
            // 
            // thirdOptionPanel
            // 
            this.thirdOptionPanel.ColumnCount = 1;
            this.thirdOptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.thirdOptionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.thirdOptionPanel.Controls.Add(this.thirdOptionLabel, 0, 0);
            this.thirdOptionPanel.Controls.Add(this.thirdOptionTrack, 0, 1);
            this.thirdOptionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdOptionPanel.Location = new System.Drawing.Point(531, 3);
            this.thirdOptionPanel.Name = "thirdOptionPanel";
            this.thirdOptionPanel.RowCount = 2;
            this.thirdOptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.thirdOptionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.thirdOptionPanel.Size = new System.Drawing.Size(260, 48);
            this.thirdOptionPanel.TabIndex = 2;
            // 
            // thirdOptionLabel
            // 
            this.thirdOptionLabel.AutoSize = true;
            this.thirdOptionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdOptionLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.thirdOptionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.thirdOptionLabel.Location = new System.Drawing.Point(3, 0);
            this.thirdOptionLabel.Name = "thirdOptionLabel";
            this.thirdOptionLabel.Size = new System.Drawing.Size(254, 19);
            this.thirdOptionLabel.TabIndex = 0;
            this.thirdOptionLabel.Text = "label3";
            this.thirdOptionLabel.Visible = false;
            // 
            // thirdOptionTrack
            // 
            this.thirdOptionTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thirdOptionTrack.Location = new System.Drawing.Point(3, 22);
            this.thirdOptionTrack.Name = "thirdOptionTrack";
            this.thirdOptionTrack.Size = new System.Drawing.Size(254, 23);
            this.thirdOptionTrack.TabIndex = 1;
            this.thirdOptionTrack.Visible = false;
            this.thirdOptionTrack.ValueChanged += new System.EventHandler(this.thirdOptionTrack_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Fractals";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged_1);
            this.mainPanel.ResumeLayout(false);
            this.upPanel.ResumeLayout(false);
            this.colorPanel.ResumeLayout(false);
            this.recPanel.ResumeLayout(false);
            this.recPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.countOfRec)).EndInit();
            this.lowPanel.ResumeLayout(false);
            this.sizePanel.ResumeLayout(false);
            this.canvas.ResumeLayout(false);
            this.canvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.optionsPanel.ResumeLayout(false);
            this.firstOptionPanel.ResumeLayout(false);
            this.firstOptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firstOptionTrack)).EndInit();
            this.secondOptionPanel.ResumeLayout(false);
            this.secondOptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondOptionTrack)).EndInit();
            this.thirdOptionPanel.ResumeLayout(false);
            this.thirdOptionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thirdOptionTrack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainPanel;
        private System.Windows.Forms.ColorDialog colorDialogDraw;
        private System.Windows.Forms.TableLayoutPanel upPanel;
        private System.Windows.Forms.TableLayoutPanel colorPanel;
        private System.Windows.Forms.Button startColor;
        private System.Windows.Forms.Button endColor;
        private System.Windows.Forms.TableLayoutPanel recPanel;
        private System.Windows.Forms.Label countOfRecLabel;
        private System.Windows.Forms.TrackBar countOfRec;
        private System.Windows.Forms.ListBox nameOfFrac;
        private System.Windows.Forms.Button makeSmaller;
        private System.Windows.Forms.Button makeBigger;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel canvas;
        private System.Windows.Forms.TableLayoutPanel lowPanel;
        private System.Windows.Forms.TableLayoutPanel sizePanel;
        private System.Windows.Forms.TableLayoutPanel optionsPanel;
        private System.Windows.Forms.TableLayoutPanel firstOptionPanel;
        private System.Windows.Forms.TableLayoutPanel secondOptionPanel;
        private System.Windows.Forms.TableLayoutPanel thirdOptionPanel;
        private System.Windows.Forms.Label firstOptionLabel;
        private System.Windows.Forms.TrackBar firstOptionTrack;
        private System.Windows.Forms.Label secondOptionLabel;
        private System.Windows.Forms.TrackBar secondOptionTrack;
        private System.Windows.Forms.Label thirdOptionLabel;
        private System.Windows.Forms.TrackBar thirdOptionTrack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button saveButton;
    }
}

