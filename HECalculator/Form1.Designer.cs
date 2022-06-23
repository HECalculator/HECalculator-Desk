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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelResults = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panelInputs = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.panelResults.SuspendLayout();
            this.panelInputs.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // doMagic
            // 
            this.doMagic.Location = new System.Drawing.Point(4, 4);
            this.doMagic.Name = "doMagic";
            this.doMagic.Size = new System.Drawing.Size(200, 23);
            this.doMagic.TabIndex = 0;
            this.doMagic.Text = "DoMagic";
            this.doMagic.UseVisualStyleBackColor = true;
            this.doMagic.Click += new System.EventHandler(this.doMagic_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "100";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(198, 114);
            this.textBox2.TabIndex = 2;
            this.textBox2.WordWrap = false;
            // 
            // panelLeft
            // 
            this.panelLeft.AutoSize = true;
            this.panelLeft.Controls.Add(this.panelResults);
            this.panelLeft.Controls.Add(this.splitter2);
            this.panelLeft.Controls.Add(this.panelInputs);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLeft.Location = new System.Drawing.Point(3, 3);
            this.panelLeft.MinimumSize = new System.Drawing.Size(300, 455);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(300, 455);
            this.panelLeft.TabIndex = 3;
            // 
            // panelResults
            // 
            this.panelResults.AutoSize = true;
            this.panelResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelResults.Controls.Add(this.textBox2);
            this.panelResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResults.Location = new System.Drawing.Point(0, 223);
            this.panelResults.MinimumSize = new System.Drawing.Size(300, 232);
            this.panelResults.Name = "panelResults";
            this.panelResults.Size = new System.Drawing.Size(300, 232);
            this.panelResults.TabIndex = 8;
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(0, 220);
            this.splitter2.MinExtra = 232;
            this.splitter2.MinSize = 220;
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(300, 3);
            this.splitter2.TabIndex = 7;
            this.splitter2.TabStop = false;
            // 
            // panelInputs
            // 
            this.panelInputs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInputs.Controls.Add(this.textBox1);
            this.panelInputs.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInputs.Location = new System.Drawing.Point(0, 0);
            this.panelInputs.MinimumSize = new System.Drawing.Size(300, 220);
            this.panelInputs.Name = "panelInputs";
            this.panelInputs.Size = new System.Drawing.Size(300, 220);
            this.panelInputs.TabIndex = 6;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(300, 3);
            this.splitter1.MinExtra = 300;
            this.splitter1.MinSize = 300;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 455);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelSummary);
            this.panelRight.Controls.Add(this.splitter3);
            this.panelRight.Controls.Add(this.panelImage);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(303, 3);
            this.panelRight.MinimumSize = new System.Drawing.Size(300, 455);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(300, 455);
            this.panelRight.TabIndex = 5;
            // 
            // panelSummary
            // 
            this.panelSummary.AutoSize = true;
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSummary.Controls.Add(this.doMagic);
            this.panelSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSummary.Location = new System.Drawing.Point(0, 363);
            this.panelSummary.MinimumSize = new System.Drawing.Size(300, 92);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(300, 92);
            this.panelSummary.TabIndex = 9;
            // 
            // splitter3
            // 
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter3.Location = new System.Drawing.Point(0, 360);
            this.splitter3.MinExtra = 92;
            this.splitter3.MinSize = 360;
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(300, 3);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // panelImage
            // 
            this.panelImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.MinimumSize = new System.Drawing.Size(300, 360);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(300, 360);
            this.panelImage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(606, 461);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "HECalculator";
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelResults.ResumeLayout(false);
            this.panelResults.PerformLayout();
            this.panelInputs.ResumeLayout(false);
            this.panelInputs.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doMagic;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelResults;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panelInputs;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panelImage;
    }
}

