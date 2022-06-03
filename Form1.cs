using ControlUsuario.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlUsuario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //poner control de usuario en publico
            //se hace en propiedades, modifiquers 
            userControl11.txtNombreForm.Text = "Hola";

            
        }

        List<Coche> listacoches = new Controladores.ControladorCoches().recuperarCoches();
        private void button2_Click(object sender, EventArgs e)
        {
            

        }


        
        private void Form1_Load(object sender, EventArgs e)
        {
            //particularidad del load
            listBox1.DataSource = listacoches;
            listBox1.DisplayMember = "matricula";//campo que se vee en la ventana
                                                 // listBox1.ValueMember = "matricula";
                                                 //mejor poner en load en otro metodo

            listBox1.ValueMember = "modelo";


            //evento por codigo 
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;//tabular y te crea el evento
            //+= para añadir evento
            //-= para borrar el evento

            //con los combo box es igual
            

      
        }

        

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        { 
           // textBox1.Text = listBox1.SelectedValue.ToString();
            //en caja texto poner la marca al selecionar
            //mejor de esta manera
            textBox1.Text = ((Coche)listBox1.SelectedItem).modelo;


           //selectedIndex - posicion
           //selectedItem ** objeto completo
           //selectedValue --propiedad selecionada
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //cargar imagen en picture box

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file";

          

            if (dialog.ShowDialog() == DialogResult.OK)
            {
               string ruta = dialog.FileName;
                

                pictureBox1.Image= Image.FromFile(ruta);

                textBox2.Text = ruta;

                //si queremos guardar
                pictureBox1.Tag = ruta;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string matricula = txtMatricula.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string color = txtColor.Text;
            int cilindrada = Convert.ToInt32(txtCilindrada.Text);


           Coche  coche2 = new Coche(matricula, marca, modelo, color, cilindrada);

            if (new Controladores.ControladorCoches().guardarCoche(coche2))
            {
                MessageBox.Show("Coche guardado");

            }
            else {
                MessageBox.Show("error al guardar");
                    
            }
           

           

        }


        //prueba unitaria a la solucion agregar un nuevo proyecto, de tipo prueba unitaria
    }
}
