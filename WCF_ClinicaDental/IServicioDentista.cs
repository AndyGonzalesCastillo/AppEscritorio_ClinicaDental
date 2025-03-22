using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Cambiar nombre" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioDentista" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioDentista
    {
        [OperationContract]
        List<DentistaDC> ListarDentistasPorEspecialidad(String idEspecialidad);

        [OperationContract]
        List<DisponibilidadDC> ConsultarDisponibilidadDetallada(String idDentista);

        [OperationContract]
        DentistaDC ConsultarDentista(String idDentista);

        [OperationContract]
        List<DentistaDC> ListarDentistas();

        [OperationContract]
        Boolean AgregarDentista(DentistaDC objDentista);

        [OperationContract]
        Boolean ActualizarDentista(DentistaDC objDentista);

        [OperationContract]
        Boolean EliminarDentista(String idDentista);



    }

    [DataContract]
    [Serializable]
    public class DentistaDC
    {
        [DataMember] public int idDentista { get; set; }
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

        [DataMember] public int estadoDentista { get; set; }
        [DataMember] public int estadoDentistaUsuario { get; set; }

        [DataMember] public string estadoDentistaUsuario_cadena { get; set; }


        [DataMember] public string estadoDentista_cadena { get; set; }

        [DataMember] public string ApellidoYNombre { get; set; }

        [DataMember] public int idEspecialidad { get; set; }

        [DataMember] public string nombreEspecialidad { get; set; }

        [DataMember] public int estado { get; set; }


    }

    [DataContract]
    [Serializable]
    public class DisponibilidadDC
    {
        [DataMember] public string diaSemana { get; set; }

        [DataMember] public DateTime fecha { get; set; }

        [DataMember] public TimeSpan hora { get; set; }

        [DataMember] public int estado { get; set; }

        [DataMember] public string estado_cadena { get; set; }




    }


}
