using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.modelos
{
    public class Usuario
    {
        public String nombreUsuario { get; set; }
        public String pedidoUsuario { get; set; }

        public Usuario()
        {
            this.nombreUsuario = "";
            this.pedidoUsuario = "";
        }
    }
}
