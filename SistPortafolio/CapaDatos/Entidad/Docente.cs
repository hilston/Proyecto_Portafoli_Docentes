using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidad
{
    public class Docente
    {
        private string aIdDocente;
        private string aNombre;
        private string aApellidoPat;
        private string aApellidoMat;
        private string aDNI;
        private string aTelefono;
        private string aDireccion;
        public Docente()
        {
            aIdDocente="";
            aNombre="";
            aApellidoPat="";
            aApellidoMat="";
            aDNI="";
            aTelefono="";
            aDireccion="";
        }

        public Docente(string pIdDocente,string pNombre, string pApellidoPat, string pApellidoMat, string pDNI, string pTelefono, string pDireccion)
        {
            aIdDocente = pIdDocente;
            aNombre = pNombre;
            aApellidoPat = pApellidoPat;
            aApellidoMat = pApellidoMat;
            aDNI = pDNI;
            aTelefono = pTelefono;
            aDireccion = pDireccion;
        }

        //PROPIEDADES
        public string IdDocente
        {
            get { return aIdDocente; }
            set { aIdDocente = value; }
        }
        public string Nombre
        {
            get { return aNombre; }
            set { aNombre = value; }
        }
        public string ApellidoPat
        {
            get { return aApellidoPat; }
            set { aApellidoPat = value; }
        }
        public string ApellidoMat
        {
            get { return aApellidoMat; }
            set { aApellidoMat = value; }
        }
        public string DNI
        {
            get { return aDNI; }
            set { aDNI = value; }
        }
        public string Telefono
        {
            get { return aTelefono; }
            set { aTelefono = value; }
        }
        public string Direccion
        {
            get { return aDireccion; }
            set { aDireccion = value; }
        }
    }

}
