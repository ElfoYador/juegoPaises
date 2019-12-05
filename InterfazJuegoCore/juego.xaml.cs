using LibreriasJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InterfazJuegoCore
{
    /// <summary>
    /// Lógica de interacción para juego.xaml
    /// </summary>
    public partial class juego : Window
    {
        private IPartida partida;
        IPregunta preguntaActual;
        public juego(IPartida partida)
        {
            InitializeComponent();
            LabelJugador.Content = partida.jugador.nombre;
            this.partida = partida;
            nuevaPregunta();
           // LabelJugador.Content = 
        }

        private void nuevaPregunta()
        {

            preguntaActual = partida.nuevaPregunta();
            Pais.Content = preguntaActual.pais.nombre;
            txt_Capital.Text = "";
            Intentos.Content = preguntaActual.intentosRestantes;
            int total = partida.historicoPreguntas.Count;
            int aciertos = 0;
            partida.historicoPreguntas.ToList().ForEach((pregunta) => { if (pregunta.acierto) aciertos++; });
            Aciertos.Content = "Llevas " + aciertos + " aciertos de " + total + " preguntas";

        }

        private void Fin_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Probar_Click(object sender, RoutedEventArgs e)
        {
            bool acierto = preguntaActual.proponerRespuesta(txt_Capital.Text);
            if (acierto || preguntaActual.intentosRestantes == 0)
            {
                nuevaPregunta();
            }
            else
            {
                txt_Capital.Text = "";
                Intentos.Content = preguntaActual.intentosRestantes;

            }
        }
    }
}
