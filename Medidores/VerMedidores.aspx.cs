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
    public partial class VerMedidores : System.Web.UI.Page
    {
        private IMedidorDAL medidoresDAL = new MedidorDAL();
        static bool filtrado = false;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarGrilla();
            }
        }

        protected void tipoCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idTipo = Convert.ToInt32(this.tipoCmb.SelectedItem.Value);
            if (idTipo != -1)
            {
                filtrado = true;
                List<Medidor> filtrada = medidoresDAL.Filtrar(idTipo);
                CargarGrilla(filtrada);
                
            }
            else
            {
                filtrado = false;
                CargarGrilla();
            }
        }

        protected void GrillaMedidores_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "eliminar")
            {
                string id = Convert.ToString(e.CommandArgument);
                medidoresDAL.Eliminar(id);
                if (!filtrado)
                {
                    CargarGrilla();
                }
                else
                {
                    int idTipo = Convert.ToInt32(this.tipoCmb.SelectedItem.Value);
                    List<Medidor> filtrada = medidoresDAL.Filtrar(idTipo);
                    CargarGrilla(filtrada);
                }
                
            }
        }

        private void CargarGrilla()
        {
            List<Medidor> medidores = medidoresDAL.ObtenerMedidores();
            this.grillaMedidores.DataSource = medidores;
            this.grillaMedidores.DataBind();
        }

        private void CargarGrilla(List<Medidor> filtrada)
        {
            this.grillaMedidores.DataSource = filtrada;
            this.grillaMedidores.DataBind();
        }
    }
}