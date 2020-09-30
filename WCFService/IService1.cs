using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);
        
        //SELECT
        [OperationContract]
        List<SP_Select_TipoServicio_Result> viewListTipoServicio();

        [OperationContract]
        List<SP_Select_Ubicacion_Result> viewListUbicacion();

        [OperationContract]
        List<verServicio_Result> viewListServicio();

        [OperationContract]
        List<verClientes_Result> viewListClientes();

        [OperationContract]
        List<verClientesActivos_Result> viewListClientesActivos();

        //INSERT
        [OperationContract]
        SP_In_TipoServicio_Result insertTipoServicio(string descripcion, Boolean estado);

        [OperationContract]
        SP_In_Ubicacion_Result insertUbicacion(int maestro, string nombre, string tipo);

        [OperationContract]
        SP_In_Servicio_Result insertServicio(int tipoServicio, string nombre, decimal costoBase);

        [OperationContract]
        SP_In_Cliente_Result insertCliente(string nombre, string apellido, string telefono, string tipo, string estado);

        //UPDATE
        [OperationContract]
        SP_Up_TipoServicio_Result updateTipoServicio(int id, string descripcion, Boolean estado);

        [OperationContract]
        SP_Up_Ubicacion_Result updateUbicacion(int maestro, string nombre, string tipo, int id);

        [OperationContract]
        SP_Up_Servicio_Result updateServicio(int id, int tipoServicio, string nombre, decimal costoBase);

        [OperationContract]
        SP_Up_Cliente_Result updateCliente(int id, string nombre, string apellido, string telefono, string tipo, string estado);

        //DELETE
        [OperationContract]
        SP_Del_TipoServicio_Result deleteTipoServicio(int id);

        [OperationContract]
        SP_Del_Ubicacion_Result deleteUbicacion(int id);

        [OperationContract]
        SP_Del_Servicio_Result deleteServicio(int id);

        [OperationContract]
        SP_Del_Cliente_Result deleteCliente(int id);

        //SELECT_One
        [OperationContract]
        SP_selectOne_TipoServicio_Result selectOneTipoServicio(int id);


    }
}
