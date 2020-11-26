namespace Fundamentos
{
    partial class Form18MetodosEvento
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
            this.txtnumeros = new System.Windows.Forms.TextBox();
            this.txtletras = new System.Windows.Forms.TextBox();
            this.lblraton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solo números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solo letras";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(115, 34);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(100, 20);
            this.txtnumeros.TabIndex = 2;
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(115, 89);
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(100, 20);
            this.txtletras.TabIndex = 3;
            // 
            // lblraton
            // 
            this.lblraton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblraton.Location = new System.Drawing.Point(30, 142);
            this.lblraton.Name = "lblraton";
            this.lblraton.Size = new System.Drawing.Size(105, 35);
            this.lblraton.TabIndex = 4;
            this.lblraton.Text = "lblraton";
            // 
            // Form18MetodosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 222);
            this.Controls.Add(this.lblraton);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form18MetodosEvento";
            this.Text = "Form18MetodosEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnumeros;
        private System.Windows.Forms.TextBox txtletras;
        private System.Windows.Forms.Label lblraton;
    }
}