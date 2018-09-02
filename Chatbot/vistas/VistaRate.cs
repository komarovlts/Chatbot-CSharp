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

        public VistaRate()
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
            if (mostrar == true)
                this.Show();
            else
                this.Hide();
        }

        public int adquirirEvaluacion()
        {
            int index = rateScroll.SelectedIndex;
            return index;
        }

        private void botonEvaluar_Click(object sender, EventArgs e)
        {
            this.controladorChatbot.adquirirEvaluaciones();
        }
    }
}
