namespace Chatbot.vistas
{
    partial class VistaChatbot
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
            this.cajaTextoGrande = new System.Windows.Forms.RichTextBox();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.botonVolver = new System.Windows.Forms.Button();
            this.botonCargarLog = new System.Windows.Forms.Button();
            this.botonGuardarLog = new System.Windows.Forms.Button();
            this.botonEndDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaTextoGrande
            // 
            this.cajaTextoGrande.Location = new System.Drawing.Point(57, 29);
            this.cajaTextoGrande.Name = "cajaTextoGrande";
            this.cajaTextoGrande.ReadOnly = true;
            this.cajaTextoGrande.Size = new System.Drawing.Size(726, 259);
            this.cajaTextoGrande.TabIndex = 5;
            this.cajaTextoGrande.Text = "";
            // 
            // inputUsuario
            // 
            this.inputUsuario.Location = new System.Drawing.Point(57, 308);
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(629, 20);
            this.inputUsuario.TabIndex = 6;
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(708, 305);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(75, 23);
            this.botonEnviar.TabIndex = 7;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.botonEnviar_Click);
            // 
            // botonVolver
            // 
            this.botonVolver.Location = new System.Drawing.Point(708, 408);
            this.botonVolver.Name = "botonVolver";
            this.botonVolver.Size = new System.Drawing.Size(75, 23);
            this.botonVolver.TabIndex = 8;
            this.botonVolver.Text = "Volver";
            this.botonVolver.UseVisualStyleBackColor = true;
            this.botonVolver.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // botonCargarLog
            // 
            this.botonCargarLog.Location = new System.Drawing.Point(28, 408);
            this.botonCargarLog.Name = "botonCargarLog";
            this.botonCargarLog.Size = new System.Drawing.Size(87, 23);
            this.botonCargarLog.TabIndex = 9;
            this.botonCargarLog.Text = "Cargar Log";
            this.botonCargarLog.UseVisualStyleBackColor = true;
            this.botonCargarLog.Click += new System.EventHandler(this.botonCargarLog_Click);
            // 
            // botonGuardarLog
            // 
            this.botonGuardarLog.Location = new System.Drawing.Point(28, 361);
            this.botonGuardarLog.Name = "botonGuardarLog";
            this.botonGuardarLog.Size = new System.Drawing.Size(87, 23);
            this.botonGuardarLog.TabIndex = 10;
            this.botonGuardarLog.Text = "Guardar Log";
            this.botonGuardarLog.UseVisualStyleBackColor = true;
            this.botonGuardarLog.Click += new System.EventHandler(this.botonGuardarLog_Click);
            // 
            // botonEndDialog
            // 
            this.botonEndDialog.Location = new System.Drawing.Point(681, 361);
            this.botonEndDialog.Name = "botonEndDialog";
            this.botonEndDialog.Size = new System.Drawing.Size(130, 23);
            this.botonEndDialog.TabIndex = 11;
            this.botonEndDialog.Text = "Finalizar Conversación";
            this.botonEndDialog.UseVisualStyleBackColor = true;
            this.botonEndDialog.Click += new System.EventHandler(this.botonEndDialog_Click);
            // 
            // VistaChatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 443);
            this.Controls.Add(this.botonEndDialog);
            this.Controls.Add(this.botonGuardarLog);
            this.Controls.Add(this.botonCargarLog);
            this.Controls.Add(this.botonVolver);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.inputUsuario);
            this.Controls.Add(this.cajaTextoGrande);
            this.Name = "VistaChatbot";
            this.Text = "VistaChatbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox cajaTextoGrande;
        private System.Windows.Forms.TextBox inputUsuario;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.Button botonVolver;
        private System.Windows.Forms.Button botonCargarLog;
        private System.Windows.Forms.Button botonGuardarLog;
        private System.Windows.Forms.Button botonEndDialog;
    }
}