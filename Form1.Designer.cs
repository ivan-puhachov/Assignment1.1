namespace Assignment1
{
    partial class Colors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colors));
            button1 = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ExitButton = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button3 = new Button();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(377, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Press!";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 318);
            label2.Name = "label2";
            label2.Size = new Size(16, 15);
            label2.TabIndex = 1;
            label2.Text = "...";
            label2.Visible = false;
            label2.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(299, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(224, 222);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(713, 388);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 3;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(88, 360);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "Press!";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Blue;
            pictureBox1.Location = new Point(23, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 222);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 318);
            label1.Name = "label1";
            label1.Size = new Size(16, 15);
            label1.TabIndex = 6;
            label1.Text = "...";
            label1.Visible = false;
            // 
            // button3
            // 
            button3.Location = new Point(657, 359);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Press!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(682, 316);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 8;
            label3.Text = "...";
            label3.Visible = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.A_black_image;
            pictureBox3.Location = new Point(573, 62);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(224, 222);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            pictureBox3.Visible = false;
            // 
            // Colors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(ExitButton);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Name = "Colors";
            Text = "Colors";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private PictureBox pictureBox2;
        private Button ExitButton;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button3;
        private Label label3;
        private PictureBox pictureBox3;
    }
}
