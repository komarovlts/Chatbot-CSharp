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
        public ControladorDialogo controladorDialogo { get; set; }

        public VistaDialogo()
        {
            InitializeComponent();
        }

        public void start()
        {
            Application.EnableVisualStyles();
            Application.Run(new VistaDialogo());
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
            controladorDialogo = new ControladorDialogo();
            controladorDialogo.iniciarDialogo(1);
            this.Hide();
        }

        private void botonChatbotInformal_Click(object sender, EventArgs e)
        {
            controladorDialogo = new ControladorDialogo();
            controladorDialogo.iniciarDialogo(0);
            this.Hide();
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
