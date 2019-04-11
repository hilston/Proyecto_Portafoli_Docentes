using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos.Entidad;

namespace CapaNegocio
{
    public class DocenteBL
    {
        public static string Insert(string pIdDocente, string pNombre, string pApellidoPat, string pApellidoMat, string pDNI, string pTelefono, string pDireccion)
        {
            Docente Obj = new Docente();
            Obj.IdDocente = pIdDocente;
            Obj.Nombre = pNombre;
            Obj.ApellidoPat = pApellidoPat;
            Obj.ApellidoMat = pApellidoMat;
            Obj.DNI = pDNI;
            Obj.Telefono = pTelefono;
            Obj.Direccion = pDireccion;
            DocenteDAL dal = new DocenteDAL();
            return dal.Insert(Obj);
        }
        public static string Update(string pIdDocente, string pNombre, string pApellidoPat, string pApellidoMat, string pDNI, string pTelefono, string pDireccion)
        {
            Docente Obj = new Docente();
            Obj.IdDocente = pIdDocente;
            Obj.Nombre = pNombre;
            Obj.ApellidoPat = pApellidoPat;
            Obj.ApellidoMat = pApellidoMat;
            Obj.DNI = pDNI;
            Obj.Telefono = pTelefono;
            Obj.Direccion = pDireccion;
            DocenteDAL dal = new DocenteDAL();
            return dal.Update(Obj);
        }
        public static string Delete(string pIdDocente)
        {
            Docente Obj = new Docente();
            Obj.IdDocente = pIdDocente;
  
            DocenteDAL dal = new DocenteDAL();
            return dal.Delete(Obj);
        }
    }
}
