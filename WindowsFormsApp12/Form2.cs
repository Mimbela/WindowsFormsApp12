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
    public partial class Form2 : Form
    {
        Form1 formulario1;
        public Form2()
        {
            
            InitializeComponent();
        }
        //metodo que recoge datos
        public void Convertir (string nomb , string apello)
        {
            string nombre = nomb.ToLower();
            string apellido = apello.ToLower();

            textBox2.Text = string.Format("{0} - {1}", apellido, nombre);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("quieres dejarlo como estaba ?", "conversion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (resultado.Equals(DialogResult.OK)) //si el usuario dice que si
            {

                formulario1 = new Form1();
                formulario1.Convertir(textBox2.Text);
                Hide();
                formulario1.Show();
            }
            else
            {
                Close();
            }
        }
    }
}
//Ejercicio Propuesto(Anexo 2): 
////Aplicación formada por dos formularios Windows:
////1º : Dos cajas de texto, dos label y un botón.Recogerá el nombre y apellido en MAYUSCULAS. El botón “Aceptar” mandará la 
//información al segundo formulario que la convertirá en MINÚSCULAS, pero previamente preguntará al usuario si está de acuerdo con
//    la conversión. Si es afirmativo mandar al segundo formulario.Si es negativo cerrar la aplicación.
////2º : Una caja de texto, una label y un botón.Recogerá en MINÚSCULAS concatenados el nombre y apellido del primer formulario.
//Si el usuario está de acuerdo, el botón ‘Aceptar’ devolverá la información al primer formulario en las condiciones originales, 
//es decir, en MAYUSCULAS y el nombre y el apellido en sus respectivas cajas.
