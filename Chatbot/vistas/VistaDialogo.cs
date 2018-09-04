using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chatbot.controladores;

namespace Chatbot.vistas
{
    public partial class VistaDialogo : Form
    {
        private ControladorDialogo controladorDialogo;

        /// <summary>
        /// Initializes a new instance of the <see cref="VistaDialogo"/> class.
        /// </summary>
        public VistaDialogo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts the specified controlador dialogo.
        /// </summary>
        /// <param name="controladorDialogo">The controlador dialogo.</param>
        public void start(ControladorDialogo controladorDialogo)
        {
            this.controladorDialogo = controladorDialogo;
            Application.EnableVisualStyles();
            Application.Run(this);
        }

        /// <summary>
        /// Shows the specified mostrar.
        /// </summary>
        /// <param name="mostrar">if set to <c>true</c> [mostrar].</param>
        public void show(bool mostrar)
        {
            if (mostrar == true)
                this.Show();
            else
                this.Hide();
        }

        /// <summary>
        /// Handles the Click event of the botonChatbotFormal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonChatbotFormal_Click(object sender, EventArgs e)
        {
            controladorDialogo.iniciarDialogo(1);
            this.show(false);
        }

        /// <summary>
        /// Handles the Click event of the botonChatbotInformal control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonChatbotInformal_Click(object sender, EventArgs e)
        {
            controladorDialogo.iniciarDialogo(0);
            this.show(false);
        }

        /// <summary>
        /// Mostrars the dialogo salir.
        /// </summary>
        internal void mostrarDialogoSalir()
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show("¿Realmente desea salir?", "¿Salir?", buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        /// <summary>
        /// Handles the Click event of the botonSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonSalir_Click(object sender, EventArgs e)
        {
            mostrarDialogoSalir();            
        }
    }
}
