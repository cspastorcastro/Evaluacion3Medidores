using MedidoresModel.DAL;
using MedidoresModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Medidores
{
    public partial class IngresarLectura : System.Web.UI.Page
    {
        private ILecturaDAL lecturasDAL = new LecturaDAL();
        private IMedidorDAL medidoresDAL = new MedidorDAL();

        protected void Page_Load(object sender, EventArgs e)
        {
            // Cargar medidores
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                this.medidorCmb.DataSource = medidores;
                this.medidorCmb.DataTextField = "id";
                this.medidorCmb.DataValueField = "id";
                this.medidorCmb.DataBind();
            }
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            string idMedidor = this.medidorCmb.SelectedItem.Value;
            Medidor medidor = medidores.Find(m => m.Id == idMedidor);

            double consumo = Convert.ToDouble(this.consumoTxt.Text.Trim());

            int dia = this.fechaCal.SelectedDate.Day;
            int mes = this.fechaCal.SelectedDate.Month;
            int year = this.fechaCal.SelectedDate.Year;
            int hora = Convert.ToInt32(this.horaTxt.Text.Trim());
            int minutos = Convert.ToInt32(this.minutosTxt.Text.Trim());
            DateTime fechaLectura = new DateTime(year, mes, dia, hora, minutos, 0);
            string idLectura = Convert.ToString(idMedidor) + "-" + Convert.ToString(fechaLectura);

            Lectura lectura = new Lectura()
            {
                Id = idLectura,
                Consumo = consumo,
                FechaLectura = fechaLectura,
                Medidor = medidor
            };
            lecturasDAL.Agregar(lectura);
            Response.Redirect("VerLecturas.aspx");
        }
    }
}