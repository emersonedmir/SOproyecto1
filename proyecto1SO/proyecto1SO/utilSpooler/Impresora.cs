using proyecto1SO.utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1SO.utilSpooler
{
    class Impresora
    {
        public enum EstadoImpresora
        {
            Activo,
            Suspendido
        }
        public string nombre = "";
        public EstadoImpresora estado = EstadoImpresora.Suspendido;
        private static Mutex mutexOper = new Mutex();

        public void activarImpresion(){ estado = EstadoImpresora.Activo;}
        public void suspenderImpresion() { estado = EstadoImpresora.Suspendido; }

        public Impresora(string pNombre)
        {            
            this.nombre = pNombre;
            System.IO.Directory.CreateDirectory(this.@nombre);
        }

        private Mensaje Get_Mensaje(int idx)
        {
            Mensaje mensaje = null;
            int aux = -1;
            mutexOper.WaitOne();
            foreach (Mensaje item in puertos.lstMailBox[idx].lstMensajes)
            {
                if (item.strDestino == nombre)
                {
                    if (aux < item.prioridad)
                    {
                        aux = item.prioridad;
                        mensaje = item;
                    }
                }
            }
            if (mensaje != null)
                puertos.lstMailBox[idx].lstMensajes.Remove(mensaje);
            mutexOper.ReleaseMutex();
            return mensaje;

        }
        public void Imprimir(object pParametros)
        {
            int idx = puertos.Get_IdxMailBox(nombre);
            string rutaArchO, nomArch, extension, rutaArchD;
            int pos;
            while (true)
            {
                //Thread.Sleep(5000);
                if (estado == EstadoImpresora.Activo)
                {
                    Mensaje mensaje = Get_Mensaje(idx);
                    if (mensaje != null)
                    {
                        rutaArchO = @mensaje.Contenido;                        
                        string[] partes = rutaArchO.Split('\\');
                        nomArch = partes.Last();
                        extension = "";
                        pos = nomArch.LastIndexOf(".");
                        if (pos > -1)
                        {
                            extension = nomArch.Substring(pos);
                            nomArch.Remove(pos);
                        }                                                    
                        rutaArchD = this.@nombre + "\\" + nomArch;
                        if (System.IO.File.Exists(rutaArchO))
                        {
                            string indiceCopia = "";
                            int indice = 0;
                            while (System.IO.File.Exists(rutaArchD + indiceCopia + extension))
                                indiceCopia = " (" + (++indice) + ")";
                            rutaArchD += indiceCopia + extension;

                            Thread.Sleep(3000);
                            try
                            {
                                System.IO.File.Copy(rutaArchO, rutaArchD, true);
                            }
                            catch (InvalidCastException e)
                            {
                                MessageBox.Show(e.ToString());
                            }
                        }
                    }
                    else
                        suspenderImpresion();
                }                
                //else
                //{                    
                    ////log + algun estado como hilos de procesos
                    //#pragma warning disable CS0618 // Type or member is obsolete
                    //hilosSpooler.hilosMailBox[idx].Suspend();
                    //hilosSpooler.hilosMailBox[idx].
                    //#pragma warning restore CS0618 // Type or member is obsolete
                //}                    
            }
        }
    }
}
