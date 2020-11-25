namespace Fundamentos
{
    partial class Form12StringBuilder
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
            this.txtTexto = new System.Windows.Forms.RichTextBox();
            this.lbltiempo = new System.Windows.Forms.Label();
            this.btnreversestring = new System.Windows.Forms.Button();
            this.btnrevstrbuilder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Texto";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(30, 63);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(480, 317);
            this.txtTexto.TabIndex = 1;
            this.txtTexto.Text = "";
            // 
            // lbltiempo
            // 
            this.lbltiempo.AutoSize = true;
            this.lbltiempo.Location = new System.Drawing.Point(30, 412);
            this.lbltiempo.Name = "lbltiempo";
            this.lbltiempo.Size = new System.Drawing.Size(64, 17);
            this.lbltiempo.TabIndex = 2;
            this.lbltiempo.Text = "lbltiempo";
            // 
            // btnreversestring
            // 
            this.btnreversestring.Location = new System.Drawing.Point(532, 189);
            this.btnreversestring.Name = "btnreversestring";
            this.btnreversestring.Size = new System.Drawing.Size(224, 49);
            this.btnreversestring.TabIndex = 3;
            this.btnreversestring.Text = "Reverse String";
            this.btnreversestring.UseVisualStyleBackColor = true;
            this.btnreversestring.Click += new System.EventHandler(this.btnreversestring_Click);
            // 
            // btnrevstrbuilder
            // 
            this.btnrevstrbuilder.Location = new System.Drawing.Point(532, 98);
            this.btnrevstrbuilder.Name = "btnrevstrbuilder";
            this.btnrevstrbuilder.Size = new System.Drawing.Size(209, 57);
            this.btnrevstrbuilder.TabIndex = 4;
            this.btnrevstrbuilder.Text = "Reverse StringBuilder";
            this.btnrevstrbuilder.UseVisualStyleBackColor = true;
            this.btnrevstrbuilder.Click += new System.EventHandler(this.btnrevstrbuilder_Click);
            // 
            // Form12StringBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 461);
            this.Controls.Add(this.btnrevstrbuilder);
            this.Controls.Add(this.btnreversestring);
            this.Controls.Add(this.lbltiempo);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label1);
            this.Name = "Form12StringBuilder";
            this.Text = "Form12StringBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtTexto;
        private System.Windows.Forms.Label lbltiempo;
        private System.Windows.Forms.Button btnreversestring;
        private System.Windows.Forms.Button btnrevstrbuilder;
    }
}