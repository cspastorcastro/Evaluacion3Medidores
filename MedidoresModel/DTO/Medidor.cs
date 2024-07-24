using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Medidor
    {
        private string id;
        private string direccion;
        private string detalle;
        /*
         * 0 - Análogo
         * 1 - Digital
         */
        private int idTipo;
        private string tipo;
        private List<Lectura> lecturas;

        public string Id { get => id; set => id = value; }
        public List<Lectura> Lecturas { get => lecturas; set => lecturas = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public int IdTipo { get => idTipo; set => idTipo = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public override string ToString()
        {
            return Id;
        }

    }
}
