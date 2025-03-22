using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioPaciente" en el código y en el archivo de configuración a la vez.
    public class ServicioPaciente : IServicioPaciente
    {
        public PacienteDC ConsultarPaciente(String idPaciente)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();

                var resultado = MiBD.sp_ConsultarPaciente(Convert.ToInt16(idPaciente)).FirstOrDefault();

                if (resultado == null)
                {
                    return null;
                }

                PacienteDC objPacienteDC = new PacienteDC
                {
                    idPaciente = resultado.idPaciente,
                    idUsuario = resultado.idUsuario,
                    dni = resultado.dni,
                    nombres = resultado.nombres,
                    apellidos = resultado.apellidos,
                    telefono = resultado.telefono,
                    correo = resultado.correo,
                    direccion = resultado.direccion,
                    fechaNacimiento = Convert.ToDateTime(resultado.fechaNacimiento),
                    sexo = Convert.ToInt16(resultado.sexo),
                    estado = Convert.ToInt16(resultado.estado),
                    contraseña = resultado.contraseña,
                    ApellidoYNombre = resultado.apellidos + ", " + resultado.nombres
                };

                return objPacienteDC;

            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }



        public List<PacienteDC> ListarPacientes()
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                var resultado = MiBD.sp_ListarPacientes();
                List<PacienteDC> ListaPacientes = new List<PacienteDC>();

                foreach (var item in resultado)
                {
                    PacienteDC objPacienteDC = new PacienteDC
                    {
                        idPaciente = item.idPaciente,
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
                        estado = Convert.ToInt16(item.estado),
                        estado_cadena = (item.estado == 1) ? "Activo" : "Inactivo"

                    };
                    ListaPacientes.Add(objPacienteDC);
                }
                return ListaPacientes;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean agregarPaciente(PacienteDC objPacienteDC)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_AgregarPaciente(
                    objPacienteDC.dni,
                    objPacienteDC.correo,
                    objPacienteDC.contraseña,
                    objPacienteDC.nombres,
                    objPacienteDC.apellidos,
                    objPacienteDC.telefono,
                    objPacienteDC.fechaNacimiento,
                    objPacienteDC.direccion,
                    objPacienteDC.sexo,
                    objPacienteDC.estado
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

        public Boolean ActualizarPaciente(PacienteDC objPacienteDC)
        {
            try
            {

                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_ActualizarPaciente(
                    objPacienteDC.idPaciente,
                    objPacienteDC.dni,
                    objPacienteDC.correo,
                    objPacienteDC.contraseña,
                    objPacienteDC.nombres,
                    objPacienteDC.apellidos,
                    objPacienteDC.telefono,
                    objPacienteDC.fechaNacimiento,
                    objPacienteDC.direccion,
                    objPacienteDC.sexo,
                    objPacienteDC.estado
                    );
                MiBD.SaveChanges();
                return true;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean EliminarPaciente(String idPaciente)
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                MiBD.sp_EliminarPaciente(Convert.ToInt16(idPaciente));
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