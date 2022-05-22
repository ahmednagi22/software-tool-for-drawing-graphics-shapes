namespace Software_Packages
{
    partial class Menu
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
            this.Form2D = new System.Windows.Forms.Button();
            this.Form3D = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Form2D
            // 
            this.Form2D.BackColor = System.Drawing.Color.DodgerBlue;
            this.Form2D.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Form2D.Location = new System.Drawing.Point(253, 108);
            this.Form2D.Name = "Form2D";
            this.Form2D.Size = new System.Drawing.Size(277, 59);
            this.Form2D.TabIndex = 0;
            this.Form2D.Text = "2D Shapes";
            this.Form2D.UseVisualStyleBackColor = false;
            this.Form2D.Click += new System.EventHandler(this.Form2D_Click);
            // 
            // Form3D
            // 
            this.Form3D.BackColor = System.Drawing.Color.DodgerBlue;
            this.Form3D.Location = new System.Drawing.Point(253, 226);
            this.Form3D.Name = "Form3D";
            this.Form3D.Size = new System.Drawing.Size(277, 59);
            this.Form3D.TabIndex = 1;
            this.Form3D.Text = "2D Transformations";
            this.Form3D.UseVisualStyleBackColor = false;
            this.Form3D.Click += new System.EventHandler(this.Form3D_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Form3D);
            this.Controls.Add(this.Form2D);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Form2D;
        private Button Form3D;
    }
}