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
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solo números";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solo letras";
            // 
            // txtnumeros
            // 
            this.txtnumeros.Location = new System.Drawing.Point(153, 42);
            this.txtnumeros.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumeros.Name = "txtnumeros";
            this.txtnumeros.Size = new System.Drawing.Size(132, 22);
            this.txtnumeros.TabIndex = 2;
            this.txtnumeros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnumeros_KeyPress);
            // 
            // txtletras
            // 
            this.txtletras.Location = new System.Drawing.Point(153, 110);
            this.txtletras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtletras.Name = "txtletras";
            this.txtletras.Size = new System.Drawing.Size(132, 22);
            this.txtletras.TabIndex = 3;
            this.txtletras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtletras_KeyPress);
            // 
            // lblraton
            // 
            this.lblraton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblraton.Location = new System.Drawing.Point(40, 175);
            this.lblraton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblraton.Name = "lblraton";
            this.lblraton.Size = new System.Drawing.Size(140, 43);
            this.lblraton.TabIndex = 4;
            this.lblraton.Text = "lblraton";
            this.lblraton.MouseHover += new System.EventHandler(this.lblraton_MouseHover);
            this.lblraton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblraton_MouseMove);
            // 
            // Form18MetodosEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 273);
            this.Controls.Add(this.lblraton);
            this.Controls.Add(this.txtletras);
            this.Controls.Add(this.txtnumeros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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