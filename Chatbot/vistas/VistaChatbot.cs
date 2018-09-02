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
    }
}
