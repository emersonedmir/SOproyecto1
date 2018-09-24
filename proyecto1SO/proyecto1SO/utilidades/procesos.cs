using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace proyecto1SO.utilidades
{
    public static class procesos
    {
        public static List<hilo> lstProcesos = new List<hilo>();    //contiene las referencias de la direccion de memoria de los procesos
        public static List<mailBox> MailBox = new List<mailBox>();  //buzon compartido para direccionamiento send indirecto
    }
}