using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MI_PRIMER_PROYECTO.TROLOLO
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int sumando;
            int sumador;
            int suma;
            sumando = Convert.ToInt32(TextBox1.Text);
            sumador = Convert.ToInt32(TextBox2.Text);
            suma = sumando + sumador;
            TextBox3.Text = Convert.ToString(suma);




        }
    }
}