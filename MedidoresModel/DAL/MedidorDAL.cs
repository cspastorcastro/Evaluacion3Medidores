using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class MedidorDAL : IMedidorDAL
    {
        private static List<Medidor> medidores = new List<Medidor>();

        public void Agregar(Medidor medidor)
        {
            medidores.Add(medidor);
        }

        public void Eliminar(string id)
        {
            Medidor paraEliminar = medidores.Find(m => m.Id == id);
            medidores.Remove(paraEliminar);
        }

        public List<Medidor> Filtrar(int idTipo)
        {
            return medidores.FindAll(m => m.IdTipo == idTipo);
        }

        public List<Lectura> ObtenerLecturas(string idMedidor)
        {
            return medidores.Find(m => m.Id == idMedidor).Lecturas;
        }

        public List<Medidor> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
