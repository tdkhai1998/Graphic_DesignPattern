
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicHomework
{
   
    public partial class Form1 : Form
    {
     

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered=true;
            this.bitmap = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
  
        }
        bool isDrawing;
        bool isMoving;
        bool isRe;
        Point startP = new Point();
        Point endP = new Point();

        List<Shape> listShape = new List<Shape>();

        Bitmap bitmap;
       
        private bool isSave;

       
        private int TypeShape = -1;
        private int TypeChart = -1;
        private int TypeGraphic = 1;
        private int TypeDraw = -1;
        CommonGraphics comm;
        private DiagramFactory diagramFactory = new FcFactory();
        const int DRAW_DIAGRAM= 1;
        const int DRAW_SHAPE= 1;

        public Shape createShape()
        {
            ShapeInfo shapeInfo = new ShapeInfo();
            shapeInfo.start = startP;
            shapeInfo.end = endP;
            switch (TypeShape)
            {
                case 7: return diagramFactory.CreateInputBlock(shapeInfo);
                case 8: return diagramFactory.CreateStartBlock(shapeInfo);
                case 2:
                    return new Rec(shapeInfo);
                case 3:
                    return new Ellipse(shapeInfo);
                case 1:
                default:
                    return new Line(shapeInfo);
            } 
        }
        public CommonGraphics createGraphic(System.Drawing.Graphics g)
        {
            switch (TypeGraphic)
            {
                case 3: return new GDIImageFileGraphics(g);
                case 4: return new CaroPngGraphic(g);
                case 2:
                    return new CairoGraphic(g);
                case 1:
                default:
                    return new GDIPlusGraphic(g);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g = (!isSave) ? e.Graphics : this.CreateGraphics();
           
            g.SmoothingMode = SmoothingMode.AntiAlias;
            this.comm = this.createGraphic(g);
            for(int i = 0; i < listShape.Count; i++)
            {
                listShape[i].Draw(comm);
            }
            createShape().Draw(comm);
            if (isSave)
            {
                TypeGraphic = 1;
                isSave = false;
            }
            comm.Release();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (TypeShape == -1)
            {
                this.isDrawing = true;
                this.button1.BackColor = System.Drawing.Color.Gray;
                this.TypeShape = 1;
                isMoving = false;
            }
            else if (TypeShape == 1)
            {
                this.isDrawing = false;
                this.button1.BackColor = System.Drawing.Color.White;
                this.TypeShape = -1;

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                startP = e.Location;
                isMoving = true;
            }
        }
        public System.Drawing.Graphics Graphics1 { get; private set; }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing && isMoving)
            {
                if (isRe)
                {
                    Shape shape = createShape();
                    listShape.Add(shape);
                }
                isMoving = false;
                isRe = false;
            }
        }


        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing && isMoving)
            {
                endP = e.Location;
                Console.WriteLine("reffesh");
                this.Refresh();
                isRe = true;
            }
           
        }
        private void button2_Click(object sender, EventArgs e)
        {

            if (TypeShape == -1)
            {
                this.isDrawing = true;
                this.button2.BackColor = System.Drawing.Color.Gray;
                this.TypeShape = 2;
                isMoving = false;
            }
            else if (TypeShape == 2)
            {
                this.isDrawing = false;
                this.button2.BackColor = System.Drawing.Color.White;
                this.TypeShape = -1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, System.Drawing.Point.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (TypeShape == -1)
            {
                this.isDrawing = true;
                this.button3.BackColor = System.Drawing.Color.Gray;
                this.TypeShape = 3;
                isMoving = false;
            }
            else if(TypeShape==3) 
            {
                this.isDrawing = false;
                this.button3.BackColor = System.Drawing.Color.White;
                this.TypeShape = -1;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.TypeGraphic = this.comboBox1.SelectedIndex + 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.isSave = true;
            this.TypeGraphic = 3;
            this.isDrawing = false;
        }
        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.isSave = true;
            this.TypeGraphic = 4;
            this.isDrawing = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (TypeShape == -1)
            {
                this.isDrawing = true;
                this.button7.BackColor = System.Drawing.Color.Gray;
                this.TypeShape = 7;
                isMoving = false;
            }
            else if (TypeShape == 7)
            {
                this.isDrawing = false;
                this.button7.BackColor = System.Drawing.Color.White;
                this.TypeShape = -1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (TypeShape == -1)
            {
                this.isDrawing = true;
                this.button8.BackColor = System.Drawing.Color.Gray;
                this.TypeShape = 8;
                isMoving = false;
            }
            else if (TypeShape == 8)
            {
                this.isDrawing = false;
                this.button8.BackColor = System.Drawing.Color.White;
                this.TypeShape = -1;
            }
        }
    }
}
