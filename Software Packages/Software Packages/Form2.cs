using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Software_Packages
{

    public partial class Overorigin : Form
    {
        bool Triangle = false;
        public Point origin = new Point(391, 339);
        public Overorigin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X1, X2, X3, X4, Y1, Y2, Y3, Y4;
            X1 = Convert.ToInt32(X1Draw.Text);
            Y1 = Convert.ToInt32(Y1Draw.Text);

            X2 = Convert.ToInt32(X2Draw.Text);
            Y2 = Convert.ToInt32(Y2Draw.Text);

            X3 = Convert.ToInt32(X3Draw.Text);
            Y3 = Convert.ToInt32(Y3Draw.Text);

            X4 = Convert.ToInt32(X4Draw.Text);
            Y4 = Convert.ToInt32(Y4Draw.Text);
            panel1.Refresh();
            lineDDA(X1, Y1, X2, Y2, Brushes.Blue);
            lineDDA(X2, Y2, X3, Y3, Brushes.Blue);
            lineDDA(X3, Y3, X4, Y4, Brushes.Blue);
            lineDDA(X1, Y1, X4, Y4, Brushes.Blue);

        }

        private void lineDDA(int x0, int y0, int xEnd, int yEnd, Brush aBrush)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = Convert.ToDouble(dx) / Convert.ToDouble(steps);
            yIncrement = Convert.ToDouble(dy) / Convert.ToDouble(steps);

            var g = panel1.CreateGraphics();
            setPixel(Math.Round(x), Math.Round(y), aBrush, g);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                setPixel(Math.Round(x), Math.Round(y), aBrush, g);
            }
        }

        private void setPixel(double x, double y, Brush aBrush, Graphics g)
        {
            g.FillRectangle(aBrush, Convert.ToInt32(x) + origin.X, origin.Y - Convert.ToInt32(y), 2, 2);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void Translation2D_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            int X_Translation = Convert.ToInt32(X.Text);
            int Y_Translation = Convert.ToInt32(Y.Text);

            Translation(ref X1, ref Y1, X_Translation, Y_Translation);
            Translation(ref X2, ref Y2, X_Translation, Y_Translation);
            Translation(ref X3, ref Y3, X_Translation, Y_Translation);
            Translation(ref X4, ref Y4, X_Translation, Y_Translation);


            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Green);
                lineDDA(X2, Y2, X3, Y3, Brushes.Green);
                lineDDA(X3, Y3, X1, Y1, Brushes.Green);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Green);
                lineDDA(X2, Y2, X3, Y3, Brushes.Green);
                lineDDA(X3, Y3, X4, Y4, Brushes.Green);
                lineDDA(X1, Y1, X4, Y4, Brushes.Green);
            }
        }
        public void Translation(ref int X, ref int Y, int X_Translation, int Y_Translation)

        {
            //X += X_Translation;
            //Y += Y_Translation;
            int[,] transArray = { { 1, 0, X_Translation }, { 0, 1, Y_Translation }, { 0, 0, 1 } };

            int[,] point1 = { { X }, { Y }, { 1 } };
            int[,] Result = new int[1, 3];
            for (int i = 0; i < transArray.GetLength(0); i++)
            {
                for (int j = 0; j < transArray.GetLength(1); j++)
                {
                    Result[0, i] += transArray[i, j] * point1[j, 0];
                }

            }
            X = Result[0, 0];
            Y = Result[0, 1];

        }
        public void Scaling(ref int X, ref int Y, int X_Scaling, int Y_Scaling)
        {
            //X = X * X_Scaling;
            //Y = Y * Y_Scaling;
            int[,] scallArray = { { X_Scaling, 0, 0 }, { 0, Y_Scaling, 0 }, { 0, 0, 1 } };

            int[,] point1 = { { X, 0, 0 }, { 0, Y, 0 }, { 0, 0, 1 } };
            int[,] Result = new int[3, 3];
            for (int i = 0; i < scallArray.GetLength(0); i++)
            {
                for (int j = 0; j < scallArray.GetLength(1); j++)
                {
                    Result[i,j] = scallArray[i, j] * point1[i, j];
                }

            }
            X = Result[0, 0];
            Y = Result[1, 1];
        }
        public void Rotation(ref int X, ref int Y, double Angel)
        {

            double con, sin;
            con = Cos(Angel);
            sin = Math.Sin(Math.PI * Convert.ToDouble(Angel / 180));

            //x = (X * con) - (Y * sin);
            //y = (X * sin) + (Y * con);
            double[,] RotateArray = { { con, -sin, 0 }, { sin, con, 0 }, { 0, 0, 1 } };

            double[,] point1 = { { X }, { Y }, { 1 } };
            double[,] Result = new double[1, 3];
            for (int i = 0; i < RotateArray.GetLength(0); i++)
            {
                for (int j = 0; j < RotateArray.GetLength(1); j++)
                {
                    Result[0, i] += RotateArray[i, j] * point1[j, 0];
                }

            }
            //X = Result[0, 0];
            //Y = Result[0, 1];



            X = Convert.ToInt32(Math.Round(Result[0, 0]));
            Y = Convert.ToInt32(Math.Round(Result[0, 1]));
        }
        
        public double Cos(double Angel)
        {
            double angel = Convert.ToInt32(Math.Cos(Math.PI * Angel / 180) * 1000);
            angel = Convert.ToDouble(angel / 1000);
            return angel;
        }
        private void Scaling2D_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            int X_Scaling = Convert.ToInt32(X.Text);
            int Y_Scaling = Convert.ToInt32(Y.Text);

            Scaling(ref X1, ref Y1, X_Scaling, Y_Scaling);
            Scaling(ref X2, ref Y2, X_Scaling, Y_Scaling);
            Scaling(ref X3, ref Y3, X_Scaling, Y_Scaling);
            Scaling(ref X4, ref Y4, X_Scaling, Y_Scaling);

            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Red);
                lineDDA(X2, Y2, X3, Y3, Brushes.Red);
                lineDDA(X3, Y3, X1, Y1, Brushes.Red);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Red);
                lineDDA(X2, Y2, X3, Y3, Brushes.Red);
                lineDDA(X3, Y3, X4, Y4, Brushes.Red);
                lineDDA(X1, Y1, X4, Y4, Brushes.Red);
            }
        }
        public void Shearing_X(ref int X, ref int Y, int X_Shearing)
        {

            //x = X + X_Shearing * Y;
            int[,] SheareXArray = { { 1, X_Shearing }, { 0 ,1}};

            int[,] point1 = { { X }, { Y } };
            int[,] Result = new int[1, 3];
            for (int i = 0; i < SheareXArray.GetLength(0); i++)
            {
                for (int j = 0; j < SheareXArray.GetLength(1); j++)
                {
                    Result[0, i] += SheareXArray[i, j] * point1[j, 0];
                }

            }
            X = Result[0,0];
            Y = Result[0,1];
        }
        public void Shearing_Y(ref int X, ref int Y, int Y_Shearing)
        {
            int[,] SheareXArray = { { 1, 0 }, { Y_Shearing, 1 } };

            int[,] point1 = { { X }, { Y } };
            int[,] Result = new int[1, 3];
            for (int i = 0; i < SheareXArray.GetLength(0); i++)
            {
                for (int j = 0; j < SheareXArray.GetLength(1); j++)
                {
                    Result[0, i] += SheareXArray[i, j] * point1[j, 0];
                }

            }
            X = Result[0, 0];
            Y = Result[0, 1];
        
    }
        private void Rotation2D_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);

            int Angel = Convert.ToInt32(angel.Text);

            Rotation(ref X1, ref Y1, Angel);
            Rotation(ref X2, ref Y2, Angel);
            Rotation(ref X3, ref Y3, Angel);
            Rotation(ref X4, ref Y4, Angel);



            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Purple);
                lineDDA(X2, Y2, X3, Y3, Brushes.Purple);
                lineDDA(X3, Y3, X1, Y1, Brushes.Purple);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Purple);
                lineDDA(X2, Y2, X3, Y3, Brushes.Purple);
                lineDDA(X3, Y3, X4, Y4, Brushes.Purple);
                lineDDA(X1, Y1, X4, Y4, Brushes.Purple);
            }
        }

        private void ShearX_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);

            int X_Shearing = Convert.ToInt32(ShX.Text);

            Shearing_X(ref X1, ref Y1, X_Shearing);
            Shearing_X(ref X2, ref Y2, X_Shearing);
            Shearing_X(ref X3, ref Y3, X_Shearing);
            Shearing_X(ref X4, ref Y4, X_Shearing);



            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Yellow);
                lineDDA(X2, Y2, X3, Y3, Brushes.Yellow);
                lineDDA(X3, Y3, X1, Y1, Brushes.Yellow);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Yellow);
                lineDDA(X2, Y2, X3, Y3, Brushes.Yellow);
                lineDDA(X3, Y3, X4, Y4, Brushes.Yellow);
                lineDDA(X1, Y1, X4, Y4, Brushes.Yellow);
            }

        }

        private void ShearY_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);

            int Y_Shearing = Convert.ToInt32(ShY.Text);

            Shearing_Y(ref X1, ref Y1, Y_Shearing);
            Shearing_Y(ref X2, ref Y2, Y_Shearing);
            Shearing_Y(ref X3, ref Y3, Y_Shearing);
            Shearing_Y(ref X4, ref Y4, Y_Shearing);

            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.DarkOrange);
                lineDDA(X2, Y2, X3, Y3, Brushes.DarkOrange);
                lineDDA(X3, Y3, X1, Y1, Brushes.DarkOrange);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.DarkOrange);
                lineDDA(X2, Y2, X3, Y3, Brushes.DarkOrange);
                lineDDA(X3, Y3, X4, Y4, Brushes.DarkOrange);
                lineDDA(X1, Y1, X4, Y4, Brushes.DarkOrange);
            }
        }

        private void OverY_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            ReflectY(ref X1, ref Y1);
            ReflectY(ref X2, ref Y2);
            ReflectY(ref X3, ref Y3);
            ReflectY(ref X4, ref Y4);

            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.DarkOliveGreen);
                lineDDA(X2, Y2, X3, Y3, Brushes.DarkOliveGreen);
                lineDDA(X3, Y3, X1, Y1, Brushes.DarkOliveGreen);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.DarkOliveGreen);
                lineDDA(X2, Y2, X3, Y3, Brushes.DarkOliveGreen);
                lineDDA(X3, Y3, X4, Y4, Brushes.DarkOliveGreen);
                lineDDA(X1, Y1, X4, Y4, Brushes.DarkOliveGreen);
            }
        }

        private void ReflectY(ref int X, ref int Y)
        {
            int[,] OverYArray = { { -1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };

            int[,] point1 = { { X }, { Y }, { 1 } };
            int[,] Result = new int[1, 3];
            for (int i = 0; i < OverYArray.GetLength(0); i++)
            {
                for (int j = 0; j < OverYArray.GetLength(1); j++)
                {
                    Result[0, i] += OverYArray[i, j] * point1[j, 0];
                }

            }
            X = Result[0, 0];
            Y = Result[0, 1];
        }
        private void OverX_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            ReflectX(ref X1, ref Y1);
            ReflectX(ref X2, ref Y2);
            ReflectX(ref X3, ref Y3);
            ReflectX(ref X4, ref Y4);

            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Brown);
                lineDDA(X2, Y2, X3, Y3, Brushes.Brown);
                lineDDA(X3, Y3, X1, Y1, Brushes.Brown);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.Brown);
                lineDDA(X2, Y2, X3, Y3, Brushes.Brown);
                lineDDA(X3, Y3, X4, Y4, Brushes.Brown);
                lineDDA(X1, Y1, X4, Y4, Brushes.Brown);
            }
        }
        private void ReflectX(ref int X, ref int Y)
        {
            int[,] OverXArray = { { 1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };

            int[,] point1 = { { X }, { Y }, { 1 } };
            int[,] Result = new int[1, 3];
            for (int i = 0; i < OverXArray.GetLength(0); i++)
            {
                for (int j = 0; j < OverXArray.GetLength(1); j++)
                {
                    Result[0, i] += OverXArray[i, j] * point1[j, 0];
                }

            }
            X = Result[0, 0];
            Y = Result[0, 1];
        }
        private void Overorigin1_Click(object sender, EventArgs e)
        {
            int X1 = Convert.ToInt32(X1Draw.Text);
            int Y1 = Convert.ToInt32(Y1Draw.Text);

            int X2 = Convert.ToInt32(X2Draw.Text);
            int Y2 = Convert.ToInt32(Y2Draw.Text);

            int X3 = Convert.ToInt32(X3Draw.Text);
            int Y3 = Convert.ToInt32(Y3Draw.Text);

            int X4 = Convert.ToInt32(X4Draw.Text);
            int Y4 = Convert.ToInt32(Y4Draw.Text);
            ReflectOrg(ref X1, ref Y1);
            ReflectOrg(ref X2, ref Y2);
            ReflectOrg(ref X3, ref Y3);
            ReflectOrg(ref X4, ref Y4);
            if (Triangle)
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.DarkCyan);
                lineDDA(X2, Y2, X3, Y3, Brushes.DarkCyan);
                lineDDA(X3, Y3, X1, Y1, Brushes.DarkCyan);
            }
            else
            {
                lineDDA(X1, Y1, X2, Y2, Brushes.DarkCyan);
                lineDDA(X2, Y2, X3, Y3, Brushes.DarkCyan);
                lineDDA(X3, Y3, X4, Y4, Brushes.DarkCyan);
                lineDDA(X1, Y1, X4, Y4, Brushes.DarkCyan);
            }
        }
        private void ReflectOrg(ref int X, ref int Y)
        {
            int[,] OverOrgArray = { { -1, 0, 0 }, { 0, -1, 0 }, { 0, 0, 1 } };

            int[,] point1 = { { X }, { Y }, { 1 } };
            int[,] Result = new int[1, 3];
            for (int i = 0; i < OverOrgArray.GetLength(0); i++)
            {
                for (int j = 0; j < OverOrgArray.GetLength(1); j++)
                {
                    Result[0, i] += OverOrgArray[i, j] * point1[j, 0];
                }

            }
            X = Result[0, 0];
            Y = Result[0, 1];
        }
        private void Overorigin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Triangle = true;
            int X1, X2, X3, X4, Y1, Y2, Y3, Y4;
            X1 = Convert.ToInt32(X1Draw.Text);
            Y1 = Convert.ToInt32(Y1Draw.Text);

            X2 = Convert.ToInt32(X2Draw.Text);
            Y2 = Convert.ToInt32(Y2Draw.Text);

            X3 = Convert.ToInt32(X3Draw.Text);
            Y3 = Convert.ToInt32(Y3Draw.Text);


            panel1.Refresh();
            lineDDA(X1, Y1, X2, Y2, Brushes.Blue);
            lineDDA(X2, Y2, X3, Y3, Brushes.Blue);
            lineDDA(X3, Y3, X1, Y1, Brushes.Blue);
        }
    }
}
