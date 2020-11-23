namespace Fundamentos
{
    partial class Form04CambiarForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtposicionx = new System.Windows.Forms.TextBox();
            this.txtposiciony = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtazul = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrojo = new System.Windows.Forms.TextBox();
            this.txtverde = new System.Windows.Forms.TextBox();
            this.btnposicion = new System.Windows.Forms.Button();
            this.btncolor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posicion X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posicion Y";
            // 
            // txtposicionx
            // 
            this.txtposicionx.Location = new System.Drawing.Point(153, 64);
            this.txtposicionx.Name = "txtposicionx";
            this.txtposicionx.Size = new System.Drawing.Size(100, 22);
            this.txtposicionx.TabIndex = 2;
            // 
            // txtposiciony
            // 
            this.txtposiciony.Location = new System.Drawing.Point(153, 107);
            this.txtposiciony.Name = "txtposiciony";
            this.txtposiciony.Size = new System.Drawing.Size(100, 22);
            this.txtposiciony.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(362, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Azul";
            // 
            // txtazul
            // 
            this.txtazul.Location = new System.Drawing.Point(423, 158);
            this.txtazul.Name = "txtazul";
            this.txtazul.Size = new System.Drawing.Size(100, 22);
            this.txtazul.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rojo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Verde";
            // 
            // txtrojo
            // 
            this.txtrojo.Location = new System.Drawing.Point(423, 59);
            this.txtrojo.Name = "txtrojo";
            this.txtrojo.Size = new System.Drawing.Size(100, 22);
            this.txtrojo.TabIndex = 8;
            // 
            // txtverde
            // 
            this.txtverde.Location = new System.Drawing.Point(423, 106);
            this.txtverde.Name = "txtverde";
            this.txtverde.Size = new System.Drawing.Size(100, 22);
            this.txtverde.TabIndex = 9;
            // 
            // btnposicion
            // 
            this.btnposicion.Location = new System.Drawing.Point(93, 161);
            this.btnposicion.Name = "btnposicion";
            this.btnposicion.Size = new System.Drawing.Size(75, 23);
            this.btnposicion.TabIndex = 10;
            this.btnposicion.Text = "Posicion";
            this.btnposicion.UseVisualStyleBackColor = true;
            this.btnposicion.Click += new System.EventHandler(this.btnposicion_Click);
            // 
            // btncolor
            // 
            this.btncolor.Location = new System.Drawing.Point(368, 212);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(75, 23);
            this.btncolor.TabIndex = 11;
            this.btncolor.Text = "Color";
            this.btncolor.UseVisualStyleBackColor = true;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Info...";
            // 
            // Form04CambiarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 288);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.btnposicion);
            this.Controls.Add(this.txtverde);
            this.Controls.Add(this.txtrojo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtazul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtposiciony);
            this.Controls.Add(this.txtposicionx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form04CambiarForm";
            this.Text = "Form04CambiarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtposicionx;
        private System.Windows.Forms.TextBox txtposiciony;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtazul;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtrojo;
        private System.Windows.Forms.TextBox txtverde;
        private System.Windows.Forms.Button btnposicion;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Label label6;
    }
}