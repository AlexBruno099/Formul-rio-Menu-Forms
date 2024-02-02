namespace Formulario
{
    partial class FormSegunda
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
            this.lblSegunda = new System.Windows.Forms.Label();
            this.btnPrimeiraFormThread = new System.Windows.Forms.Button();
            this.txtboxMensagem = new System.Windows.Forms.TextBox();
            this.btnRetorno = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSegunda
            // 
            this.lblSegunda.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegunda.Location = new System.Drawing.Point(5, 89);
            this.lblSegunda.Name = "lblSegunda";
            this.lblSegunda.Size = new System.Drawing.Size(797, 184);
            this.lblSegunda.TabIndex = 0;
            this.lblSegunda.Text = "Segunda Form";
            this.lblSegunda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrimeiraFormThread
            // 
            this.btnPrimeiraFormThread.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPrimeiraFormThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiraFormThread.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPrimeiraFormThread.Location = new System.Drawing.Point(12, 16);
            this.btnPrimeiraFormThread.Name = "btnPrimeiraFormThread";
            this.btnPrimeiraFormThread.Size = new System.Drawing.Size(173, 58);
            this.btnPrimeiraFormThread.TabIndex = 3;
            this.btnPrimeiraFormThread.Text = "Primeira Form Thread";
            this.btnPrimeiraFormThread.UseVisualStyleBackColor = false;
            this.btnPrimeiraFormThread.Click += new System.EventHandler(this.btnPrimeiraFormThread_Click);
            // 
            // txtboxMensagem
            // 
            this.txtboxMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMensagem.Location = new System.Drawing.Point(126, 276);
            this.txtboxMensagem.Multiline = true;
            this.txtboxMensagem.Name = "txtboxMensagem";
            this.txtboxMensagem.Size = new System.Drawing.Size(570, 44);
            this.txtboxMensagem.TabIndex = 4;
            // 
            // btnRetorno
            // 
            this.btnRetorno.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRetorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorno.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRetorno.Location = new System.Drawing.Point(191, 16);
            this.btnRetorno.Name = "btnRetorno";
            this.btnRetorno.Size = new System.Drawing.Size(173, 58);
            this.btnRetorno.TabIndex = 5;
            this.btnRetorno.Text = "Retorno";
            this.btnRetorno.UseVisualStyleBackColor = false;
            this.btnRetorno.Click += new System.EventHandler(this.btnRetorno_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFechar.Location = new System.Drawing.Point(699, 401);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(89, 46);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // FormSegunda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnRetorno);
            this.Controls.Add(this.txtboxMensagem);
            this.Controls.Add(this.btnPrimeiraFormThread);
            this.Controls.Add(this.lblSegunda);
            this.Name = "FormSegunda";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormSegunda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSegunda;
        private System.Windows.Forms.Button btnPrimeiraFormThread;
        private System.Windows.Forms.TextBox txtboxMensagem;
        private System.Windows.Forms.Button btnRetorno;
        private System.Windows.Forms.Button btnFechar;
    }
}