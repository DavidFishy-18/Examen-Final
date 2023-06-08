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
    public partial class Actualizar : System.Web.UI.Page
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

            a[ind].NumeroP = TextBox1.Text; a[ind].Marca = TextBox2.Text; a[ind].Modelo = TextBox3.Text;
            a[ind].NPuertas = TextBox4.Text; a[ind].NPasajeros = Convert.ToInt32(TextBox5.Text);

            Grabar(a); Response.Write("<script>alert('Datos actualizados exitosamente')</script>");
            TextBox1.Text = ""; TextBox2.Text = ""; TextBox3.Text = ""; TextBox4.Text = ""; TextBox5.Text = "";
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Automovil> a = Leer(); int ind = 0;

            for (int i = 0; i < a.Count; i++) if (DropDownList1.SelectedValue.Equals(a[i].NumeroP)) ind = i;

            TextBox1.Text = a[ind].NumeroP; TextBox2.Text = a[ind].Marca; TextBox3.Text = a[ind].Modelo;
            TextBox4.Text = a[ind].NPuertas; TextBox5.Text = a[ind].NPasajeros.ToString();
        }
    }
}