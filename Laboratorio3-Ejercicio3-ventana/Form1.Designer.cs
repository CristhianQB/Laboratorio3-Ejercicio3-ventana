namespace Laboratorio3_Ejercicio3_ventana
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtb1 = new System.Windows.Forms.TextBox();
            txtb2 = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            txtb3 = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            lbl = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 42);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(168, 15);
            label1.TabIndex = 0;
            label1.Text = "¿Eres mayor o menor de edad?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(233, 42);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Mayor (0)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(314, 42);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Menor (1)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(84, 170);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(123, 15);
            label4.TabIndex = 3;
            label4.Text = "¿Cuántos años tienes?";
            // 
            // txtb1
            // 
            txtb1.Location = new System.Drawing.Point(282, 76);
            txtb1.Name = "txtb1";
            txtb1.Size = new System.Drawing.Size(41, 23);
            txtb1.TabIndex = 4;
            // 
            // txtb2
            // 
            txtb2.Location = new System.Drawing.Point(110, 200);
            txtb2.Name = "txtb2";
            txtb2.Size = new System.Drawing.Size(53, 23);
            txtb2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(272, 170);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(145, 15);
            label5.TabIndex = 6;
            label5.Text = "N. de adivinazas acertadas";
            // 
            // txtb3
            // 
            txtb3.Location = new System.Drawing.Point(297, 200);
            txtb3.Name = "txtb3";
            txtb3.Size = new System.Drawing.Size(57, 23);
            txtb3.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(166, 311);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(63, 28);
            label6.TabIndex = 8;
            label6.Text = "Total :";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl.Location = new System.Drawing.Point(249, 304);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(62, 37);
            lbl.TabIndex = 9;
            lbl.Text = "000";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(208, 361);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(61, 35);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(517, 450);
            Controls.Add(button1);
            Controls.Add(lbl);
            Controls.Add(label6);
            Controls.Add(txtb3);
            Controls.Add(label5);
            Controls.Add(txtb2);
            Controls.Add(txtb1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtb3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button button1;
    }
}
