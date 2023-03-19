using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementosC
{
    public class Cadena
    {
        public string w; //Iniciales de los Apellidos
        public string wMALO; //Iniciales al reves de los Apellidos
        public int i; // Matricula
        public string j; //Primer Nombre


        public string InAp(string Nombre)
        {
            string nombre = Nombre;
            PrimerN(nombre);
            string[] IA = nombre.Split(' ');
            foreach(var letra in IA)
            {
                for(int i=0; i<letra.Length; i++)
                {
                    string ini = letra[0] + " ";
                    w = w + ini;
                    break;
                }    
            }

            for(int a = 0; a < w.Length; a++)
            {
                if (a == w.Length - 2)
                {
                    string PIn = w[a] + " ";
                    w = PIn + w[w.Length-1];
                } 
                w = w.Replace(" ", string.Empty);   
            }

            InApMALO(w);
            

            return w;
        }

        public string InApMALO(string InAP)
        {
            string w = InAP;
            for(int i = 0; i < w.Length; i++)
            {
                string InApMALO= w[w.Length-1] + " ";
                w = InApMALO + w[i];
                w = w.Replace(" ", string.Empty);
                break;   
            }
            return w;
        }

        public string PrimerN(string NombreP)
        {
            string PNom = NombreP;
            string[] PrN = PNom.Split(' ');

            foreach(var nombre in PrN)
            {
                j = nombre + " ";
                j = j.Replace(" ", string.Empty);
                break;
            }
            j = j + j;

            return j;
        }
        public string Matricula(string Mat)
        {
            string i = Mat;

            return i;
        }
    }
}
