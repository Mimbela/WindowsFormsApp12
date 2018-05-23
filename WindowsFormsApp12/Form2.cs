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
