using System.Windows.Forms;

namespace lab4
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lineBtn = new System.Windows.Forms.Button();
            this.recBtn = new System.Windows.Forms.Button();
            this.freeDrawBtn = new System.Windows.Forms.Button();
            this.greenBtn = new System.Windows.Forms.Button();
            this.blueBtn = new System.Windows.Forms.Button();
            this.redBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(86, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 456);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // lineBtn
            // 
            this.lineBtn.Location = new System.Drawing.Point(12, 22);
            this.lineBtn.Name = "lineBtn";
            this.lineBtn.Size = new System.Drawing.Size(75, 23);
            this.lineBtn.TabIndex = 1;
            this.lineBtn.Text = "line";
            this.lineBtn.UseVisualStyleBackColor = true;
            this.lineBtn.Click += new System.EventHandler(this.lineBtn_Click);
            // 
            // recBtn
            // 
            this.recBtn.Location = new System.Drawing.Point(12, 70);
            this.recBtn.Name = "recBtn";
            this.recBtn.Size = new System.Drawing.Size(75, 23);
            this.recBtn.TabIndex = 2;
            this.recBtn.Text = "rectangle";
            this.recBtn.UseVisualStyleBackColor = true;
            this.recBtn.Click += new System.EventHandler(this.recBtn_Click);
            // 
            // freeDrawBtn
            // 
            this.freeDrawBtn.Location = new System.Drawing.Point(12, 122);
            this.freeDrawBtn.Name = "freeDrawBtn";
            this.freeDrawBtn.Size = new System.Drawing.Size(75, 23);
            this.freeDrawBtn.TabIndex = 3;
            this.freeDrawBtn.Text = "free draw";
            this.freeDrawBtn.UseVisualStyleBackColor = true;
            this.freeDrawBtn.Click += new System.EventHandler(this.freeDrawBtn_Click);
            // 
            // greenBtn
            // 
            this.greenBtn.Location = new System.Drawing.Point(692, 122);
            this.greenBtn.Name = "greenBtn";
            this.greenBtn.Size = new System.Drawing.Size(75, 23);
            this.greenBtn.TabIndex = 6;
            this.greenBtn.Text = "green";
            this.greenBtn.UseVisualStyleBackColor = true;
            this.greenBtn.Click += new System.EventHandler(this.greenBtn_Click);
            // 
            // blueBtn
            // 
            this.blueBtn.Location = new System.Drawing.Point(692, 70);
            this.blueBtn.Name = "blueBtn";
            this.blueBtn.Size = new System.Drawing.Size(75, 23);
            this.blueBtn.TabIndex = 5;
            this.blueBtn.Text = "blue";
            this.blueBtn.UseVisualStyleBackColor = true;
            this.blueBtn.Click += new System.EventHandler(this.blueBtn_Click);
            // 
            // redBtn
            // 
            this.redBtn.Location = new System.Drawing.Point(692, 22);
            this.redBtn.Name = "redBtn";
            this.redBtn.Size = new System.Drawing.Size(75, 23);
            this.redBtn.TabIndex = 4;
            this.redBtn.Text = "red";
            this.redBtn.UseVisualStyleBackColor = true;
            this.redBtn.Click += new System.EventHandler(this.redBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.greenBtn);
            this.Controls.Add(this.blueBtn);
            this.Controls.Add(this.redBtn);
            this.Controls.Add(this.freeDrawBtn);
            this.Controls.Add(this.recBtn);
            this.Controls.Add(this.lineBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lineBtn;
        private System.Windows.Forms.Button recBtn;
        private System.Windows.Forms.Button freeDrawBtn;
        private System.Windows.Forms.Button greenBtn;
        private System.Windows.Forms.Button blueBtn;
        private System.Windows.Forms.Button redBtn;
    }
}

