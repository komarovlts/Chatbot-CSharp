using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.modelos
{
    public class Usuario
    {
        /// <summary>
        /// Gets or sets del nombre del usuario.
        /// </summary>
        /// <value>
        /// El parámetro nombreUsuario representa el nombre que el usuario 
        /// proporciona de si mismo.
        /// </value>
        public String nombreUsuario { get; set; }

        /*
        /// <summary>
        /// Este parámetro fue implementado, pero durante el desarrollo se determinó que no era
        /// del todo necesario, no obstante, se deja comentado por si en algún momento se decide
        /// volver a utilizarle.
        /// Gets or sets del pedido usuario.
        /// </summary>
        /// <value>
        /// El parámetro pedidoUsuario representa el pedido del usuario 
        /// ya finalizada la conversación.
        /// </value>
        public String pedidoUsuario { get; set; }
        */

        /// <summary>
        /// Initializes a new instance of the <see cref="Usuario"/> class.
        /// </summary>
        public Usuario()
        {
            this.nombreUsuario = "";
            //this.pedidoUsuario = "";
        }
    }
}
