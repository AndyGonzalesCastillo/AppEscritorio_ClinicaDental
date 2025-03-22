using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    [ServiceContract]
    public interface IServicioCita
    {
        [OperationContract]
        Boolean AgregarCita(CitaDC objCitaDC);

        [OperationContract]
        List<CitaDC> ListarCitasPaciente(String idCita);

        [OperationContract]
        Boolean CancelarCita(String idCita);

        [OperationContract]
        List<CitaDC> ListarHistoriaClinica(String idPaciente);

        [OperationContract]
        List<CitaDC> ListarCitasPorDentistaYFecha(String idDentista, DateTime fechaInicio, DateTime? fechaFin = null);

        [OperationContract]
        bool AgregarHistoriaClinica(CitaDC CitaDC);

        [OperationContract]
        bool ActualizarEstadoCita(int idCita, int estado);

        [OperationContract]
        bool ExisteHistoriaClinica(int idCita);

        [OperationContract]
        CitaDC ConsultarHistoriaClinica(string idCita);

        [OperationContract]
        Boolean ActualizarHistoriaClinica(CitaDC objCita);


        [OperationContract]
        List<CalendarioDisponibleDC> ObtenerCalendarioDisponible(int? idDentista = null, DateTime? fechaInicio = null);

        [OperationContract]
        Boolean AgregarHorarioDentista(CitaDC objCitaDC);

        [OperationContract]
        List<CalendarioDisponibleDC> ObtenerHorarioDentista(int? idDentista = null, DateTime? fechaInicio = null);

        [OperationContract]
        List<CalendarioDisponibleDC> ObtenerHorarioDetallado(int? idDentista = null, DateTime? fechaInicio = null);

        [OperationContract]
        Boolean EliminarDisponibilidadDentista(CitaDC objCitaDC);

        [OperationContract]
        Boolean EliminarDisponibilidadDia(CitaDC objCitaDC);


        [OperationContract]
        Boolean EliminarHorarioDentistaHora(CitaDC objCitaDC);

        [OperationContract]
        Boolean EliminarHorarioDentistaDia(CitaDC objCitaDC);

    }
    [DataContract]
    [Serializable]
    public class CitaDC
    {
        [DataMember] public int idCita { get; set; }
        [DataMember] public int idPaciente { get; set; }
        [DataMember] public int idDentista { get; set; }
        [DataMember] public DateTime fechaCita { get; set; }
        [DataMember] public TimeSpan horaCita { get; set; }
        [DataMember] public string motivoCita { get; set; }
        [DataMember] public int estado { get; set; }
        [DataMember] public string estado_cadena { get; set; }
        [DataMember] public string nombreEspecialidad { get; set; }
        [DataMember] public string nombreDentista { get; set; }
        [DataMember] public DateTime fecha { get; set; }
        [DataMember] public string descripcion { get; set; }
        [DataMember] public string observaciones { get; set; }
        [DataMember] public string nombreTratamiento { get; set; }
        [DataMember] public string nombrePaciente { get; set; }
        [DataMember] public string apellidoPaciente { get; set; }
        [DataMember] public string dni { get; set; }
        [DataMember] public string correoPaciente { get; set; }
        [DataMember] public string telefonoPaciente { get; set; }
        [DataMember] public DateTime fechaNacimientoPaciente { get; set; }
        [DataMember] public string direccionPaciente { get; set; }
        [DataMember] public int sexo { get; set; }
        [DataMember] public int edadPaciente { get; set; }
        [DataMember] public string sexo_cadena { get; set; }
        [DataMember] public int idTratamiento { get; set; }
        [DataMember] public int idHistoriaClinica { get; set; }
        [DataMember] public string horarioDentista{ get; set; }
        [DataMember] public string diaSemana { get; set; }
        [DataMember] public TimeSpan horarioInicio { get; set; }
        [DataMember] public TimeSpan horarioFin { get; set; }
        [DataMember] public int mes { get; set; }
        [DataMember] public int año { get; set; }

        [DataMember] public string motivo { get; set; }

    }


    [DataContract]
    [Serializable]
    public class CalendarioDisponibleDC
    {
        [DataMember]
        public TimeSpan Hora { get; set; }
        [DataMember]
        public string Lunes { get; set; }
        [DataMember]
        public string Martes { get; set; }
        [DataMember]
        public string Miércoles { get; set; }
        [DataMember]
        public string Jueves { get; set; }
        [DataMember]
        public string Viernes { get; set; }
        [DataMember]
        public string Sábado { get; set; }
        [DataMember]
        public string Domingo { get; set; }
    }

    public class CalendarioResult
    {
        public TimeSpan Hora { get; set; }
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miércoles { get; set; }
        public string Jueves { get; set; }
        public string Viernes { get; set; }
        public string Sábado { get; set; }
        public string Domingo { get; set; }
    }
}