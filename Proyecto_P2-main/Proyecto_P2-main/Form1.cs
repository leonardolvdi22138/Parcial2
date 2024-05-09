using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persona_herencia
{
    //LEONARDO LOPEZ VILLEGAS DI22138
    //UNIVERSIDAD DASC
    //INTENTO 1 
    // FECHA : 08/05/2024
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TUS DATOS HAN SIDO CORRECTAMENTE GUARDADOS"); //MESSAGE.BOX.SHOW se utiliza
                                                                           //para mostrar información importante al usuario,
                                                                           //como mensajes de error, advertencias o notificaciones de éxito.
            // esto se hace de tarea todos los valores
            // deben de almacenarse en su
            // caja de memoria correspondiente
            // usando la clase hija que corresponda
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear(); //LIMPIA LOS TEXTOS
            textBox6.Clear();
            // se hace de tarea
            // debe de borrar las cajas de texto
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // se hace de tarea
            // debe de terminar la ejecucion de la interfaz  //EXIT,SALE DE LA APLICACION
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }    
}
