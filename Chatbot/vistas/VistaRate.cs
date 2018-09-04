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
    public partial class VistaRate : Form
    {
        ControladorChatbot controladorChatbot;

        /// <summary>
        /// Initializes a new instance of the <see cref="VistaRate"/> class.
        /// </summary>
        public VistaRate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starts the specified controlador chatbot.
        /// </summary>
        /// <param name="controladorChatbot">The controlador chatbot.</param>
        public void start(ControladorChatbot controladorChatbot)
        {
            this.controladorChatbot = controladorChatbot;
            this.Show();
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
        /// Adquirirs the evaluacion.
        /// </summary>
        /// <returns></returns>
        public int adquirirEvaluacion()
        {
            int index = rateScroll.SelectedIndex;
            return index+1;
        }

        /// <summary>
        /// Handles the Click event of the botonEvaluar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonEvaluar_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.adquirirEvaluaciones();
        }
    }
}
