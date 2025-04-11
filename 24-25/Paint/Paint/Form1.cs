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

        private bool isDrawing = false; //malujeme?
        private List<List<Point>> strokes = new List<List<Point>>(); //list který ukládá list další, díky němuž můžeme normálně kreslit nez spojovacích čar mezi jednotlivými tahy (AI)
        private List<Point> currentDrawingPoints = new List<Point>(); //list pro aktuální points
        private Color currentColor = Color.Black; //Nastavení první defaultní barvy na černou
        private float penWidth = 2; // Defaultní tloušťka pera
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
            using (Pen pen = new Pen(currentColor, penWidth))
            {
                
                foreach (var stroke in strokes)
                {
                    for (int i = 1; i < stroke.Count; i++)
                    {
                        graphics.DrawLine(pen, stroke[i - 1], stroke[i]);
                    }
                }

                
                for (int i = 1; i < currentDrawingPoints.Count; i++)
                {
                    graphics.DrawLine(pen, currentDrawingPoints[i - 1], currentDrawingPoints[i]);
                }
            }
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            //začne s kreslením a následně vymaže points z listu, zároveň zajistí aby se lines nespojily
            isDrawing = true;
            currentDrawingPoints.Clear();
            currentDrawingPoints.Add(e.Location);
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            //ukončí kreslení, přidá line do listu
            isDrawing = false;
            strokes.Add(new List<Point>(currentDrawingPoints));
            currentDrawingPoints.Clear();
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                currentDrawingPoints.Add(e.Location);
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

        //přenastavují barvy
        private void blue_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.Blue;
        }

        private void black_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.Black;
        }

        private void red_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.Red;
        }

        private void button_yellow_Click(object sender, EventArgs e)
        {
            currentColor = Color.Yellow;
        }

        private void button_green_Click(object sender, EventArgs e)
        {
            currentColor = Color.Green;
        }

        private void button_pink_Click(object sender, EventArgs e)
        {
            currentColor = Color.Pink;
        }

        private void button_purple_Click(object sender, EventArgs e)
        {
            currentColor = Color.Purple;
        }

        private void button_brown_Click(object sender, EventArgs e)
        {
            currentColor = Color.Brown;
        }

        private void rubber_button_Click(object sender, EventArgs e)
        {
            currentColor = Color.White;
        }
    }
}
