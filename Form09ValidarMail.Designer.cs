namespace Fundamentos
{
    partial class Form09ValidarMail
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
            this.btnValidar = new System.Windows.Forms.Button();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(126, 83);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(138, 23);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Comprobar Mail ";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(110, 40);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(170, 22);
            this.txtemail.TabIndex = 2;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Location = new System.Drawing.Point(318, 43);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(75, 17);
            this.lblmensaje.TabIndex = 3;
            this.lblmensaje.Text = "lblmensaje";
            // 
            // Form09ValidarMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 216);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.label1);
            this.Name = "Form09ValidarMail";
            this.Text = "Form09ValidarMail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label lblmensaje;
    }
}