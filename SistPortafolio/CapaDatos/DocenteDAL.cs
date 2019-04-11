using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;

namespace CapaDatos.Entidad
{
    public class DocenteDAL
    {
        ConexionLinqDataContext cl = new ConexionLinqDataContext();
        
        string msj;
        public string Insert(Docente pDocente)
        {

            cl.spInsertar_Docente(pDocente.IdDocente,pDocente.Nombre,pDocente.ApellidoPat,pDocente.ApellidoMat,pDocente.DNI,pDocente.Telefono,pDocente.Direccion,ref msj);
            return msj;
        }
        public string Update(Docente pDocente)
        {
            cl.spActualizar_Docente(pDocente.IdDocente, pDocente.Nombre, pDocente.ApellidoPat, pDocente.ApellidoMat, pDocente.DNI, pDocente.Telefono, pDocente.Direccion, ref msj);
            return msj;
        }
        public string Delete(Docente pDocente)
        {
            cl.spEliminar_Docente(pDocente.IdDocente, ref msj);
            return msj;
        }
        /*public var Buscar(Docente pDocente)
        {
            var dt=cl.spBuscar_Docente(pDocente.IdDocente, ref msj);
            SqlDataAdapter SqlDat = new SqlDataAdapter();
            return dt;
        }*/
    }
}
