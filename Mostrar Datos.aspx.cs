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
    public partial class Mostrar_Datos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Automovil> a = Leer();

            GridView1.DataSource = null;
            GridView1.DataSource = a;
            GridView1.DataBind();
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
    }
}