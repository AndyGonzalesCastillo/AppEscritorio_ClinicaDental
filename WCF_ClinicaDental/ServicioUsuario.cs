using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioUsuario" en el código y en el archivo de configuración a la vez.
    public class ServicioUsuario : IServicioUsuario
    {
        public UsuarioDC Login(string dni, string contraseña)
        {
            try
            {
                using (var MiBD = new ClinicaDental_DBEntities())
                {
                    var usuario = MiBD.Usuario.FirstOrDefault(u => u.dni == dni && u.contraseña == contraseña);

                    if (usuario != null && (usuario.rol == "Recepcionista" || usuario.rol == "Admin" || usuario.rol == "Dentista"))
                    {
                        var usuarioDC = new UsuarioDC
                        {
                            idUsuario = usuario.idUsuario,
                            dni = usuario.dni,
                            rol = usuario.rol,
                            nombres = usuario.nombres,
                            apellidos = usuario.apellidos
                        };

                        if (usuario.rol == "Dentista")
                        {
                            var dentista = MiBD.Dentista.FirstOrDefault(d => d.idUsuario == usuario.idUsuario);
                            if (dentista != null)
                            {
                                usuarioDC.idDentista = dentista.idDentista;
                                usuarioDC.especialidad = MiBD.Especialidad.FirstOrDefault(e => e.idEspecialidad == dentista.especialidad)?.nombre;
                            }
                        }

                        return usuarioDC;
                    }
                    return null;
                }
            }
            catch (EntityException ex)
            {
                throw new Exception("Error en el servicio de login: " + ex.Message);
            }
        }



    }
}