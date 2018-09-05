namespace Chatbot.vistas
{
    partial class VistaDialogo
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
            this.funcionEtiqueta = new System.Windows.Forms.Label();
            this.botonChatbotFormal = new System.Windows.Forms.Button();
            this.botonChatbotInformal = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // funcionEtiqueta
            // 
            this.funcionEtiqueta.AutoSize = true;
            this.funcionEtiqueta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.funcionEtiqueta.Location = new System.Drawing.Point(12, 19);
            this.funcionEtiqueta.Name = "funcionEtiqueta";
            this.funcionEtiqueta.Size = new System.Drawing.Size(426, 16);
            this.funcionEtiqueta.TabIndex = 3;
            this.funcionEtiqueta.Text = "Este chatbot te ayuda a realizar un pedido de homocinéticas";
            // 
            // botonChatbotFormal
            // 
            this.botonChatbotFormal.Location = new System.Drawing.Point(86, 67);
            this.botonChatbotFormal.Name = "botonChatbotFormal";
            this.botonChatbotFormal.Size = new System.Drawing.Size(273, 23);
            this.botonChatbotFormal.TabIndex = 5;
            this.botonChatbotFormal.Text = "Iniciar Conversación con Chatbot Formal";
            this.botonChatbotFormal.UseVisualStyleBackColor = true;
            this.botonChatbotFormal.Click += new System.EventHandler(this.botonChatbotFormal_Click);
            // 
            // botonChatbotInformal
            // 
            this.botonChatbotInformal.Location = new System.Drawing.Point(86, 117);
            this.botonChatbotInformal.Name = "botonChatbotInformal";
            this.botonChatbotInformal.Size = new System.Drawing.Size(273, 23);
            this.botonChatbotInformal.TabIndex = 6;
            this.botonChatbotInformal.Text = "Iniciar Conversación con Chatbot Informal";
            this.botonChatbotInformal.UseVisualStyleBackColor = true;
            this.botonChatbotInformal.Click += new System.EventHandler(this.botonChatbotInformal_Click);
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(182, 192);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 7;
            this.botonSalir.Text = "Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // VistaDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 253);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonChatbotInformal);
            this.Controls.Add(this.botonChatbotFormal);
            this.Controls.Add(this.funcionEtiqueta);
            this.Name = "VistaDialogo";
            this.Text = "Chatbot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label funcionEtiqueta;
        private System.Windows.Forms.Button botonChatbotFormal;
        private System.Windows.Forms.Button botonChatbotInformal;
        private System.Windows.Forms.Button botonSalir;
    }
}