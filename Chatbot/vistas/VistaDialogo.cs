using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatbot.vistas
{
    public partial class VistaDialogo : Form
    {
        public VistaDialogo()
        {
            InitializeComponent();
        }

        public void start()
        {
            Application.EnableVisualStyles();
            Application.Run(new VistaChatbot());
        }

        private void botonChatbotFormal_Click(object sender, EventArgs e)
        {

        }

        private void botonChatbotInformal_Click(object sender, EventArgs e)
        {

        }

        private void botonSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
