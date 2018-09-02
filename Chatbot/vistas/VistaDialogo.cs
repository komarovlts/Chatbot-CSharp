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

        public VistaDialogo()
        {
            InitializeComponent();
        }

        public void start(ControladorDialogo controladorDialogo)
        {
            this.controladorDialogo = controladorDialogo;
            Application.EnableVisualStyles();
            Application.Run(this);
        }

        public void show(bool mostrar)
        {
            if (mostrar == true)
                this.Show();
            else
                this.Hide();
        }

        private void botonChatbotFormal_Click(object sender, EventArgs e)
        {
            controladorDialogo.iniciarDialogo(1);
            this.show(false);
        }

        private void botonChatbotInformal_Click(object sender, EventArgs e)
        {
            controladorDialogo.iniciarDialogo(0);
            this.show(false);
        }

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

        private void botonSalir_Click(object sender, EventArgs e)
        {
            mostrarDialogoSalir();            
        }
    }
}
