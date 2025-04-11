using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {

        private bool isDrawing = false; //indíkuje jestli user právě teď kreslí
        private List<Stroke> strokes = new List<Stroke>(); //seznam všch tahů co user udělal
        private List<Point> currentDrawingPoints = new List<Point>(); //list pro aktuální points
        private Color currentColor = Color.Black; //nastavení první defaultní barvy na černou
        private float penWidth = 2; //defaultní tloušťka pera
        private Stroke currentStroke; //proměnná aktuálního tahu usera
        private bool isEraser = false; //je aktivní guma? proměnná
        public Paint()
        {
            InitializeComponent();
            //odkáže eventy na metody pro ně určené
            canvas.MouseDown += new MouseEventHandler (canvas_MouseDown);
            canvas.MouseUp += new MouseEventHandler(canvas_MouseUp);
            canvas.MouseMove += new MouseEventHandler(canvas_MouseMove);
            canvas.Paint += new PaintEventHandler(canvas_Paint);
            newCanvas.Click += newCanvas_Click;
            
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {

            Graphics graphics = e.Graphics;

            //Vykreslení všech hotových tahů
            foreach (var stroke in strokes)
            {
                using (Pen pen = new Pen(stroke.Color, stroke.Width))
                {
                    for (int i = 1; i < stroke.Points.Count; i++)
                    {
                        graphics.DrawLine(pen, stroke.Points[i - 1], stroke.Points[i]);
                    }
                }
            }

            //Vykreslení aktuálního tahu
            if (currentStroke != null)
            {
                using (Pen pen = new Pen(currentStroke.Color, currentStroke.Width))
                {
                    for (int i = 1; i < currentStroke.Points.Count; i++)
                    {
                        graphics.DrawLine(pen, currentStroke.Points[i - 1], currentStroke.Points[i]);
                    }
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //spuštění kreslení při tlačítku myši (stisknutí)
            isDrawing = true;
            //nastavení na bílou pokud je aktivní guma
            Color strokeColor = isEraser ? Color.White : currentColor;
            //nový tah
            currentStroke = new Stroke(strokeColor, penWidth, isEraser);
            currentStroke.Points.Add(e.Location);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            //ukončí kreslení, přidá line do listu
            isDrawing = false;
            //přidá ukončený tah do seznamu
            if (currentStroke != null)
            {
                strokes.Add(currentStroke);
                currentStroke = null;
            }
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            //při pohybu myši přidá body do canvas
            if (isDrawing && currentStroke != null)
            {
                currentStroke.Points.Add(e.Location);
                canvas.Invalidate();
            }
        }

        //vymaže kreslení z  plátna/nové plátno
        private void newCanvas_Click(object sender, EventArgs e)
        {
            strokes.Clear();
            currentDrawingPoints.Clear();
            canvas.Invalidate();
        }

        //přenastavují barvy, vypínají případnou gumu
        private void blue_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
            isEraser = false;
        }

        private void black_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
            isEraser = false;
        }

        private void red_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
            isEraser = false;
        }

        private void button_yellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
            isEraser = false;
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
            isEraser = false;
        }

        private void button_pink_Click(object sender, EventArgs e)
        {
            currentColor = Color.Pink;
            isEraser = false;
        }

        private void button_purple_Click(object sender, EventArgs e)
        {
            currentColor = Color.Purple;
            isEraser = false;
        }

        private void button_brown_Click(object sender, EventArgs e)
        {
            currentColor = Color.Brown;
            isEraser = false;
        }

        private void rubber_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
            isEraser = false;
        }

        //nastavý trackbar tloušťku pera podle value trackbaru
        private void trackBarWidthPen_Scroll(object sender, EventArgs e)
        {
            penWidth = trackBarWidthPen.Value;
        }

        //zapne funkci gumy
        private void button_rubber_Click(object sender, EventArgs e)
        {
            isEraser = true;
        }
        private void SaveCanvas()
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "PNG Image|*.png";
            saveDialog.Title = "Uložit obrázek jako PNG";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                //Vytvoříme bitmapu stejné velikosti jako canvas
                Bitmap bmp = new Bitmap(canvas.Width, canvas.Height);
                canvas.DrawToBitmap(bmp, new Rectangle(0, 0, canvas.Width, canvas.Height));

                //Uložíme bitmapu
                bmp.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        //tlačítko na ukládání
        private void button_save_Click(object sender, EventArgs e)
        {
            SaveCanvas();
        }
    }
}
