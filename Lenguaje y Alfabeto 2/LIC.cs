using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElementosC;
using CreacionValidacionCadenas;

namespace Lenguaje_y_Alfabeto_2
{
	public partial class LIC : Form
	{
		Cadena cadena = new Cadena();

		public LIC()
		{
			InitializeComponent();
		}
		private void Nom_KeyPress(object sender, KeyPressEventArgs e)
        {
			if((e.KeyChar >= 33 && e.KeyChar<= 96) || (e.KeyChar >=123 && e.KeyChar <= 255))
			{
				MessageBox.Show("Solo se aceptan letras en minusculas y sin acento", "ATENCION", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				e.Handled = true;
				return;
			}
			if(e.KeyChar == Convert.ToChar(Keys.Enter))
			{
				Mat.Focus();	
			}
        }

        private void Mat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
			else
			{
				if (e.KeyChar == Convert.ToChar(Keys.Enter))
				{
					CadenaValidar.Focus();
                }
			}

			string LongN = Nom.Text;
			int LN = LongN.Length;

            if (LN < 15) //Validar que escriba nombre completo
            {
                MessageBox.Show("Para continuar, verifique que el nombre debe contener más de 15 letras", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

		private void CadenaValidar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BotonValidar.Focus();
            }

            string LongM = Mat.Text;
            int LM = LongM.Length;

            if (LM < 3) //Validar que escriba nombre completo
            {
                MessageBox.Show("Para continuar, verifique la cantidad de digitos de su matricula, debe ser mayor de 3 digitos", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void Boton_Click(object sender, EventArgs e)
        {
			string CadenaV = CadenaValidar.Text; //Guardo la cadena que escribi
			
			string Nombre = Nom.Text; //Guardo lo que escribi en nombre en la variable Nombre
			string Matricula = Mat.Text; //Guardo lo que escribi en matricula en la variable Matricula

			string w = cadena.InAp(Nombre);
			string wMALO= cadena.InApMALO(w);
			string j = cadena.PrimerN(Nombre);
			string i = cadena.Matricula(Matricula);

			//ESTA PARTE SI ALGUIEN LA PUEDE HACER, ES PARA QUE AL DAR CLICK
			// AL BOTON 'VALIDAR CADENA' MUESTRE UN MENSAJE DE AVISO, NO ME SALIO PIPIPIPIPI PE CAUSA
			/*int LN = Nombre.Length;
			int LM = Matricula.Length;

			if(LN < 15 && LM < 3)
			{
				MessageBox.Show("Test");*/
			
			/* 
			 * 
			 * Las siguientes clases se haran en el archvio Cadenas.cs, dentro de la carpeta Cadenas
	
			  1.- Crear una clase donde genere cadenas con una funcion de ella, ponerla aqui para 
			  mandar estos valores nombreFuncion(w,wMALO,j,i) (Tener en cuenta el orden de la cadena). 
			  Guardar el arreglo de cadenas dentro de una variable arreglo tipo string.
			  
			  2.- En la clase anterior, crear otra funcion donde se valide la cadena 'CadenaV' con la 
			  gramatica que mande al Whatsapp (Chequen si esta bien dicha gramatica), retornar dicha cadena 
			  y guardarla dentro de una variable.

			  3.- Comparar si la variable creada en 2.- existe en el arreglo del punto 1.-, si es verda, 
			  mandar la variable creada en 2.- al listbox con el nombre LCV, y si no existe, mandar al listbox con el
			  nombre LCVIn.

			  4.- Los puntos 1, 2 y 3 deben hacerse aqui en este apartado, es decir, hacer llamar a la funcion 
			  del punto 1 y 2, guardar lo que retornan en sus respectivas variables y hacer lo del punto 3.

			  NOTA: No olviden crear primero un objeto de dicha clase para poder acceder
			        a las funciones que vayan a crear.

			//Pruebas que hice :)
			/*MessageBox.Show(i + w + i +  wMALO + j);
			/*MessageBox.Show(Nombre.InAp("Luis Fernando Caamal Mayor"));
			MessageBox.Show(Nombre.InApMALO(Nombre.InAp("Jahir Nicolas Lopez Hernandez")));
			MessageBox.Show(Nombre.PrimerN("Aldo Gpe Lopez Hdz"));
			MessageBox.Show((Nombre.Matricula("1967014")));*/
		}


		//Eventos muertos
		private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
		private void Nom_TextChanged(object sender, EventArgs e)
        {
        }

        private void BtnCadenas_Click(object sender, EventArgs e)
        {
		}
    }
}
