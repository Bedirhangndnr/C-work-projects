using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAINT
{
    public partial class MyPaint : Form
    {
        Bitmap bitmap = new Bitmap(1920, 1080);
        Pen pen = new Pen(Color.Black, 5);
        bool isDrawing = false;
        int thePenSize = 5;
        Image OpenedFile;
        public MyPaint()
        {
            Graphics graphics = Graphics.FromImage(bitmap);

            InitializeComponent();
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    bitmap.SetPixel(i, j, Color.White);
                }
            }
        }
        int xStartLoc=0, yStartLoc=0;
        int xEndLoc=0, yEndLoc=0;
        private void Board_PB_MouseDown(object sender, MouseEventArgs e)
        {

            if (isDrawing==true)
            {
                isDrawing = false;
            }
            else
            {
                isDrawing = true;
            }
            xStartLoc = e.X;
            yStartLoc = e.Y;

        }
        private void Board_PB_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                isDrawing = false;
            }
            else
            {
                isDrawing = true;
            }
            
            xEndLoc = e.X;
            yEndLoc = e.Y;
            Graphics g = Graphics.FromImage(bitmap);
            if (drawingType==lineBtn.Text)
            {
                pen.Width = thePenSize;
                g.DrawLine(pen, xStartLoc, yStartLoc, xEndLoc, yEndLoc);
                Board_PB.Image = bitmap;
            }
            else if(drawingType == squareBtn.Text)
            {
                g.DrawRectangle(pen, xStartLoc, yStartLoc, xEndLoc-xStartLoc, yEndLoc-yStartLoc);
                Board_PB.Image = bitmap;
            }
            else if (drawingType == triangleBtn.Text)
            {
                g.DrawLine(pen, xStartLoc, yStartLoc, xEndLoc, yEndLoc);
                g.DrawLine(pen, xStartLoc, yStartLoc, xStartLoc - (xEndLoc - xStartLoc), yEndLoc);
                g.DrawLine(pen, xEndLoc, yEndLoc, xStartLoc - (xEndLoc - xStartLoc), yEndLoc);
                g.DrawLine(pen, xStartLoc, yStartLoc, xEndLoc, yEndLoc);
                Board_PB.Image = bitmap;
            }


        }
        string drawingType="dot_pen";
        public void drawSmtng(bool isDrawing, int xLoc, int yLoc)
        {
            Graphics graphics = Graphics.FromImage(bitmap);

            if (isDrawing == true)
            {
                graphics.DrawEllipse(pen, xLoc, yLoc, thePenSize, thePenSize);
                Board_PB.Image = bitmap;
            }
        }
        private void Board_PB_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawingType=="dot_pen")
            {
                drawSmtng(isDrawing, e.X, e.Y);

            }
        }

        private void Red_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;
        }

        private void Black_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Red;

        }

        private void Gold_Btn_Click(object sender, EventArgs e)
        {
            pen.Color = Color.Gold;
        }

        private void PenSize_Click(object sender, EventArgs e)
        {

        }

        private void PenSize_5_Click(object sender, EventArgs e)
        {
            thePenSize = 5;
        }

        private void PenSize_10_Click(object sender, EventArgs e)
        {
            thePenSize = 10;
        }

        private void PenSize_15_Click(object sender, EventArgs e)
        {
            thePenSize = 15;
        }

        private void PenSize_20_Click(object sender, EventArgs e)
        {
            thePenSize = 20;
        }

        private void Save_MenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Jpeg Image| *.jpg|Bitmap Image *bmp|";
            saveFileDialog.Title = "save an ımage file";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        this.Board_PB.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    default:
                        this.Board_PB.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }

        private void Open_Menu_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult dr = openFileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                OpenedFile = Image.FromFile(openFileDialog.FileName);
                Board_PB.Image = OpenedFile;
            }

        }

        private void Board_PB_Click(object sender, EventArgs e)
        {

        }

        private void lineBtn_Click(object sender, EventArgs e)
        {
            drawingType = lineBtn.Text;
        }

        private void eraseBtn_Click(object sender, EventArgs e)
        {
            pen.Color=Color.White;
            drawingType = "dot_pen";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            drawingType = "dot_pen";
            pen.Color = Color.Black;

        }

        private void squareBtn_Click(object sender, EventArgs e)
        {
            drawingType = squareBtn.Text;
        }





        private void triangleBtn_Click(object sender, EventArgs e)
        {
            drawingType = triangleBtn.Text;
        }
    }
}
