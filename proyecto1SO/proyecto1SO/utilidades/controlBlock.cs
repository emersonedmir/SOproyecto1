using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto1SO.utilidades
{
    class controlBlock
    {
        public int puerto;
        public List<Mensaje> listMensajesDirectos;
        public bool estado; //bloqueado o no  bloqueado

        public controlBlock()
        {
            puerto = 0;
            listMensajesDirectos = new List<Mensaje>();
            estado = false; // no bloqueado
        }

        public static implicit operator List<object>(controlBlock v)
        {
            throw new NotImplementedException();
        }
    }
}
