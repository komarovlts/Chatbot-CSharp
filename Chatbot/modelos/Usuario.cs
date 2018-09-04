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

        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario"/> class.
        /// </summary>
        public Usuario()
        {
            this.nombreUsuario = "";
            this.pedidoUsuario = "";
        }
    }
}
