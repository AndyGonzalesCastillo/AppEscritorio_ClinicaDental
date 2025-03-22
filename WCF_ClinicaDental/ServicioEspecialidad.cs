using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEspecialidad" en el código y en el archivo de configuración a la vez.
    public class ServicioEspecialidad : IServicioEspecialidad
    {
        public List<EspecialidadDC> ListarEspecialidades()
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                var resultado = MiBD.sp_ListarEspecialidades();
                List<EspecialidadDC> ListaEspecialidades = new List<EspecialidadDC>();
                foreach (var item in resultado)
                {
                    EspecialidadDC objEspecialidadDC = new EspecialidadDC
                    {
                        idEspecialidad = item.idEspecialidad,
                        nombre = item.nombre,
                        descripcion = item.descripcion
                    };
                    ListaEspecialidades.Add(objEspecialidadDC);
                }
                return ListaEspecialidades;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
