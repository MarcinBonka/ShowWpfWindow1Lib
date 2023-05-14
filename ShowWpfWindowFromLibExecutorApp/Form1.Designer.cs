namespace ShowWpfWindowFromLibExecutorApp
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
            this.btnShowWindow = new System.Windows.Forms.Button();
            this.btnShowPict1 = new System.Windows.Forms.Button();
            this.btnShowPict2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnShowWindow
            // 
            this.btnShowWindow.Location = new System.Drawing.Point(26, 31);
            this.btnShowWindow.Name = "btnShowWindow";
            this.btnShowWindow.Size = new System.Drawing.Size(118, 23);
            this.btnShowWindow.TabIndex = 0;
            this.btnShowWindow.Text = "Show wpf window";
            this.btnShowWindow.UseVisualStyleBackColor = true;
            this.btnShowWindow.Click += new System.EventHandler(this.btnShowWindow_Click);
            // 
            // btnShowPict1
            // 
            this.btnShowPict1.Location = new System.Drawing.Point(26, 76);
            this.btnShowPict1.Name = "btnShowPict1";
            this.btnShowPict1.Size = new System.Drawing.Size(118, 23);
            this.btnShowPict1.TabIndex = 1;
            this.btnShowPict1.Text = "Show Picture 1";
            this.btnShowPict1.UseVisualStyleBackColor = true;
            this.btnShowPict1.Click += new System.EventHandler(this.btnShowPict1_Click);
            // 
            // btnShowPict2
            // 
            this.btnShowPict2.Location = new System.Drawing.Point(26, 105);
            this.btnShowPict2.Name = "btnShowPict2";
            this.btnShowPict2.Size = new System.Drawing.Size(118, 23);
            this.btnShowPict2.TabIndex = 1;
            this.btnShowPict2.Text = "Show Picture 2";
            this.btnShowPict2.UseVisualStyleBackColor = true;
            this.btnShowPict2.Click += new System.EventHandler(this.btnShowPict2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowPict2);
            this.Controls.Add(this.btnShowPict1);
            this.Controls.Add(this.btnShowWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowWindow;
        private System.Windows.Forms.Button btnShowPict1;
        private System.Windows.Forms.Button btnShowPict2;
    }
}

