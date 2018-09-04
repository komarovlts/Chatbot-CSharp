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
    public partial class VistaChatbot : Form
    {
        ControladorChatbot controladorChatbot;

        /// <summary>
        /// Initializes a new instance of the <see cref="VistaChatbot"/> class.
        /// </summary>
        public VistaChatbot()
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
            if(mostrar == true)
                this.Show();
            else
                this.Hide();
        }

        /// <summary>
        /// Adquirirs the de caja texto.
        /// </summary>
        /// <returns></returns>
        internal String adquirirDeCajaTexto()
        {
            String respuestaUsuario;
            respuestaUsuario = inputUsuario.Text;
            inputUsuario.Text = "";
            return respuestaUsuario;
        }

        /// <summary>
        /// Escribirs the en caja texto grande.
        /// </summary>
        /// <param name="texto">The texto.</param>
        internal void escribirEnCajaTextoGrande(String texto)
        {
            this.cajaTextoGrande.AppendText(texto + System.Environment.NewLine);
        }

        /// <summary>
        /// Handles the Click event of the botonSalir control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.back();
        }

        /// <summary>
        /// Handles the Click event of the botonEnviar control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonEnviar_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.interaccionConUsuario();
        }

        /// <summary>
        /// Handles the Click event of the botonEndDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonEndDialog_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.finalizador();
        }

        /// <summary>
        /// Handles the Click event of the botonGuardarLog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonGuardarLog_Click(object sender, EventArgs e)
        {
            // Código obtenido desde documentación oficial.  
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Documento de Texto|*.txt";
            saveFileDialog.Title = "Guardar el log en";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                this.controladorChatbot.saveLog(saveFileDialog.FileName);
            }
        }

        /// <summary>
        /// Handles the Click event of the botonCargarLog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void botonCargarLog_Click(object sender, EventArgs e)
        {
            // Código obtenido desde documentación oficial.  
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Documento de Texto|*.txt";
            openFileDialog.Title = "Buscando Log";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.controladorChatbot.loadLog(openFileDialog.FileName);
            }
        }

        /// <summary>
        /// Vaciars the chat.
        /// </summary>
        internal void vaciarChat()
        {
            this.cajaTextoGrande.Clear();
            this.cajaTextoGrande.Focus();
        }

        /// <summary>
        /// Estadoes the boton enviar.
        /// </summary>
        /// <param name="activar">if set to <c>true</c> [activar].</param>
        internal void estadoBotonEnviar(bool activar)
        {
            this.botonEnviar.Enabled = activar;
        }

        /// <summary>
        /// Ventanas the exito load log.
        /// </summary>
        internal void ventanaExitoLoadLog()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("El log ha sido cargado exitosamente.", "Éxito", buttons);
        }

        /// <summary>
        /// Ventanas the exito save log.
        /// </summary>
        internal void ventanaExitoSaveLog()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show("El log ha sido guardado exitosamente.", "Éxito", buttons);
        }
    }
}
