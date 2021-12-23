namespace DevTools
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new Dalk.GUI.Button();
            this.button3 = new Dalk.GUI.Button();
            this.button2 = new Dalk.GUI.Button();
            this.button1 = new Dalk.GUI.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(775, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(13, 78);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(775, 360);
            this.textBox2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))));
            this.button4.BorderRadius = 15;
            this.button4.ButtonText = "Int";
            this.button4.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(118)))));
            this.button4.Image = null;
            this.button4.ImageHeight = 20;
            this.button4.ImageMargin = 8;
            this.button4.ImageWidth = 20;
            this.button4.Location = new System.Drawing.Point(258, 14);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.State = Dalk.GUI.ControlState.Default;
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.TextColor = System.Drawing.Color.White;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))));
            this.button3.BorderRadius = 15;
            this.button3.ButtonText = "String";
            this.button3.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(118)))));
            this.button3.Image = null;
            this.button3.ImageHeight = 20;
            this.button3.ImageMargin = 8;
            this.button3.ImageWidth = 20;
            this.button3.Location = new System.Drawing.Point(176, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.State = Dalk.GUI.ControlState.Default;
            this.button3.TabIndex = 4;
            this.button3.Text = "button3";
            this.button3.TextColor = System.Drawing.Color.White;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))));
            this.button2.BorderRadius = 15;
            this.button2.ButtonText = "Image";
            this.button2.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(118)))));
            this.button2.Image = null;
            this.button2.ImageHeight = 20;
            this.button2.ImageMargin = 8;
            this.button2.ImageWidth = 20;
            this.button2.Location = new System.Drawing.Point(95, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.State = Dalk.GUI.ControlState.Default;
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.TextColor = System.Drawing.Color.White;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(154)))), ((int)(((byte)(67)))));
            this.button1.BorderRadius = 15;
            this.button1.ButtonText = "Color";
            this.button1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(171)))), ((int)(((byte)(118)))));
            this.button1.Image = null;
            this.button1.ImageHeight = 20;
            this.button1.ImageMargin = 8;
            this.button1.ImageWidth = 20;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.State = Dalk.GUI.ControlState.Default;
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.TextColor = System.Drawing.Color.White;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dalk.GUI.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Dalk.GUI.Button button2;
        private Dalk.GUI.Button button3;
        private Dalk.GUI.Button button4;
    }
}

