using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidad
{
    class Usuario
    {

     //   private
     
        private string aIdUsuario;
        private string aIdPerfil;
        private string aNombre;
        private string aApellidoPat;
        private string aApellidoMat;
        private string aDNI;
        private string aTelefono;
        private string aDireccion;
        private string aNick;
        private string aContraseña;

        

        public Usuario()
        {
            AIdUsuario = "";
            AIdPerfil = "";
            ANombre = "";
            AApellidoPat = "";
            AApellidoMat = "";
            ADNI = "";
            ATelefono = "";
            ADireccion = "";
            ANick = "";
            AContraseña = "";
        }

        public Usuario(string pIdUsuario, string pIdPerfil, string pNombre, 
            string pApellidoPat, string pApellidoMat, string pDNI, string pTelefono, 
            string pDireccion, string pNick, string pContraseña)
        {
            AIdUsuario = pIdUsuario;
            AIdPerfil = pIdPerfil;
            ANombre = pNombre;
            AApellidoPat = pApellidoPat;
            AApellidoMat = pApellidoMat;
            ADNI = pDNI;
            ATelefono = pTelefono;
            ADireccion = pDireccion;
            ANick = pNick;
            AContraseña = pContraseña;
        }

        //PROPIEDADES
        public string AIdUsuario
        {
            get
            {
                return aIdUsuario;
            }

            set
            {
                aIdUsuario = value;
            }
        }

        public string AIdPerfil
        {
            get
            {
                return aIdPerfil;
            }

            set
            {
                aIdPerfil = value;
            }
        }

        public string ANombre
        {
            get
            {
                return aNombre;
            }

            set
            {
                aNombre = value;
            }
        }

        public string AApellidoPat
        {
            get
            {
                return aApellidoPat;
            }

            set
            {
                aApellidoPat = value;
            }
        }

        public string AApellidoMat
        {
            get
            {
                return aApellidoMat;
            }

            set
            {
                aApellidoMat = value;
            }
        }

        public string ADNI
        {
            get
            {
                return aDNI;
            }

            set
            {
                aDNI = value;
            }
        }

        public string ATelefono
        {
            get
            {
                return aTelefono;
            }

            set
            {
                aTelefono = value;
            }
        }

        public string ADireccion
        {
            get
            {
                return aDireccion;
            }

            set
            {
                aDireccion = value;
            }
        }

        public string ANick
        {
            get
            {
                return aNick;
            }

            set
            {
                aNick = value;
            }
        }

        public string AContraseña
        {
            get
            {
                return aContraseña;
            }

            set
            {
                aContraseña = value;
            }
        }
    }
}
