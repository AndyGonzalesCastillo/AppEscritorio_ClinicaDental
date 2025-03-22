using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTratamiento" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTratamiento
    {
        [OperationContract]
        List<TratamientoDC> ListarTratamientos();
    }

    [DataContract]
    [Serializable]
    public class TratamientoDC
    {
        [DataMember] public int idTratamiento { get; set; }
        [DataMember] public String nombre { get; set; }
        [DataMember] public String descripcion { get; set; }
        [DataMember] public decimal precio { get; set; }
    }
}
