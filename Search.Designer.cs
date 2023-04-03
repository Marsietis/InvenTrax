using System.ComponentModel;

namespace InvenTrax1
{
    partial class Search
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 145);
            this.textBox1.MaxLength = 20;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 38);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(389, 145);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 38);
            this.textBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(708, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 81);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Window;
            this.button2.Location = new System.Drawing.Point(933, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 81);
            this.button2.TabIndex = 4;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(61, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 70);
            this.label1.TabIndex = 4;
            this.label1.Text = "By name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(389, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 70);
            this.label2.TabIndex = 5;
            this.label2.Text = "By ID:";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 31;
            this.listBox1.Location = new System.Drawing.Point(61, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1779, 624);
            this.listBox1.TabIndex = 0;
            // 
            // Search
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Search";
            this.Text = "Search";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;

        #endregion
    }
}