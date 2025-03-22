using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioPaciente" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioPaciente
    {
        [OperationContract]
        PacienteDC ConsultarPaciente(String idPaciente);

        [OperationContract]
        List<PacienteDC> ListarPacientes();

        [OperationContract]
        Boolean agregarPaciente(PacienteDC objPacienteDC);

        [OperationContract]
        Boolean ActualizarPaciente(PacienteDC objPacienteDC);

        [OperationContract]
        Boolean EliminarPaciente(String idPaciente);
    }
    [DataContract]
    [Serializable]
    public class PacienteDC
    {
        [DataMember] public int idPaciente { get; set; }

        [DataMember] public int idUsuario { get; set; }

        [DataMember] public string dni { get; set; }

        [DataMember] public string correo { get; set; }

        [DataMember] public string contraseña { get; set; }

        [DataMember] public string nombres { get; set; }

        [DataMember] public string apellidos { get; set; }

        [DataMember] public string telefono { get; set; }

        [DataMember] public DateTime fechaNacimiento { get; set; }

        [DataMember] public string direccion { get; set; }

        [DataMember] public int sexo { get; set; }

        [DataMember] public string sexo_cadena { get; set; }

        [DataMember] public int edad { get; set; }

        [DataMember] public string rol { get; set; }

        [DataMember] public int estado { get; set; }

        [DataMember] public string estado_cadena { get; set; }

        [DataMember] public string ApellidoYNombre { get; set; }


    }
}
