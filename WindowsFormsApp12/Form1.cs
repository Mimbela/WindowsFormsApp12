using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
    public partial class Form1 : Form
    {
        Form2 formulario2;
        public Form1()
        {
            InitializeComponent();
            formulario2 = new Form2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("quieres convertir ?", "conversion", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);

            //quiero saber lo que el usuario ha respondido
            if (resultado.Equals(DialogResult.OK)) //si el usuario dice que si
            {
                //instanciamos formulario 2
               
                //llamo al metodo creado en form1
                formulario2.Convertir(textBox1.Text, textBox2.Text);
                //oculto el formulario
                Hide();
                formulario2.Show();
            }
            else
            {
                Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void Convertir(string cadena)
        {
            string[] partes = cadena.Split(',');
            textBox1.Text = partes[0].ToUpper();
            textBox2.Text = partes[1].ToUpper();

            
        }
    }
}


//Ejercicio Propuesto(Anexo 2): 
//Aplicación formada por dos formularios Windows:
////1º : Dos cajas de texto, dos label y un botón.Recogerá el nombre y apellido en MAYUSCULAS. El botón “Aceptar” mandará la información al segundo formulario 
//que la convertirá en MINÚSCULAS, pero previamente preguntará al usuario si está de acuerdo con la conversión. Si es afirmativo mandar al segundo formulario.Si es 
//    negativo cerrar la aplicación.
////2º : Una caja de texto, una label y un botón.Recogerá en MINÚSCULAS concatenados el nombre y apellido del primer formulario.Si el usuario está de acuerdo,
//el botón ‘Aceptar’ devolverá la información al primer formulario en las condiciones originales, es decir, en MAYUSCULAS y el nombre y el apellido en sus respectivas cajas.
