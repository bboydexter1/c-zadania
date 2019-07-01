namespace lab2
{
    partial class window1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dirInput = new System.Windows.Forms.TextBox();
            this.stopBtn = new System.Windows.Forms.Button();
            this.dirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(127, 151);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(114, 53);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "start server";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "port : ";
            // 
            // portInput
            // 
            this.portInput.Location = new System.Drawing.Point(127, 47);
            this.portInput.Name = "portInput";
            this.portInput.Size = new System.Drawing.Size(385, 22);
            this.portInput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "directory : ";
            // 
            // dirInput
            // 
            this.dirInput.Location = new System.Drawing.Point(127, 86);
            this.dirInput.Name = "dirInput";
            this.dirInput.Size = new System.Drawing.Size(346, 22);
            this.dirInput.TabIndex = 5;
            // 
            // stopBtn
            // 
            this.stopBtn.Location = new System.Drawing.Point(398, 151);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(114, 53);
            this.stopBtn.TabIndex = 6;
            this.stopBtn.Text = "stop server";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // dirBtn
            // 
            this.dirBtn.Location = new System.Drawing.Point(470, 83);
            this.dirBtn.Name = "dirBtn";
            this.dirBtn.Size = new System.Drawing.Size(42, 31);
            this.dirBtn.TabIndex = 7;
            this.dirBtn.Text = "...";
            this.dirBtn.UseVisualStyleBackColor = true;
            this.dirBtn.Click += new System.EventHandler(this.dirBtn_Click);
            // 
            // window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 249);
            this.Controls.Add(this.dirBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.dirInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBtn);
            this.Name = "window1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox portInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dirInput;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button dirBtn;
    }
}

