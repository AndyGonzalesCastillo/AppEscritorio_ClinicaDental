using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Linq;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDentista" en el código y en el archivo de configuración a la vez.
    public class ServicioDentista : IServicioDentista
    {
        public List<DentistaDC> ListarDentistasPorEspecialidad(String idEspecialidad)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();

                var resultado = MiBD.sp_ListarDentistasPorEspecialidadDetallado(Convert.ToInt16(idEspecialidad)).ToList();

                if (resultado == null || resultado.Count == 0)
                {
                    return new List<DentistaDC>();
                }

                List<DentistaDC> listaDentistas = new List<DentistaDC>();

                foreach (var dentista in resultado)
                {
                    listaDentistas.Add(new DentistaDC
                    {
                        dni = dentista.dni,
                        nombres = dentista.nombres,
                        apellidos = dentista.apellidos,
                        telefono = dentista.telefono,
                        correo = dentista.correo,
                        direccion = dentista.direccion,
                        fechaNacimiento = Convert.ToDateTime(dentista.fechaNacimiento),
                        edad = Convert.ToInt16(dentista.edad),
                        sexo = Convert.ToInt16(dentista.sexo),
                        estadoDentista = Convert.ToInt16(dentista.estadoDentista),
                        idDentista = dentista.idDentista,
                        sexo_cadena = (dentista.sexo == 1) ? "Masculino" : "Femenino",
                        estadoDentista_cadena = (dentista.estadoDentista == 1) ? "Activo" : "Inactivo",
                        ApellidoYNombre = dentista.apellidos + ", " + dentista.nombres
                    });
                }
                return listaDentistas;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<DisponibilidadDC> ConsultarDisponibilidadDetallada(String idDentista)
        {
            try
            {
                using (ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities())
                {
                    var resultado = MiBD.sp_ConsultarDisponibilidadDetallada(Convert.ToInt16(idDentista)).ToList();

                    if (resultado == null)
                    {
                        return new List<DisponibilidadDC>();
                    }

                    List<DisponibilidadDC> listaDisponibilidad = new List<DisponibilidadDC>();

                    foreach (var disponibilidad in resultado)
                    {
                        listaDisponibilidad.Add(new DisponibilidadDC
                        {
                            diaSemana = disponibilidad.diaSemana,
                            fecha = Convert.ToDateTime(disponibilidad.fecha),
                            hora = TimeSpan.Parse(disponibilidad.hora.ToString()),
                            estado = Convert.ToInt16(disponibilidad.estado),
                            estado_cadena = (disponibilidad.estado == 1) ? "Disponible" : "No Disponible"

                        });
                    }

                    return listaDisponibilidad;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DentistaDC ConsultarDentista(String idDentista)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();

                var resultado = MiBD.sp_ConsultarDentista(Convert.ToInt16(idDentista)).FirstOrDefault();

                if (resultado == null)
                {
                    return null;
                }

                DentistaDC objDentistaDC = new DentistaDC
                {
                    idDentista = resultado.idDentista,
                    idUsuario = resultado.idUsuario,
                    dni = resultado.dni,
                    nombres = resultado.nombres,
                    apellidos = resultado.apellidos,
                    telefono = resultado.telefono,
                    correo = resultado.correo,
                    direccion = resultado.direccion,
                    fechaNacimiento = Convert.ToDateTime(resultado.fechaNacimiento),
                    sexo = Convert.ToInt16(resultado.sexo),
                    estadoDentistaUsuario = Convert.ToInt16(resultado.estadoUsuario),
                    contraseña = resultado.contraseña,
                    ApellidoYNombre = resultado.apellidos + ", " + resultado.nombres,
                    idEspecialidad = Convert.ToInt16(resultado.especialidad),
                    estadoDentista = Convert.ToInt16(resultado.estadoDentista),
                    

                };

                return objDentistaDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<DentistaDC> ListarDentistas()
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                var resultado = MiBD.sp_ListarDentistas();
                List<DentistaDC> ListarDentistas = new List<DentistaDC>();
                foreach (var item in resultado)
                {
                    DentistaDC objDentistaDC = new DentistaDC
                    {
                        idDentista = item.idDentista,
                        idUsuario = item.idUsuario,
                        dni = item.dni,
                        nombres = item.nombres,
                        apellidos = item.apellidos,
                        telefono = item.telefono,
                        correo = item.correo,
                        direccion = item.direccion,
                        fechaNacimiento = Convert.ToDateTime(item.fechaNacimiento),
                        edad = Convert.ToInt16(item.edad),
                        sexo = Convert.ToInt16(item.sexo),
                        sexo_cadena = (item.sexo == 1) ? "Masculino" : "Femenino",
                        estadoDentista = Convert.ToInt16(item.estadoDentista),
                        estadoDentista_cadena = (item.estadoDentista == 1) ? "Activo" : "Inactivo",
                        estadoDentistaUsuario = Convert.ToInt16(item.estadoUsuario),
                        estadoDentistaUsuario_cadena = (item.estadoUsuario == 1) ? "Activo" : "Inactivo",
                        nombreEspecialidad = item.especialidad,
                        ApellidoYNombre = item.apellidos + ", " + item.nombres
                    };
                    ListarDentistas.Add(objDentistaDC);

                }
                return ListarDentistas;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean AgregarDentista(DentistaDC objDentista)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_AgregarDentista(
                    objDentista.dni,
                    objDentista.correo,
                    objDentista.contraseña,
                    objDentista.nombres,
                    objDentista.apellidos,
                    objDentista.telefono,
                    objDentista.fechaNacimiento,
                    objDentista.direccion,
                    objDentista.sexo,
                    objDentista.idEspecialidad,
                    objDentista.estado
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

        public Boolean ActualizarDentista(DentistaDC objDentista)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_ActualizarDentista(
                    objDentista.idDentista,
                    objDentista.dni,
                    objDentista.correo,
                    objDentista.contraseña,
                    objDentista.nombres,
                    objDentista.apellidos,
                    objDentista.telefono,
                    objDentista.fechaNacimiento,
                    objDentista.direccion,
                    objDentista.sexo,
                    objDentista.estado,
                    objDentista.idEspecialidad
                    );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public Boolean EliminarDentista(String idDentista)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_EliminarDentista(Convert.ToInt16(idDentista));
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