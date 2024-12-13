using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chinchon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRobarCarta_Click(object sender, EventArgs e)
        {
            
            /*Carta carta Mazo.RobarCarta();
            if (carta != null)
            {
                // Añadir la carta a la mano del jugador
                manoJugador.Add(carta);
                // Actualizar la interfaz de usuario
                ActualizarManoJugador();*/
            }
            

        }
    }
    #region Clases
    public enum Palo
    {
        Oros,
        Bastos,
        Espadas,
        Copas
    }

    public class Carta
    {
        public Palo Palo { get; set; }
        public int Valor { get; set; }
        public Image Imagen { get; set; }

        public Carta (Palo palo,int valor, Image imagen)
        {
            Palo = palo;
            Valor = valor;
            Imagen = imagen;
        }
    }
   public class Mazo
   {
        private List<Carta> Cartas;

        public Mazo()
        {
            Cartas = new List<Carta>();

        }
        private void GenerarMazo()
        {
            Palo[] palos = (Palo[])Enum.GetValues(typeof(Palo));
            int[] valores = { 1, 2, 3, 4, 5, 6, 7, 10, 11, 12 };

            foreach(var palo in palos)
            {
                foreach(var valor in valores )
                {
                    Image imagen = ObtenerImagenDeCarta(palo, valor);
                    Cartas.Add(new Carta(palo, valor, imagen));
                }
            }
        }
        private Image ObtenerImagenDeCarta(Palo palo , int valor)
        {
            // Falta logica para asignar la imagen correcta
            return null;
        }

        public void Mezlcar() // por cada carta en el mazo, toma una carta random y la intercambia con la ultima.
        {
            Random random = new Random();
            int n = Cartas.Count; // da el numero total de cartas que hay 
            while(n>1) // mientras que el numero total de cartas sea mayor a 1...
            {
                n--;
                int k = random.Next(n + 1); // genera un numero random dentro de la cantidad de cartas que hay
                Carta value = Cartas[k]; // copia el valor de la carta random elegida y la guarda en value
                Cartas[k] = Cartas[n]; //la carta random ahora copia los valores de la ultima carta en el mazo (n)
                Cartas[n] = value; // y la ultima carta del mazo copia los valores originales de la carta random

            }

        }
        public void Repartir()
        {

        }
        public Carta RobarCarta()
        {
            if(Cartas.Count>0)
            {
                Carta carta = Cartas[0];
                Cartas.RemoveAt(0);
                return carta;
            }
            return null;
        }
   }
    #endregion
}
