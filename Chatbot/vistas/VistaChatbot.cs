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

        public VistaChatbot()
        {
            InitializeComponent();
        }

        public void start(ControladorChatbot controladorChatbot)
        {
            this.controladorChatbot = controladorChatbot;
            this.Show();
        }

        public void show(bool mostrar)
        {
            if(mostrar == true)
                this.Show();
            else
                this.Hide();
        }

        internal String adquirirDeCajaTexto()
        {
            String respuestaUsuario;
            respuestaUsuario = inputUsuario.Text;
            inputUsuario.Text = "";
            return respuestaUsuario;
        }

        internal void escribirEnCajaTextoGrande(String texto)
        {
            this.cajaTextoGrande.AppendText(texto + System.Environment.NewLine);
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.back();
        }

        private void botonEnviar_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.interaccionConUsuario();
        }

        private void botonEndDialog_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.finalizador();
        }

        private void botonGuardarLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Documento de Texto|*.txt";
            saveFileDialog.Title = "Guardar el log en";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                this.controladorChatbot.saveLog(saveFileDialog.FileName);
            }
        }

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

        internal void vaciarChat()
        {
            this.cajaTextoGrande.Clear();
            this.cajaTextoGrande.Focus();
        }
        internal void estadoBotonEnviar(bool activar)
        {
            this.botonEnviar.Enabled = activar;
        }

        internal void ventanaExitoLoadLog()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("El log ha sido cargado exitosamente.", "Éxito", buttons);
        }

        internal void ventanaExitoSaveLog()
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show("El log ha sido guardado exitosamente.", "Éxito", buttons);
        }

        
    }
}
