using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen_Final
{
    public partial class Eliminar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Automovil> a = Leer();

                DropDownList1.DataSource = null;
                DropDownList1.DataValueField = "NumeroP";
                DropDownList1.DataTextField = "Modelo";
                DropDownList1.DataSource = a;
                DropDownList1.DataBind();
            }
        }

        private List<Automovil> Leer()
        {
            List<Automovil> lista = new List<Automovil>();
            string archivo = Server.MapPath("Carros.json");
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();
            lista = JsonConvert.DeserializeObject<List<Automovil>>(json);

            return lista;
        }

        private void Grabar(List<Automovil> e)
        {
            string json = JsonConvert.SerializeObject(e);
            string archivo = Server.MapPath("Carros.json");
            System.IO.File.WriteAllText(archivo, json);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Automovil> a = Leer(); int ind = 0;

            for (int i = 0; i < a.Count; i++) if (DropDownList1.SelectedValue.Equals(a[i].NumeroP)) ind = i;

            a.RemoveAt(ind); Grabar(a); Response.Write("<script>alert('Automovil eliminado exitosamente')</script>");
        }
    }
}