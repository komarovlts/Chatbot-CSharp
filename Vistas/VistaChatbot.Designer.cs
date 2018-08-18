namespace Vistas
{
    partial class Chatbot
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.botonSalir = new System.Windows.Forms.Button();
            this.funcionEtiqueta = new System.Windows.Forms.Label();
            this.inputUsuario = new System.Windows.Forms.TextBox();
            this.botonEnviar = new System.Windows.Forms.Button();
            this.cajaTextoGrande = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(408, 316);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 0;
            this.botonSalir.Text = "Cerrar";
            this.botonSalir.UseVisualStyleBackColor = true;
            // 
            // funcionEtiqueta
            // 
            this.funcionEtiqueta.AutoSize = true;
            this.funcionEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionEtiqueta.Location = new System.Drawing.Point(35, 9);
            this.funcionEtiqueta.Name = "funcionEtiqueta";
            this.funcionEtiqueta.Size = new System.Drawing.Size(426, 16);
            this.funcionEtiqueta.TabIndex = 1;
            this.funcionEtiqueta.Text = "Este chatbot te ayuda a realizar un pedido de homocinéticas";
            // 
            // inputUsuario
            // 
            this.inputUsuario.Location = new System.Drawing.Point(89, 266);
            this.inputUsuario.Name = "inputUsuario";
            this.inputUsuario.Size = new System.Drawing.Size(248, 20);
            this.inputUsuario.TabIndex = 2;
            this.inputUsuario.TextChanged += new System.EventHandler(this.InputUsuario_TextChanged);
            // 
            // botonEnviar
            // 
            this.botonEnviar.Location = new System.Drawing.Point(343, 264);
            this.botonEnviar.Name = "botonEnviar";
            this.botonEnviar.Size = new System.Drawing.Size(75, 23);
            this.botonEnviar.TabIndex = 3;
            this.botonEnviar.Text = "Enviar";
            this.botonEnviar.UseVisualStyleBackColor = true;
            this.botonEnviar.Click += new System.EventHandler(this.BotonEnviar_Click);
            // 
            // cajaTextoGrande
            // 
            this.cajaTextoGrande.Location = new System.Drawing.Point(89, 45);
            this.cajaTextoGrande.Name = "cajaTextoGrande";
            this.cajaTextoGrande.ReadOnly = true;
            this.cajaTextoGrande.Size = new System.Drawing.Size(299, 194);
            this.cajaTextoGrande.TabIndex = 4;
            this.cajaTextoGrande.Text = "";
            this.cajaTextoGrande.TextChanged += new System.EventHandler(this.cajaTextoGrande_TextChanged);
            // 
            // Chatbot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 348);
            this.Controls.Add(this.cajaTextoGrande);
            this.Controls.Add(this.botonEnviar);
            this.Controls.Add(this.inputUsuario);
            this.Controls.Add(this.funcionEtiqueta);
            this.Controls.Add(this.botonSalir);
            this.Name = "Chatbot";
            this.Text = "Chatbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.Label funcionEtiqueta;
        private System.Windows.Forms.TextBox inputUsuario;
        private System.Windows.Forms.Button botonEnviar;
        private System.Windows.Forms.RichTextBox cajaTextoGrande;
    }
}

