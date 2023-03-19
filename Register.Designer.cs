using System.ComponentModel;

namespace InvenTrax1
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(96, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Register a new local admin";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(96, 247);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(341, 35);
            this.Password.TabIndex = 12;
            this.Password.Text = "Password";
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(96, 154);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(432, 35);
            this.Username.TabIndex = 11;
            this.Username.Text = "Username";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(96, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(397, 38);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 38);
            this.textBox1.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(96, 379);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(397, 38);
            this.textBox3.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 340);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "Location name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(96, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 67);
            this.button1.TabIndex = 17;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(302, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 67);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 930);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}