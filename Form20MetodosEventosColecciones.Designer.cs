﻿namespace Fundamentos
{
    partial class Form20MetodosEventosColecciones
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkAsociarMetodos = new System.Windows.Forms.CheckBox();
            this.lblnumeventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(71, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(71, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // chkAsociarMetodos
            // 
            this.chkAsociarMetodos.AutoSize = true;
            this.chkAsociarMetodos.Location = new System.Drawing.Point(71, 31);
            this.chkAsociarMetodos.Name = "chkAsociarMetodos";
            this.chkAsociarMetodos.Size = new System.Drawing.Size(135, 21);
            this.chkAsociarMetodos.TabIndex = 3;
            this.chkAsociarMetodos.Text = "AsociarMetodos ";
            this.chkAsociarMetodos.UseVisualStyleBackColor = true;
            this.chkAsociarMetodos.CheckedChanged += new System.EventHandler(this.chkAsociarMetodos_CheckedChanged);
            // 
            // lblnumeventos
            // 
            this.lblnumeventos.AutoSize = true;
            this.lblnumeventos.Location = new System.Drawing.Point(386, 31);
            this.lblnumeventos.Name = "lblnumeventos";
            this.lblnumeventos.Size = new System.Drawing.Size(106, 17);
            this.lblnumeventos.TabIndex = 4;
            this.lblnumeventos.Text = "numeroeventos";
            // 
            // Form20MetodosEventosColecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 350);
            this.Controls.Add(this.lblnumeventos);
            this.Controls.Add(this.chkAsociarMetodos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form20MetodosEventosColecciones";
            this.Text = "Form20MetodosEventosColecciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox chkAsociarMetodos;
        private System.Windows.Forms.Label lblnumeventos;
    }
}