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
    public partial class VerLecturas : System.Web.UI.Page
    {
        private ILecturaDAL lecturasDAL = new LecturaDAL();
        private IMedidorDAL medidoresDAL = new MedidorDAL();
        static bool filtrado = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
                Medidor dummy = new Medidor()
                {
                    Id = "Todos",
                };
                List<Medidor> medidoresComboBox = new List<Medidor>(medidores);
                medidoresComboBox.Insert(0, dummy);
                this.medidorCmb.DataSource = medidoresComboBox;
                this.medidorCmb.DataTextField = "id";
                this.medidorCmb.DataValueField = "id";
                this.medidorCmb.DataBind();

                CargarGrilla();
            }
        }


        private void CargarGrilla()
        {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLectura.DataSource = lecturas;
            this.grillaLectura.DataBind();
        }

        private void CargarGrilla(List<Lectura> filtrada)
        {
            this.grillaLectura.DataSource = filtrada;
            this.grillaLectura.DataBind();
        }

        protected void medidorCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idMedidor = this.medidorCmb.SelectedItem.Value;
            if (idMedidor != "Todos")
            {
                filtrado = true;
                List<Lectura> filtrada = lecturasDAL.Filtrar(idMedidor);
                CargarGrilla(filtrada);
            }
            else
            {
                filtrado = false;
                CargarGrilla();
            }
        }

        protected void grillaLectura_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string id = Convert.ToString(e.CommandArgument);
                lecturasDAL.Eliminar(id);
                if (!filtrado)
                {
                    CargarGrilla();
                }
                else
                {
                    string idMedidor = this.medidorCmb.SelectedItem.Value;
                    List<Lectura> filtrada = lecturasDAL.Filtrar(idMedidor);
                    CargarGrilla(filtrada);
                }

            }
        }
    }
}