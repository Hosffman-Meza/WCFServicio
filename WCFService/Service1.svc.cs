using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        BDServicioEntities db = new BDServicioEntities();

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        //STPR de lectura (Select)
        public List<SP_Select_TipoServicio_Result> viewListTipoServicio()
        {
            return db.SP_Select_TipoServicio_Result().ToList();
        }

        public List<SP_Select_Ubicacion_Result> viewListUbicacion()
        {
            return db.SP_Select_Ubicacion_Result().ToList();
        }

        public List<verServicio_Result> viewListServicio()
        {
            return db.verServicio_Result().ToList();
        }

        public List<verClientes_Result> viewListClientes()
        {
            return db.verClientes_Result().ToList();
        }

        public List<verClientesActivos_Result> viewListClientesActivos()
        {
            return db.verClientesActivos_Result().ToList();
        }

        //STPR Insert
        public SP_In_TipoServicio_Result insertTipoServicio(string descripcion, Boolean estado)
        {
            return db.SP_In_TipoServicio_Result(descripcion, estado).FirstOrDefault();
        }

        public SP_In_Ubicacion_Result insertUbicacion(int maestro, string nombre, string tipo)
        {
            return db.SP_In_Ubicacion_Result(maestro, nombre, tipo).FirstOrDefault();
        }

        public SP_In_Servicio_Result insertServicio(int tipoServicio, string nombre, decimal costoBase)
        {
            return db.SP_In_Servicio_Result(tipoServicio, nombre, costoBase).FirstOrDefault();
        }

        public SP_In_Cliente_Result insertCliente(string nombre, string apellido, string telefono, string tipo, string estado)
        {
            return db.SP_In_Cliente_Result(nombre, apellido, telefono, tipo, estado).FirstOrDefault();
        }

        //STPR Update
        public SP_Up_TipoServicio_Result updateTipoServicio(int id, string descripcion, Boolean estado)
        {
            return db.SP_Up_TipoServicio_Result(id, descripcion, estado).FirstOrDefault();
        }

        public SP_Up_Ubicacion_Result updateUbicacion(int maestro, string nombre, string tipo, int id)
        {
            return db.SP_Up_Ubicacion_Result(maestro, nombre, tipo, id).FirstOrDefault();
        }

        public SP_Up_Servicio_Result updateServicio(int id, int tipoServicio, string nombre, decimal costoBase)
        {
            return db.SP_Up_Servicio_Result(id, tipoServicio, nombre, costoBase).FirstOrDefault();
        }

        public SP_Up_Cliente_Result updateCliente(int id, string nombre, string apellido, string telefono, string tipo, string estado)
        {
            return db.SP_Up_Cliente_Result(id, nombre, apellido, telefono, tipo, estado).FirstOrDefault();
        }

        //STPR Delete
        public SP_Del_TipoServicio_Result deleteTipoServicio(int id)
        {
            return db.SP_Del_TipoServicio_Result(id).FirstOrDefault();
        }

        public SP_Del_Ubicacion_Result deleteUbicacion(int id)
        {
            return db.SP_Del_Ubicacion_Result(id).FirstOrDefault();
        }

        public SP_Del_Servicio_Result deleteServicio(int id)
        {
            return db.SP_Del_Servicio_Result(id).FirstOrDefault();
        }

        public SP_Del_Cliente_Result deleteCliente(int id)
        {
            return db.SP_Del_Cliente_Result(id).FirstOrDefault();
        }

        //SELECT_ONE
        public SP_selectOne_TipoServicio_Result selectOneTipoServicio(int id)
        {
            return db.SP_selectOne_TipoServicio_Result(id).FirstOrDefault();
        }
    }
}
