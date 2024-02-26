namespace Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(294, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 21);
            label1.TabIndex = 0;
            label1.Text = "This is from Label one";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(294, 61);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 1;
            label2.Text = "This is from Label two";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(294, 103);
            label3.Name = "label3";
            label3.Size = new Size(178, 21);
            label3.TabIndex = 2;
            label3.Text = "This is from Label three";
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.MediumSpringGreen;
            button1.Location = new Point(0, 12);
            button1.Name = "button1";
            button1.Size = new Size(194, 42);
            button1.TabIndex = 3;
            button1.Text = "Change label1 Color";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.MediumSpringGreen;
            button2.Location = new Point(0, 49);
            button2.Name = "button2";
            button2.Size = new Size(194, 43);
            button2.TabIndex = 4;
            button2.Text = "Change label1 Font";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.MediumSpringGreen;
            button3.Location = new Point(-1, 122);
            button3.Name = "button3";
            button3.Size = new Size(195, 42);
            button3.TabIndex = 5;
            button3.Text = "Change label2 Color";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.MediumSpringGreen;
            button4.Location = new Point(-1, 159);
            button4.Name = "button4";
            button4.Size = new Size(195, 43);
            button4.TabIndex = 6;
            button4.Text = "Change label2 Font";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.MediumSpringGreen;
            button5.Location = new Point(0, 236);
            button5.Name = "button5";
            button5.Size = new Size(194, 42);
            button5.TabIndex = 7;
            button5.Text = "Change label3 Color";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.DimGray;
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic);
            button6.ForeColor = Color.MediumSpringGreen;
            button6.Location = new Point(0, 273);
            button6.Name = "button6";
            button6.Size = new Size(194, 43);
            button6.TabIndex = 8;
            button6.Text = "Change label3 Font";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
    }
}
