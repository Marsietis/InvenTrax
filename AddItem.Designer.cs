using System.ComponentModel;

namespace InvenTrax1
{
    partial class AddItem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 185);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 38);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 323);
            this.textBox2.MaxLength = 20;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(374, 38);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 458);
            this.textBox3.MaxLength = 10;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(281, 38);
            this.textBox3.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(602, 185);
            this.richTextBox1.MaxLength = 200;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(739, 176);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(105, 696);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 86);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(46, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 63);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add a new item:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(105, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 54);
            this.label2.TabIndex = 6;
            this.label2.Text = "Item name:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(105, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Item ID:";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(105, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 54);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item price:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(392, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Eur";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(611, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(489, 45);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item properties:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(300, 696);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 86);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 583);
            this.textBox4.MaxLength = 10;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(281, 38);
            this.textBox4.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(105, 526);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(281, 54);
            this.label7.TabIndex = 13;
            this.label7.Text = "Quantity:";
            // 
            // AddItem
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1452, 870);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AddItem";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox3;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;

        #endregion
    }
}