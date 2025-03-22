using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    public class ServicioCita : IServicioCita
    {
        public Boolean AgregarCita(CitaDC objCitaDC)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_AgregarCita(
                    objCitaDC.idPaciente,
                    objCitaDC.idDentista,
                    objCitaDC.fechaCita,
                    objCitaDC.horaCita,
                    objCitaDC.motivoCita

                    );
                MiBD.SaveChanges();
                return true;


            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean AgregarHorarioDentista(CitaDC objCitaDC)
        {
            try
            {
               ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_AgregarHorarioDentista(
                    objCitaDC.idDentista,
                    objCitaDC.diaSemana,
                    objCitaDC.horarioInicio,
                    objCitaDC.horarioFin,
                    objCitaDC.mes,
                    objCitaDC.año

                    );
                MiBD.SaveChanges();
                return true;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }

        }


        public List<CitaDC> ListarCitasPaciente(String idCita)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                var resultado = MiBD.sp_ConsultarCitas(Convert.ToInt16(idCita)).ToList();

                if (resultado == null || resultado.Count == 0)
                {
                    return new List<CitaDC>();
                }
                List<CitaDC> listaCitasPaciente = new List<CitaDC>();

                foreach (var item in resultado)
                {
                    CitaDC objCitaDC = new CitaDC
                    {
                        idCita = item.idCita,
                        fechaCita = Convert.ToDateTime(item.fechaCita),
                        horaCita = TimeSpan.Parse(item.hora.ToString()),
                        nombreDentista = item.nombreDentista,
                        nombreEspecialidad = item.especialidadDentista,
                        motivoCita = item.motivoCita,
                        estado = Convert.ToInt16(item.estado),
                        estado_cadena = (item.estado == 1) ? "Reservado" : (item.estado == 0) ? "Cancelado" : "Completado"
                    };
                    listaCitasPaciente.Add(objCitaDC);
                }
                return listaCitasPaciente;


            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean CancelarCita(String idCita)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_CancelarCita(Convert.ToInt16(idCita));
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<CitaDC> ListarHistoriaClinica(String idPaciente)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();

                var resultado = MiBD.sp_ConsultarHistoriaClinica(Convert.ToInt16(idPaciente)).ToList();

                if (resultado == null || resultado.Count == 0)
                {
                    return new List<CitaDC>();
                }

                List<CitaDC> listaHistoriaClinica = new List<CitaDC>();

                foreach (var item in resultado)
                {
                    listaHistoriaClinica.Add(new CitaDC
                    {
                        fecha = Convert.ToDateTime(item.fecha),
                        descripcion = item.descripcion,
                        observaciones = item.observaciones,
                        nombreTratamiento = item.NombreTratamiento,
                        nombreDentista = item.NombreDentista,
                        fechaCita = Convert.ToDateTime(item.fechaCita),
                        horaCita = TimeSpan.Parse(item.horaCita.ToString()),
                        motivoCita = item.motivoCita,
                        estado = Convert.ToInt16(item.estado),
                        estado_cadena = (item.estado == 1) ? "Reservado" : (item.estado == 0) ? "Cancelado" : "Completado"
                    });
                }

                return listaHistoriaClinica;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al consultar la historia clínica: " + ex.Message);
            }
        }

        public List<CitaDC> ListarCitasPorDentistaYFecha(String idDentista, DateTime fechaInicio, DateTime? fechaFin = null)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                var resultado = MiBD.sp_ListarCitasPorDentistaYFecha(Convert.ToInt16(idDentista), fechaInicio, fechaFin).ToList();

                List<CitaDC> listaCitas = new List<CitaDC>();

                foreach (var item in resultado)
                {
                    listaCitas.Add(new CitaDC
                    {
                        idCita = item.idCita,
                        fechaCita = Convert.ToDateTime(item.fechaCita),
                        horaCita = TimeSpan.Parse(item.horaCita.ToString()),
                        estado = Convert.ToInt16(item.estado),
                        estado_cadena = (item.estado == 1) ? "Reservado" : (item.estado == 0) ? "Cancelado" : "Completado",
                        idPaciente = Convert.ToInt16(item.idPaciente),
                        nombrePaciente = item.PacienteNombres,
                        apellidoPaciente = item.PacienteApellidos,
                        dni = item.PacienteDNI,
                        correoPaciente = item.PacienteCorreo,
                        telefonoPaciente = item.PacienteTelefono,
                        fechaNacimientoPaciente = Convert.ToDateTime(item.PacienteFechaNacimiento),
                        direccionPaciente = item.PacienteDireccion,
                        sexo = Convert.ToInt16(item.PacienteSexo),
                        edadPaciente = Convert.ToInt16(item.PacienteEdad),
                        sexo_cadena = (item.PacienteSexo == 1) ? "Masculino" : "Femenino",

                    });
                }

                return listaCitas;
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al listar citas: " + ex.Message);
            }
        }


        public bool AgregarHistoriaClinica(CitaDC CitaDC)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    bool existeHistoria = MiBD.Historia.Any(h => h.idCita == CitaDC.idCita);

                    if (existeHistoria)
                    {
                        throw new Exception("El historial clínico ya ha sido registrado para esta cita.");
                    }

                    MiBD.sp_AgregarHistoriaClinica(
                        CitaDC.idPaciente,
                        CitaDC.idDentista,
                        CitaDC.idTratamiento,
                        CitaDC.idCita,
                        CitaDC.descripcion,
                        CitaDC.observaciones
                    );

                    MiBD.SaveChanges();
                    return true;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al agregar la historia clínica: " + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
        }


        public bool ActualizarEstadoCita(int idCita, int estado)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    MiBD.sp_ActualizarEstadoCita(idCita, estado);
                    MiBD.SaveChanges();
                    return true;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al actualizar el estado de la cita: " + ex.Message);
            }
        }

        public bool ExisteHistoriaClinica(int idCita)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    return MiBD.Historia.Any(h => h.idCita == idCita);
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al verificar la existencia de la historia clínica: " + ex.Message);
            }
        }

        public CitaDC ConsultarHistoriaClinica(string idCita)
        {
            try
            {
                ClinicaDental_DBEntities clinicaDental_DBEntities = new ClinicaDental_DBEntities();
                var resultado = clinicaDental_DBEntities.sp_ConsultarHistoriaClinicaPorCita(Convert.ToInt16(idCita)).FirstOrDefault();

                if (resultado == null)
                {
                    return null;
                }
                CitaDC objCitaDC = new CitaDC
                {
                    idHistoriaClinica = Convert.ToInt16(resultado.idHistoria),
                    idPaciente = Convert.ToInt16(resultado.idPaciente),
                    idDentista = Convert.ToInt16(resultado.idDentista),
                    idTratamiento = Convert.ToInt16(resultado.idTratamiento),
                    idCita = Convert.ToInt16(resultado.idCita),
                    descripcion = resultado.descripcion,
                    observaciones = resultado.observaciones,
                    fecha = Convert.ToDateTime(resultado.fecha)

                };
                return objCitaDC;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarHistoriaClinica(CitaDC objCita)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_ActualizarHistoriaClinica(
                    objCita.idHistoriaClinica,
                    objCita.descripcion,
                    objCita.observaciones,
                    objCita.idTratamiento
                    );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public List<CalendarioDisponibleDC> ObtenerCalendarioDisponible(int? idDentista = null, DateTime? fechaInicio = null)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    var resultado = MiBD.Database.SqlQuery<CalendarioResult>(
                        "EXEC sp_ObtenerCalendarioDisponible @idDentista, @FechaInicio",
                        new SqlParameter("@idDentista", (object)idDentista ?? DBNull.Value),
                        new SqlParameter("@FechaInicio", (object)fechaInicio ?? DBNull.Value)
                    ).ToList();

                    return resultado.Select(r => new CalendarioDisponibleDC
                    {
                        Hora = r.Hora,
                        Lunes = r.Lunes,
                        Martes = r.Martes,
                        Miércoles = r.Miércoles,
                        Jueves = r.Jueves,
                        Viernes = r.Viernes,
                        Sábado = r.Sábado,
                        Domingo = r.Domingo
                    }).ToList();
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al obtener el calendario disponible: " + ex.Message);
            }
        }

        public List<CalendarioDisponibleDC> ObtenerHorarioDentista(int? idDentista = null, DateTime? fechaInicio = null)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    var resultado = MiBD.Database.SqlQuery<CalendarioResult>(
                        "EXEC sp_ObtenerHorarioDentista @idDentista, @FechaInicio",
                        new SqlParameter("@idDentista", (object)idDentista ?? DBNull.Value),
                        new SqlParameter("@FechaInicio", (object)fechaInicio ?? DBNull.Value)
                    ).ToList();

                    return resultado.Select(r => new CalendarioDisponibleDC
                    {
                        Hora = r.Hora,
                        Lunes = r.Lunes,
                        Martes = r.Martes,
                        Miércoles = r.Miércoles,
                        Jueves = r.Jueves,
                        Viernes = r.Viernes,
                        Sábado = r.Sábado,
                        Domingo = r.Domingo
                    }).ToList();
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al obtener el calendario disponible: " + ex.Message);
            }
        }

        public List<CalendarioDisponibleDC> ObtenerHorarioDetallado(int? idDentista = null, DateTime? fechaInicio = null)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    var resultado = MiBD.Database.SqlQuery<CalendarioResult>(
                        "EXEC sp_ObtenerHorarioDetallado @idDentista, @FechaInicio",
                        new SqlParameter("@idDentista", (object)idDentista ?? DBNull.Value),
                        new SqlParameter("@FechaInicio", (object)fechaInicio ?? DBNull.Value)
                    ).ToList();

                    return resultado.Select(r => new CalendarioDisponibleDC
                    {
                        Hora = r.Hora,
                        Lunes = r.Lunes,
                        Martes = r.Martes,
                        Miércoles = r.Miércoles,
                        Jueves = r.Jueves,
                        Viernes = r.Viernes,
                        Sábado = r.Sábado,
                        Domingo = r.Domingo
                    }).ToList();
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error al obtener el calendario disponible: " + ex.Message);
            }
        }

        public Boolean EliminarDisponibilidadDentista(CitaDC objCitaDC)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_EliminarDisponibilidadDentista(
                    objCitaDC.idDentista,
                    objCitaDC.fechaCita,
                    objCitaDC.horaCita,
                    objCitaDC.motivo 
                );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
                return false;
            }
        }

        public Boolean EliminarDisponibilidadDia(CitaDC objCitaDC)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_EliminarDisponibilidadDia(
                    objCitaDC.idDentista,
                    objCitaDC.fechaCita,
                    objCitaDC.motivo 
                );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarHorarioDentistaHora(CitaDC objCitaDC)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_EliminarHorarioDentistaHora(
                    objCitaDC.idDentista,
                    objCitaDC.fechaCita,
                    objCitaDC.horaCita 
                );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarHorarioDentistaDia(CitaDC objCitaDC)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_EliminarHorarioDentistaDia(
                    objCitaDC.idDentista,
                    objCitaDC.fechaCita
                );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}

