using System.ComponentModel;

namespace InvenTrax1
{
    partial class InvenTraxUser
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
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1728, 109);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(54, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(313, 108);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sign out";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.Window;
            this.button5.Location = new System.Drawing.Point(940, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(377, 225);
            this.button5.TabIndex = 3;
            this.button5.Text = "Change items quantity";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Window;
            this.button4.Location = new System.Drawing.Point(501, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(377, 225);
            this.button4.TabIndex = 2;
            this.button4.Text = "Item search";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Window;
            this.button3.Location = new System.Drawing.Point(54, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(377, 225);
            this.button3.TabIndex = 1;
            this.button3.Text = "Show all items";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // InvenTraxUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1888, 992);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "InvenTraxUser";
            this.Text = "InvenTraxUser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InvenTraxUser_FormClosed);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

        #endregion
    }
}