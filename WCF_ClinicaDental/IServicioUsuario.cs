using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioUsuario" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioUsuario
    {
        [OperationContract]
        UsuarioDC Login(string dni, string contraseña);


    }

    [DataContract]
    public class UsuarioDC
    {
        [DataMember] public int idUsuario { get; set; }
        [DataMember] public int? idDentista { get; set; }
        [DataMember] public string especialidad { get; set; }
        [DataMember] public string dni { get; set; }
        [DataMember] public string rol { get; set; }
        [DataMember] public string nombres { get; set; }
        [DataMember] public string apellidos { get; set; }
    }


}
