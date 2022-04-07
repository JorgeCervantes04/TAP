using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TAPU2_Ejemplo1
{
    public partial class Ejecucion : Form
    {
        Button button = new Button();
        public Ejecucion()
        {
            InitializeComponent();
        }
        // crear un control en tiempo de ejecucion 
        private void btnCrearControl_Click(object sender, EventArgs e)
        {
            //crear controles, en tiempo de ejecucion
            //instanciar una clase de tipo Button (crear un objeto de una clase)
           
            //caracteristicas del boton
            button.Name = "btn1";
            button.Text = "soy el nuevo";
            //Top: es para dar posicion de arriba hacia abajo
            button.Top = this.Height / 2;
            //left : es para la posicion de izquierda a derecha
            button.Left = this.Width / 2;
            // tamaño del boton
            button.Height = 50;
            button.Width = 90;
            //Diseño del boton
            button.FlatStyle = FlatStyle.Flat;
            //este control hay quw ponerlo en el form 1
            this.Controls.Add(button);
            //asociar el button a un evento
            //se hace aqui porquq el boton esta creado en el tiempo de ejecucion
            button.Click += new EventHandler(btn1_click);
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            //con esto se quita el boton o mejor dicho se elimina 
            this.Controls.Remove(button);
        }
        // evento para el boton creado en tiempoi de ejecucion
        private void btn1_click(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
            MessageBox.Show("evento creado en tiempo de ejecucion");
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            string speech = string.Format("Control" + ((TextBox)sender).Name);

        }
    }
}
