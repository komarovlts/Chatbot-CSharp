﻿namespace Chatbot.vistas
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
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cajaTextoGrande
            // 
            this.cajaTextoGrande.Location = new System.Drawing.Point(57, 57);
            this.cajaTextoGrande.Name = "cajaTextoGrande";
            this.cajaTextoGrande.ReadOnly = true;
            this.cajaTextoGrande.Size = new System.Drawing.Size(343, 194);
            this.cajaTextoGrande.TabIndex = 5;
            this.cajaTextoGrande.Text = "";
            // 
            // inputUsuario
            // 
            this.inputUsuario.Location = new System.Drawing.Point(57, 272);
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(248, 20);
            this.inputUsuario.TabIndex = 6;
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(325, 269);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(75, 23);
            this.botonEnviar.TabIndex = 7;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(370, 348);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 8;
            this.botonSalir.Text = "Cerrar";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // VistaChatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 383);
            this.Controls.Add(this.botonSalir);
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
        private System.Windows.Forms.Button botonSalir;
    }
}