using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DAL
{
    public class LecturaDAL : ILecturaDAL
    {
        private static List<Lectura> lecturas = new List<Lectura>();
        public void Agregar(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public void Eliminar(string id)
        {
            Lectura paraEliminar = lecturas.Find(l => l.Id == id);
            lecturas.Remove(paraEliminar);
        }

        public List<Lectura> Filtrar(string idMedidor)
        {
            return lecturas.FindAll(l => l.Medidor.Id == idMedidor);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }
    }
}
