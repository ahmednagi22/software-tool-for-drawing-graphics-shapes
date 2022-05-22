namespace Software_Packages
{
    public partial class Form1 : Form
    {  public Point origin=new Point(341,253);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DrawLineDDA_Click(object sender, EventArgs e)
        {
             
            panel1.Refresh();
            int X1 = Convert.ToInt32(X1DDA.Text);
            int Y1 = Convert.ToInt32(Y1DDA.Text);
            int X2 = Convert.ToInt32(X2DDA.Text);
            int Y2 = Convert.ToInt32(Y2DDA.Text);

            //lineDDA(X1+214,Y1+170,X2 + 216, -1*(Y2)+170);
            lineDDA(X1, Y1, X2,Y2);
            //panel1.CreateGraphics().DrawLine(Pens.Red,X1,Y1,X2,Y2);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void lineDDA(int x0, int y0, int xEnd, int yEnd)
        {
            int dx = xEnd - x0, dy = yEnd - y0, steps, k;
            double xIncrement, yIncrement, x = x0, y = y0;

            if (Math.Abs(dx) > Math.Abs(dy))
                steps = Math.Abs(dx);
            else
                steps = Math.Abs(dy);
            xIncrement = Convert.ToDouble(dx) / Convert.ToDouble(steps);
            yIncrement = Convert.ToDouble(dy) / Convert.ToDouble(steps);
             var aBrush = Brushes.Blue;
             var g = panel1.CreateGraphics();
        setPixel(Math.Round(x), Math.Round(y),aBrush,g);
            for (k = 0; k < steps; k++)
            {
                x += xIncrement;
                y += yIncrement;
                setPixel(Math.Round(x), Math.Round(y), aBrush, g);
            }
        }
        private void setPixel(double x, double y, Brush aBrush, Graphics g)
        {
            g.FillRectangle(aBrush,Convert.ToInt32(x)+origin.X, origin.Y-Convert.ToInt32(y), 2,2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DrawLineBresenham_Click(object sender, EventArgs e)
        {   
            panel1.Refresh();
            int X1 = Convert.ToInt32(X1Bresenham.Text);
            int Y1 = Convert.ToInt32(Y1Bresenham.Text);
            int X2 = Convert.ToInt32(X2Bresenham.Text);
            int Y2 = Convert.ToInt32(Y2Bresenham.Text);
            double slope;
            if ((X2 - X1) == 0) {
                slope = 99999; }
            else {
                slope = (Y2 - Y1) / (X2 - X1);
            }
            
            bool swap = false;
            //First Octant
            if (X1 < X2 && slope >= 0 && slope <= 1)
            {
                swap = false;
                lineBres(X1, Y1, X2, Y2, 1, 1, swap);
            }
            //Sceond Octant
            else if (Y1 < Y2 && slope > 1 && slope < 999999)
            {
                swap = true;
                lineBres(Y1, X1, Y2, X2, 1, 1, swap);
            }
            //Third Octant
            else if (Y1 < Y2 && slope < -1 && slope > -999999)
            {
                swap = true;
                lineBres(Y1, X1, Y2, X2, 1, -1, swap);
            }
            //Fourth Octant
            else if (X1 > X2 && slope <= 0 && slope >= -1)
            {
                swap = false;
                lineBres(X1, Y1, X2, Y2, -1, 1, swap);
            }
            //Fifth Ocstant
            else if (X1 > X2 && slope > 0 && slope <= 1)
            {
                swap = false;
                lineBres(X1, Y1, X2, Y2, -1, -1, swap);
            }
            //Sixth Ocstant
            else if (Y1 > Y2 && slope > 1 && slope < 999999)
            {
                swap = true;
                lineBres(Y1, X1, Y2, X2, -1, -1, swap);
            }
            //Seventh Ocstant
            else if (Y1 > Y2 && slope < -1 && slope < 999999)
            {
                swap = true;
                lineBres(Y1, X1, Y2, X2, -1, 1, swap);
            }
            //Eighth Ocstant
            else if (X1 < X2 && slope <= 0 && slope >= -1)
            {
                swap = false;
                lineBres(X1, Y1, X2, Y2, 1, -1, swap);
            }
        }
        private void lineBres(int x0, int y0, int xEnd, int yEnd,int Xincrement,int Yincrement,bool swap)
        {

            int dx = Math.Abs(xEnd - x0), dy = Math.Abs(yEnd - y0);
            int x, y, p = 2 * dy - dx;
            int twoDy = 2 * dy, twoDyMinusDx = 2 * (dy - dx);
            x = x0; y = y0;
            /* Determine which endpoint to use as start position.  */
            //if (x0 > xEnd)
            //{
            //    x = xEnd; y = yEnd; xEnd = x0;
            //}
            //else
            //{
            //    x = x0; y = y0;
            //}
            var aBrush = Brushes.Blue;
            var g = panel1.CreateGraphics();
            if(swap)
                setPixel(y, x,aBrush,g);
            else
                setPixel(x, y, aBrush, g);
            while (x != xEnd)
            {
                x+=Xincrement;
                if (p < 0)
                    p += twoDy;
                else
                {
                    y+= Yincrement;
                    p += twoDyMinusDx;
                }
                if (swap)
                    setPixel(y, x, aBrush, g);
                else
                    setPixel(x, y, aBrush, g);
            }
        }



        private void Draw_circle_click_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            int X = Convert.ToInt32(X_Circle.Text);
            int Y = Convert.ToInt32(Y_Circle.Text);
            int Radius = Convert.ToInt32(Radius_Circle.Text);
            Circle_Midpoint(X,Y, Radius);
        }
        private void Circle_Midpoint(int xCenter, int yCenter, int Radius)
        {
            int x = 0;
            int y = Radius;
            int p = 1 - Radius;
            circleplotpoint(xCenter, yCenter, x, y);
            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circleplotpoint(xCenter, yCenter, x, y);
            }
        }
        void circleplotpoint (int xCenter, int yCenter, int x , int y)
        {
            var aBrush = Brushes.Blue;
            var g = panel1.CreateGraphics();
            setPixel(xCenter + x, yCenter + y, aBrush, g);
            setPixel(xCenter - x, yCenter + y, aBrush, g);
            setPixel(xCenter + x, yCenter - y, aBrush, g);
            setPixel(xCenter - x, yCenter - y, aBrush, g);
            setPixel(xCenter + y, yCenter + x, aBrush, g);
            setPixel(xCenter - y, yCenter + x, aBrush, g);
            setPixel(xCenter + y, yCenter - x, aBrush, g);
            setPixel(xCenter - y, yCenter - x, aBrush, g);

        }

        private void ellipse_button_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
            int rx = Convert.ToInt32(rx_ellipse.Text);
            int ry = Convert.ToInt32(ry_ellipse.Text);
            int xc = Convert.ToInt32(xc_ellipse.Text);
            int yc = Convert.ToInt32(yc_ellipse.Text);
            midptellipse(rx, ry, xc, yc);
        }
        void midptellipse(double rx, double ry,
                        double xc, double yc)
        {

            double dx, dy, d1, d2, x, y;
            x = 0;
            y = ry;

            // Initial decision parameter of region 1
            d1 = (ry * ry) - (rx * rx * ry) +
                            (0.25f * rx * rx);
            dx = 2 * ry * ry * x;
            dy = 2 * rx * rx * y;

            // For region 1
            var aBrush = Brushes.Blue;
            var g = panel1.CreateGraphics();
            while (dx < dy)
            {

                // Print points based on 4-way symmetry
                setPixel((x + xc), (y + yc), aBrush, g);
                setPixel((-x + xc), (y + yc), aBrush, g);
                setPixel((x + xc), (-y + yc), aBrush, g);
                setPixel((-x + xc), (-y + yc), aBrush, g);



                // Checking and updating value of
                // decision parameter based on algorithm
                if (d1 < 0)
                {
                    x++;
                    dx = dx + (2 * ry * ry);
                    d1 = d1 + dx + (ry * ry);
                }
                else
                {
                    x++;
                    y--;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d1 = d1 + dx - dy + (ry * ry);
                }
            }

            // Decision parameter of region 2
            d2 = ((ry * ry) * ((x + 0.5f) * (x + 0.5f)))
                + ((rx * rx) * ((y - 1) * (y - 1)))
                - (rx * rx * ry * ry);

            // Plotting points of region 2
            while (y >= 0)
            {

                // printing points based on 4-way symmetry
                setPixel((x + xc), (y + yc), aBrush, g);
                setPixel((-x + xc), (y + yc), aBrush, g);
                setPixel((x + xc), (-y + yc), aBrush, g);
                setPixel((-x + xc), (-y + yc), aBrush, g);

                // Checking and updating parameter
                // value based on algorithm
                if (d2 > 0)
                {
                    y--;
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + (rx * rx) - dy;
                }
                else
                {
                    y--;
                    x++;
                    dx = dx + (2 * ry * ry);
                    dy = dy - (2 * rx * rx);
                    d2 = d2 + dx - dy + (rx * rx);
                }
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }
    }
}