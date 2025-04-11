namespace Paint
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.newCanvas = new System.Windows.Forms.Button();
            this.blue_button = new System.Windows.Forms.Button();
            this.black_button = new System.Windows.Forms.Button();
            this.red_button = new System.Windows.Forms.Button();
            this.button_yellow = new System.Windows.Forms.Button();
            this.button_green = new System.Windows.Forms.Button();
            this.button_pink = new System.Windows.Forms.Button();
            this.button_purple = new System.Windows.Forms.Button();
            this.button_brown = new System.Windows.Forms.Button();
            this.rubber_button = new System.Windows.Forms.Button();
            this.trackBarWidthPen = new System.Windows.Forms.TrackBar();
            this.button_rubber = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthPen)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(32, 24);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(980, 907);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // newCanvas
            // 
            this.newCanvas.Location = new System.Drawing.Point(1069, 24);
            this.newCanvas.Name = "newCanvas";
            this.newCanvas.Size = new System.Drawing.Size(196, 58);
            this.newCanvas.TabIndex = 1;
            this.newCanvas.Text = "Smazat / Nové plátno";
            this.newCanvas.UseVisualStyleBackColor = true;
            this.newCanvas.Click += new System.EventHandler(this.newCanvas_Click);
            // 
            // blue_button
            // 
            this.blue_button.Location = new System.Drawing.Point(1069, 216);
            this.blue_button.Name = "blue_button";
            this.blue_button.Size = new System.Drawing.Size(196, 58);
            this.blue_button.TabIndex = 2;
            this.blue_button.Text = "Modrá";
            this.blue_button.UseVisualStyleBackColor = true;
            this.blue_button.Click += new System.EventHandler(this.blue_button_Click);
            // 
            // black_button
            // 
            this.black_button.Location = new System.Drawing.Point(1069, 88);
            this.black_button.Name = "black_button";
            this.black_button.Size = new System.Drawing.Size(196, 58);
            this.black_button.TabIndex = 3;
            this.black_button.Text = "Černá";
            this.black_button.UseVisualStyleBackColor = true;
            this.black_button.Click += new System.EventHandler(this.black_button_Click);
            // 
            // red_button
            // 
            this.red_button.Location = new System.Drawing.Point(1069, 280);
            this.red_button.Name = "red_button";
            this.red_button.Size = new System.Drawing.Size(196, 58);
            this.red_button.TabIndex = 4;
            this.red_button.Text = "Červená";
            this.red_button.UseVisualStyleBackColor = true;
            this.red_button.Click += new System.EventHandler(this.red_button_Click);
            // 
            // button_yellow
            // 
            this.button_yellow.Location = new System.Drawing.Point(1069, 344);
            this.button_yellow.Name = "button_yellow";
            this.button_yellow.Size = new System.Drawing.Size(196, 58);
            this.button_yellow.TabIndex = 5;
            this.button_yellow.Text = "Žlutá";
            this.button_yellow.UseVisualStyleBackColor = true;
            this.button_yellow.Click += new System.EventHandler(this.button_yellow_Click);
            // 
            // button_green
            // 
            this.button_green.Location = new System.Drawing.Point(1069, 408);
            this.button_green.Name = "button_green";
            this.button_green.Size = new System.Drawing.Size(196, 58);
            this.button_green.TabIndex = 6;
            this.button_green.Text = "Zelená";
            this.button_green.UseVisualStyleBackColor = true;
            this.button_green.Click += new System.EventHandler(this.button_green_Click);
            // 
            // button_pink
            // 
            this.button_pink.Location = new System.Drawing.Point(1069, 472);
            this.button_pink.Name = "button_pink";
            this.button_pink.Size = new System.Drawing.Size(196, 58);
            this.button_pink.TabIndex = 7;
            this.button_pink.Text = "Žůžová";
            this.button_pink.UseVisualStyleBackColor = true;
            this.button_pink.Click += new System.EventHandler(this.button_pink_Click);
            // 
            // button_purple
            // 
            this.button_purple.Location = new System.Drawing.Point(1069, 536);
            this.button_purple.Name = "button_purple";
            this.button_purple.Size = new System.Drawing.Size(196, 58);
            this.button_purple.TabIndex = 8;
            this.button_purple.Text = "Fialová";
            this.button_purple.UseVisualStyleBackColor = true;
            this.button_purple.Click += new System.EventHandler(this.button_purple_Click);
            // 
            // button_brown
            // 
            this.button_brown.Location = new System.Drawing.Point(1069, 600);
            this.button_brown.Name = "button_brown";
            this.button_brown.Size = new System.Drawing.Size(196, 58);
            this.button_brown.TabIndex = 9;
            this.button_brown.Text = "Hnědá";
            this.button_brown.UseVisualStyleBackColor = true;
            this.button_brown.Click += new System.EventHandler(this.button_brown_Click);
            // 
            // rubber_button
            // 
            this.rubber_button.Location = new System.Drawing.Point(1069, 152);
            this.rubber_button.Name = "rubber_button";
            this.rubber_button.Size = new System.Drawing.Size(196, 58);
            this.rubber_button.TabIndex = 10;
            this.rubber_button.Text = "Bílá";
            this.rubber_button.UseVisualStyleBackColor = true;
            this.rubber_button.Click += new System.EventHandler(this.rubber_button_Click);
            // 
            // trackBarWidthPen
            // 
            this.trackBarWidthPen.Location = new System.Drawing.Point(1069, 673);
            this.trackBarWidthPen.Maximum = 20;
            this.trackBarWidthPen.Minimum = 1;
            this.trackBarWidthPen.Name = "trackBarWidthPen";
            this.trackBarWidthPen.Size = new System.Drawing.Size(196, 69);
            this.trackBarWidthPen.TabIndex = 11;
            this.trackBarWidthPen.Value = 1;
            this.trackBarWidthPen.Scroll += new System.EventHandler(this.trackBarWidthPen_Scroll);
            // 
            // button_rubber
            // 
            this.button_rubber.Location = new System.Drawing.Point(1069, 720);
            this.button_rubber.Name = "button_rubber";
            this.button_rubber.Size = new System.Drawing.Size(196, 58);
            this.button_rubber.TabIndex = 12;
            this.button_rubber.Text = "Guma";
            this.button_rubber.UseVisualStyleBackColor = true;
            this.button_rubber.Click += new System.EventHandler(this.button_rubber_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(1069, 795);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(196, 136);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Uložit obrázek";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 943);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_rubber);
            this.Controls.Add(this.trackBarWidthPen);
            this.Controls.Add(this.rubber_button);
            this.Controls.Add(this.button_brown);
            this.Controls.Add(this.button_purple);
            this.Controls.Add(this.button_pink);
            this.Controls.Add(this.button_green);
            this.Controls.Add(this.button_yellow);
            this.Controls.Add(this.red_button);
            this.Controls.Add(this.black_button);
            this.Controls.Add(this.blue_button);
            this.Controls.Add(this.newCanvas);
            this.Controls.Add(this.canvas);
            this.Name = "Paint";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthPen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button newCanvas;
        private System.Windows.Forms.Button blue_button;
        private System.Windows.Forms.Button black_button;
        private System.Windows.Forms.Button red_button;
        private System.Windows.Forms.Button button_yellow;
        private System.Windows.Forms.Button button_green;
        private System.Windows.Forms.Button button_pink;
        private System.Windows.Forms.Button button_purple;
        private System.Windows.Forms.Button button_brown;
        private System.Windows.Forms.Button rubber_button;
        private System.Windows.Forms.TrackBar trackBarWidthPen;
        private System.Windows.Forms.Button button_rubber;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_save;
    }
}

