using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pjPromedioNotasMemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Objeto de la clase promedio
            Promedio objP = new Promedio(); //con la palabra "new" se hace una copia de la clase, en este caso "Promedio"

            //Enviand valores a los atributos
            objP.alumno = txtNombre.Text;
            objP.nota1 = int.Parse(txtNota1.Text);
            objP.nota2 = int.Parse(txtNota2.Text);
            objP.nota3 = int.Parse(txtNota3.Text);
            objP.nota4 = int.Parse(txtNota4.Text);
           
            //Implementación de los valores
            lblPromedio.Text = objP.CalcularPromedio().ToString();
            lblBaja.Text = objP.MasBaja().ToString();
            lblCondicion.Text = objP.AsignaCondicion();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
          
        }
    }
}
