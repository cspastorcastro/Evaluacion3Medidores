using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresModel.DTO
{
    public class Lectura
    {
        private string id;
        private DateTime fechaLectura;
        private double consumo;
        private Medidor medidor;

        public string Id { get => id; set => id = value; }
        public DateTime FechaLectura { get => fechaLectura; set => fechaLectura = value; }
        public double Consumo { get => consumo; set => consumo = value; }
        public Medidor Medidor { get => medidor; set => medidor = value; }
    }
}
