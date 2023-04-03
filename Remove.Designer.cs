using System.ComponentModel;

namespace InvenTrax1
{
    partial class Remove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(37, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 147);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(344, 38);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(828, 83);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter the Username of a login to remove:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(219, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 58);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Remove
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(977, 633);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Remove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}