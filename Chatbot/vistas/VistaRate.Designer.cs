namespace Chatbot.vistas
{
    partial class VistaRate
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
            this.mensajeRate = new System.Windows.Forms.Label();
            this.rateScroll = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.botonEvaluar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mensajeRate
            // 
            this.mensajeRate.AutoSize = true;
            this.mensajeRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mensajeRate.Location = new System.Drawing.Point(80, 27);
            this.mensajeRate.Name = "mensajeRate";
            this.mensajeRate.Size = new System.Drawing.Size(410, 16);
            this.mensajeRate.TabIndex = 4;
            this.mensajeRate.Text = "¿Te ha gustado la aplicación? ¡Por favor danos tu opinión!";
            // 
            // rateScroll
            // 
            this.rateScroll.FormattingEnabled = true;
            this.rateScroll.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.rateScroll.Location = new System.Drawing.Point(183, 136);
            this.rateScroll.Name = "rateScroll";
            this.rateScroll.Size = new System.Drawing.Size(90, 21);
            this.rateScroll.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(227, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Elija una opción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Donde 1 implica \"no me gustó\" a 5 \"Me gustó mucho\"";
            // 
            // botonEvaluar
            // 
            this.botonEvaluar.Location = new System.Drawing.Point(301, 134);
            this.botonEvaluar.Name = "botonEvaluar";
            this.botonEvaluar.Size = new System.Drawing.Size(100, 23);
            this.botonEvaluar.TabIndex = 9;
            this.botonEvaluar.Text = "Evaluar";
            this.botonEvaluar.UseVisualStyleBackColor = true;
            this.botonEvaluar.Click += new System.EventHandler(this.botonEvaluar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(227, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "¡Muchas Gracias!";
            // 
            // VistaRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 248);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonEvaluar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rateScroll);
            this.Controls.Add(this.mensajeRate);
            this.Name = "VistaRate";
            this.Text = "VistaRate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mensajeRate;
        private System.Windows.Forms.ComboBox rateScroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEvaluar;
        private System.Windows.Forms.Label label3;
    }
}