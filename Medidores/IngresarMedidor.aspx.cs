using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MedidoresModel;
using MedidoresModel.DAL;
using MedidoresModel.DTO;


namespace Medidores
{
    public partial class IngresarMedidor : System.Web.UI.Page
    {
        private IMedidorDAL medidorDAL = new MedidorDAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            Page.Validate();
            if (Page.IsValid)
            {
                string id = this.idTxt.Text.Trim();
                string direccion = this.direccionTxt.Text.Trim();
                string detalle = this.detalleTxt.Text.Trim();
                int idTipo = Convert.ToInt32(this.tipoCmb.SelectedValue);
                string tipo = "";

                switch (idTipo)
                {
                    case 0:
                        tipo = "Análogo";
                        break;
                    case 1:
                        tipo = "Digital";
                        break;
                    default:
                        tipo = "";
                        break;
                }

                Medidor medidor = new Medidor()
                {
                    Id = id,
                    Direccion = direccion,
                    Detalle = detalle,
                    IdTipo = idTipo,
                    Tipo = tipo
                };

                medidorDAL.Agregar(medidor);
                Response.Redirect("VerMedidores.aspx");
            }
            
        }

        protected void idValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                string id = args.Value;
                List<Medidor> medidores = medidorDAL.ObtenerMedidores();
                args.IsValid = !medidores.Contains(medidores.Find(m => m.Id == id));
            }
            catch
            {
                args.IsValid = false;
            }
        }

        protected void idLengthValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                string id = args.Value;
                args.IsValid = id.Length == 4;
            }
            catch
            {
                args.IsValid = false;
            }
        }
    }
}