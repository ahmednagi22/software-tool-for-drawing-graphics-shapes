namespace Software_Packages
{
    partial class Overorigin
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
            this.DrawShape = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.X1Draw = new System.Windows.Forms.TextBox();
            this.Y1Draw = new System.Windows.Forms.TextBox();
            this.X2Draw = new System.Windows.Forms.TextBox();
            this.Y2Draw = new System.Windows.Forms.TextBox();
            this.X3Draw = new System.Windows.Forms.TextBox();
            this.Y3Draw = new System.Windows.Forms.TextBox();
            this.X4Draw = new System.Windows.Forms.TextBox();
            this.Y4Draw = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.X = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Translation2D = new System.Windows.Forms.Button();
            this.Scaling2D = new System.Windows.Forms.Button();
            this.angel = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Rotation2D = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ShearX = new System.Windows.Forms.Button();
            this.ShearY = new System.Windows.Forms.Button();
            this.OverX = new System.Windows.Forms.Button();
            this.OverY = new System.Windows.Forms.Button();
            this.Overorigin1 = new System.Windows.Forms.Button();
            this.ShX = new System.Windows.Forms.TextBox();
            this.ShY = new System.Windows.Forms.TextBox();
            this.ShX222 = new System.Windows.Forms.Label();
            this.ShY222 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Draw_Triangle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DrawShape
            // 
            this.DrawShape.BackColor = System.Drawing.Color.DodgerBlue;
            this.DrawShape.Location = new System.Drawing.Point(37, 167);
            this.DrawShape.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DrawShape.Name = "DrawShape";
            this.DrawShape.Size = new System.Drawing.Size(111, 44);
            this.DrawShape.TabIndex = 0;
            this.DrawShape.Text = "Draw Shape";
            this.DrawShape.UseVisualStyleBackColor = false;
            this.DrawShape.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BackgroundImage = global::Software_Packages.Properties.Resources.cartesian_coordinates1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(350, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 677);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Point1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Point2:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-1, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Point3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Point4:";
            // 
            // X1Draw
            // 
            this.X1Draw.Location = new System.Drawing.Point(56, 44);
            this.X1Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X1Draw.Name = "X1Draw";
            this.X1Draw.PlaceholderText = "0";
            this.X1Draw.Size = new System.Drawing.Size(45, 27);
            this.X1Draw.TabIndex = 9;
            this.X1Draw.Text = "0";
            // 
            // Y1Draw
            // 
            this.Y1Draw.Location = new System.Drawing.Point(109, 44);
            this.Y1Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y1Draw.Name = "Y1Draw";
            this.Y1Draw.PlaceholderText = "0";
            this.Y1Draw.Size = new System.Drawing.Size(45, 27);
            this.Y1Draw.TabIndex = 10;
            this.Y1Draw.Text = "0";
            // 
            // X2Draw
            // 
            this.X2Draw.Location = new System.Drawing.Point(218, 44);
            this.X2Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X2Draw.Name = "X2Draw";
            this.X2Draw.PlaceholderText = "0";
            this.X2Draw.Size = new System.Drawing.Size(45, 27);
            this.X2Draw.TabIndex = 11;
            this.X2Draw.Text = "0";
            // 
            // Y2Draw
            // 
            this.Y2Draw.Location = new System.Drawing.Point(271, 44);
            this.Y2Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y2Draw.Name = "Y2Draw";
            this.Y2Draw.PlaceholderText = "0";
            this.Y2Draw.Size = new System.Drawing.Size(45, 27);
            this.Y2Draw.TabIndex = 12;
            this.Y2Draw.Text = "0";
            // 
            // X3Draw
            // 
            this.X3Draw.Location = new System.Drawing.Point(56, 116);
            this.X3Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X3Draw.Name = "X3Draw";
            this.X3Draw.PlaceholderText = "0";
            this.X3Draw.Size = new System.Drawing.Size(45, 27);
            this.X3Draw.TabIndex = 13;
            this.X3Draw.Text = "0";
            // 
            // Y3Draw
            // 
            this.Y3Draw.Location = new System.Drawing.Point(109, 116);
            this.Y3Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y3Draw.Name = "Y3Draw";
            this.Y3Draw.PlaceholderText = "0";
            this.Y3Draw.Size = new System.Drawing.Size(45, 27);
            this.Y3Draw.TabIndex = 14;
            this.Y3Draw.Text = "0";
            // 
            // X4Draw
            // 
            this.X4Draw.Location = new System.Drawing.Point(218, 116);
            this.X4Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X4Draw.Name = "X4Draw";
            this.X4Draw.PlaceholderText = "0";
            this.X4Draw.Size = new System.Drawing.Size(45, 27);
            this.X4Draw.TabIndex = 15;
            this.X4Draw.Text = "0";
            this.X4Draw.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Y4Draw
            // 
            this.Y4Draw.Location = new System.Drawing.Point(271, 116);
            this.Y4Draw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y4Draw.Name = "Y4Draw";
            this.Y4Draw.PlaceholderText = "0";
            this.Y4Draw.Size = new System.Drawing.Size(45, 27);
            this.Y4Draw.TabIndex = 16;
            this.Y4Draw.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 12);
            this.label5.MaximumSize = new System.Drawing.Size(57, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "X1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Y2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 12);
            this.label8.MaximumSize = new System.Drawing.Size(57, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "X2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(117, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Y3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(56, 87);
            this.label10.MaximumSize = new System.Drawing.Size(57, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "X3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(279, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Y4";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(218, 87);
            this.label12.MaximumSize = new System.Drawing.Size(57, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(26, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "X4";
            // 
            // X
            // 
            this.X.Location = new System.Drawing.Point(14, 245);
            this.X.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(58, 27);
            this.X.TabIndex = 25;
            this.X.Text = "0";
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(14, 312);
            this.Y.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(58, 27);
            this.Y.TabIndex = 26;
            this.Y.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 288);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 20);
            this.label13.TabIndex = 28;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 215);
            this.label14.MaximumSize = new System.Drawing.Size(57, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 27;
            this.label14.Text = "X";
            // 
            // Translation2D
            // 
            this.Translation2D.BackColor = System.Drawing.Color.DodgerBlue;
            this.Translation2D.Location = new System.Drawing.Point(94, 245);
            this.Translation2D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Translation2D.Name = "Translation2D";
            this.Translation2D.Size = new System.Drawing.Size(118, 37);
            this.Translation2D.TabIndex = 29;
            this.Translation2D.Text = "2D Translation";
            this.Translation2D.UseVisualStyleBackColor = false;
            this.Translation2D.Click += new System.EventHandler(this.Translation2D_Click);
            // 
            // Scaling2D
            // 
            this.Scaling2D.BackColor = System.Drawing.Color.DodgerBlue;
            this.Scaling2D.Location = new System.Drawing.Point(94, 307);
            this.Scaling2D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Scaling2D.Name = "Scaling2D";
            this.Scaling2D.Size = new System.Drawing.Size(118, 37);
            this.Scaling2D.TabIndex = 30;
            this.Scaling2D.Text = "2D Scaling";
            this.Scaling2D.UseVisualStyleBackColor = false;
            this.Scaling2D.Click += new System.EventHandler(this.Scaling2D_Click);
            // 
            // angel
            // 
            this.angel.Location = new System.Drawing.Point(237, 252);
            this.angel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.angel.Name = "angel";
            this.angel.Size = new System.Drawing.Size(65, 27);
            this.angel.TabIndex = 31;
            this.angel.Text = "90";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(237, 228);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Angel";
            // 
            // Rotation2D
            // 
            this.Rotation2D.BackColor = System.Drawing.Color.DodgerBlue;
            this.Rotation2D.Location = new System.Drawing.Point(233, 307);
            this.Rotation2D.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Rotation2D.Name = "Rotation2D";
            this.Rotation2D.Size = new System.Drawing.Size(98, 37);
            this.Rotation2D.TabIndex = 33;
            this.Rotation2D.Text = "2D Rotation";
            this.Rotation2D.UseVisualStyleBackColor = false;
            this.Rotation2D.Click += new System.EventHandler(this.Rotation2D_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "2D Shearing :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(218, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 20);
            this.label17.TabIndex = 35;
            this.label17.Text = "2D Reflection :";
            // 
            // ShearX
            // 
            this.ShearX.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShearX.Location = new System.Drawing.Point(109, 399);
            this.ShearX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShearX.Name = "ShearX";
            this.ShearX.Size = new System.Drawing.Size(86, 31);
            this.ShearX.TabIndex = 36;
            this.ShearX.Text = "Shear X";
            this.ShearX.UseVisualStyleBackColor = false;
            this.ShearX.Click += new System.EventHandler(this.ShearX_Click);
            // 
            // ShearY
            // 
            this.ShearY.BackColor = System.Drawing.Color.DodgerBlue;
            this.ShearY.Location = new System.Drawing.Point(109, 459);
            this.ShearY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShearY.Name = "ShearY";
            this.ShearY.Size = new System.Drawing.Size(86, 31);
            this.ShearY.TabIndex = 37;
            this.ShearY.Text = "Shear Y";
            this.ShearY.UseVisualStyleBackColor = false;
            this.ShearY.Click += new System.EventHandler(this.ShearY_Click);
            // 
            // OverX
            // 
            this.OverX.BackColor = System.Drawing.Color.DodgerBlue;
            this.OverX.Location = new System.Drawing.Point(227, 401);
            this.OverX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverX.Name = "OverX";
            this.OverX.Size = new System.Drawing.Size(86, 31);
            this.OverX.TabIndex = 38;
            this.OverX.Text = "Over X";
            this.OverX.UseVisualStyleBackColor = false;
            this.OverX.Click += new System.EventHandler(this.OverX_Click);
            // 
            // OverY
            // 
            this.OverY.BackColor = System.Drawing.Color.DodgerBlue;
            this.OverY.Location = new System.Drawing.Point(227, 459);
            this.OverY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OverY.Name = "OverY";
            this.OverY.Size = new System.Drawing.Size(86, 31);
            this.OverY.TabIndex = 39;
            this.OverY.Text = "Over Y";
            this.OverY.UseVisualStyleBackColor = false;
            this.OverY.Click += new System.EventHandler(this.OverY_Click);
            // 
            // Overorigin1
            // 
            this.Overorigin1.BackColor = System.Drawing.Color.DodgerBlue;
            this.Overorigin1.Location = new System.Drawing.Point(231, 512);
            this.Overorigin1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Overorigin1.Name = "Overorigin1";
            this.Overorigin1.Size = new System.Drawing.Size(86, 31);
            this.Overorigin1.TabIndex = 40;
            this.Overorigin1.Text = "Over origin";
            this.Overorigin1.UseVisualStyleBackColor = false;
            this.Overorigin1.Click += new System.EventHandler(this.Overorigin1_Click);
            // 
            // ShX
            // 
            this.ShX.Location = new System.Drawing.Point(39, 399);
            this.ShX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShX.Name = "ShX";
            this.ShX.Size = new System.Drawing.Size(58, 27);
            this.ShX.TabIndex = 41;
            this.ShX.Text = "0";
            // 
            // ShY
            // 
            this.ShY.Location = new System.Drawing.Point(37, 453);
            this.ShY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShY.Name = "ShY";
            this.ShY.Size = new System.Drawing.Size(59, 27);
            this.ShY.TabIndex = 42;
            this.ShY.Text = "0";
            // 
            // ShX222
            // 
            this.ShX222.AutoSize = true;
            this.ShX222.Location = new System.Drawing.Point(0, 401);
            this.ShX222.Name = "ShX222";
            this.ShX222.Size = new System.Drawing.Size(34, 20);
            this.ShX222.TabIndex = 43;
            this.ShX222.Text = "ShX";
            // 
            // ShY222
            // 
            this.ShY222.AutoSize = true;
            this.ShY222.Location = new System.Drawing.Point(0, 459);
            this.ShY222.Name = "ShY222";
            this.ShY222.Size = new System.Drawing.Size(33, 20);
            this.ShY222.TabIndex = 44;
            this.ShY222.Text = "ShY";
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.DodgerBlue;
            this.Clear.Location = new System.Drawing.Point(56, 584);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(246, 51);
            this.Clear.TabIndex = 45;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Draw_Triangle
            // 
            this.Draw_Triangle.BackColor = System.Drawing.Color.DodgerBlue;
            this.Draw_Triangle.Location = new System.Drawing.Point(186, 167);
            this.Draw_Triangle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Draw_Triangle.Name = "Draw_Triangle";
            this.Draw_Triangle.Size = new System.Drawing.Size(118, 44);
            this.Draw_Triangle.TabIndex = 46;
            this.Draw_Triangle.Text = "Draw Triangle";
            this.Draw_Triangle.UseVisualStyleBackColor = false;
            this.Draw_Triangle.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Overorigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 685);
            this.Controls.Add(this.Draw_Triangle);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.ShY222);
            this.Controls.Add(this.ShX222);
            this.Controls.Add(this.ShY);
            this.Controls.Add(this.ShX);
            this.Controls.Add(this.Overorigin1);
            this.Controls.Add(this.OverY);
            this.Controls.Add(this.OverX);
            this.Controls.Add(this.ShearY);
            this.Controls.Add(this.ShearX);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.Rotation2D);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.angel);
            this.Controls.Add(this.Scaling2D);
            this.Controls.Add(this.Translation2D);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.X);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Y4Draw);
            this.Controls.Add(this.X4Draw);
            this.Controls.Add(this.Y3Draw);
            this.Controls.Add(this.X3Draw);
            this.Controls.Add(this.Y2Draw);
            this.Controls.Add(this.X2Draw);
            this.Controls.Add(this.Y1Draw);
            this.Controls.Add(this.X1Draw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawShape);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Overorigin";
            this.Text = "2D Transformation";
            this.Load += new System.EventHandler(this.Overorigin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button DrawShape;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox X1Draw;
        private TextBox Y1Draw;
        private TextBox X2Draw;
        private TextBox Y2Draw;
        private TextBox X3Draw;
        private TextBox Y3Draw;
        private TextBox X4Draw;
        private TextBox Y4Draw;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox X;
        private TextBox Y;
        private Label label13;
        private Label label14;
        private Button Translation2D;
        private Button Scaling2D;
        private TextBox angel;
        private Label label15;
        private Button Rotation2D;
        private Label label16;
        private Label label17;
        private Button ShearX;
        private Button ShearY;
        private Button OverX;
        private Button OverY;
        private Button Overorigin1;
        private TextBox ShX;
        private TextBox ShY;
        private Label ShX222;
        private Label ShY222;
        private Button Clear;
        private Button Draw_Triangle;
    }
}