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
        public ControladorChatbot controlador { get; set; }

        public VistaChatbot()
        {
            InitializeComponent();
        }

        public void start()
        {
            Application.EnableVisualStyles();
            Application.Run(new VistaChatbot());
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
