namespace light_onoff_demo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.onBtn = new System.Windows.Forms.Label();
            this.offBtn = new System.Windows.Forms.Label();
            this.lightBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::light_onoff_demo.Properties.Resources.LightOn_1;
            this.pictureBox1.Location = new System.Drawing.Point(100, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::light_onoff_demo.Properties.Resources.LightOff;
            this.pictureBox2.Location = new System.Drawing.Point(100, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(110, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // onBtn
            // 
            this.onBtn.AutoSize = true;
            this.onBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onBtn.Location = new System.Drawing.Point(136, 236);
            this.onBtn.Name = "onBtn";
            this.onBtn.Size = new System.Drawing.Size(30, 16);
            this.onBtn.TabIndex = 2;
            this.onBtn.Text = "ON";
            this.onBtn.Visible = false;
            // 
            // offBtn
            // 
            this.offBtn.AutoSize = true;
            this.offBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offBtn.Location = new System.Drawing.Point(136, 236);
            this.offBtn.Name = "offBtn";
            this.offBtn.Size = new System.Drawing.Size(37, 16);
            this.offBtn.TabIndex = 3;
            this.offBtn.Text = "OFF";
            // 
            // lightBtn
            // 
            this.lightBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lightBtn.Location = new System.Drawing.Point(47, 293);
            this.lightBtn.Name = "lightBtn";
            this.lightBtn.Size = new System.Drawing.Size(85, 23);
            this.lightBtn.TabIndex = 4;
            this.lightBtn.Text = "Switch Light";
            this.lightBtn.UseVisualStyleBackColor = true;
            this.lightBtn.Click += new System.EventHandler(this.lightBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(196, 293);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 337);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lightBtn);
            this.Controls.Add(this.offBtn);
            this.Controls.Add(this.onBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label onBtn;
        private System.Windows.Forms.Label offBtn;
        private System.Windows.Forms.Button lightBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

