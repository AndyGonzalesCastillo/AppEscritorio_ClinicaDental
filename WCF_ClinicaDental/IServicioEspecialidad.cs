using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEspecialidad" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEspecialidad
    {
        [OperationContract]
        List<EspecialidadDC> ListarEspecialidades();

    }

    [DataContract]
    [Serializable]
    public class EspecialidadDC
    {
        [DataMember] public int idEspecialidad { get; set; }

        [DataMember] public string nombre { get; set; }

        [DataMember] public string descripcion { get; set; }
    }
}
