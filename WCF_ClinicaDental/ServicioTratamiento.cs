using System;
using System.Collections.Generic;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_ClinicaDental
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTratamiento" en el código y en el archivo de configuración a la vez.
    public class ServicioTratamiento : IServicioTratamiento
    {
        public List<TratamientoDC> ListarTratamientos()
        {
            try
            {
                ClinicaDental_DBEntities MiBD = new ClinicaDental_DBEntities();
                var resultado = MiBD.sp_ListarTratamientos();
                List<TratamientoDC> ListaTratamientos = new List<TratamientoDC>();
                foreach (var item in resultado)
                {
                    TratamientoDC objTratamientoDC = new TratamientoDC
                    {
                        idTratamiento = item.idTratamiento,
                        nombre = item.nombre,
                        descripcion = item.descripcion,
                        precio = Convert.ToDecimal(item.precio)

                    };
                    ListaTratamientos.Add(objTratamientoDC);
                }
                return ListaTratamientos;
            }
            catch (EntityException ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
