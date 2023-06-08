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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            List<Automovil> a = Leer();

            if(a == null) a = new List<Automovil>();

            Automovil aa = new Automovil();
            aa.NumeroP = TextBox1.Text; aa.Marca = TextBox2.Text; aa.Modelo = TextBox3.Text;
            aa.NPuertas = TextBox4.Text; aa.NPasajeros = Convert.ToInt32(TextBox5.Text);

            a.Add(aa); Grabar(a); Response.Write("<script>alert('Automovil registrado exitosamente')</script>");
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = "";
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
    }
}