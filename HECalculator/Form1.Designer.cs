namespace HECalculator
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
            this.doMagic = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // doMagic
            // 
            this.doMagic.Location = new System.Drawing.Point(70, 83);
            this.doMagic.Name = "doMagic";
            this.doMagic.Size = new System.Drawing.Size(200, 23);
            this.doMagic.TabIndex = 0;
            this.doMagic.Text = "DoMagic";
            this.doMagic.UseVisualStyleBackColor = true;
            this.doMagic.Click += new System.EventHandler(this.doMagic_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "100";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 156);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 114);
            this.textBox2.TabIndex = 2;
            this.textBox2.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.doMagic);
            this.Name = "Form1";
            this.Text = "HECalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doMagic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

