namespace Serial_Communication
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
            this.BtnLiga = new System.Windows.Forms.Button();
            this.BtnDesliga = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnLiga
            // 
            this.BtnLiga.Location = new System.Drawing.Point(42, 68);
            this.BtnLiga.Name = "BtnLiga";
            this.BtnLiga.Size = new System.Drawing.Size(148, 84);
            this.BtnLiga.TabIndex = 0;
            this.BtnLiga.Text = "Liga";
            this.BtnLiga.UseVisualStyleBackColor = true;
            this.BtnLiga.Click += new System.EventHandler(this.BtnLiga_Click);
            // 
            // BtnDesliga
            // 
            this.BtnDesliga.Location = new System.Drawing.Point(42, 251);
            this.BtnDesliga.Name = "BtnDesliga";
            this.BtnDesliga.Size = new System.Drawing.Size(148, 84);
            this.BtnDesliga.TabIndex = 1;
            this.BtnDesliga.Text = "Desliga";
            this.BtnDesliga.UseVisualStyleBackColor = true;
            this.BtnDesliga.Click += new System.EventHandler(this.BtnDesliga_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(473, 278);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Receive Message";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDesliga);
            this.Controls.Add(this.BtnLiga);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Serial Communication";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLiga;
        private System.Windows.Forms.Button BtnDesliga;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

