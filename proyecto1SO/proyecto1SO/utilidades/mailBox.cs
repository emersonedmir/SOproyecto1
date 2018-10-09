using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace proyecto1SO.utilidades
{
    public class MailBox
    {
        public List<Mensaje> lstMensajes;
        public int puerto;
        public MailBox(int pPuerto)
        {
            puerto = pPuerto;
            lstMensajes = new List<Mensaje>();
        }
    }
}