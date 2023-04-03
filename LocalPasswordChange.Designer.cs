using System.ComponentModel;

namespace InvenTrax1
{
    partial class LocalPasswordChange
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(79, 489);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(79, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(407, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter your new password:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(79, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(407, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirm your new password:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 403);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(407, 38);
            this.textBox2.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(294, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 257);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.Size = new System.Drawing.Size(407, 38);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 110);
            this.textBox3.MaxLength = 20;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(407, 38);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(79, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(407, 61);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter your current username:";
            // 
            // LocalPasswordChange
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1352, 856);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Name = "LocalPasswordChange";
            this.Text = "Change password";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;

        #endregion
    }
}