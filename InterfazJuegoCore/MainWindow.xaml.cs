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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace InterfazJuegoCore
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Juego.GetInstancia();
            cargarContinentes();
        }

        private void cargarContinentes() {
           Juego.GetInstancia().baseDatosGeografica.Continentes.ToList().ForEach((continente) => cmb_Continentes.Items.Add(continente.nombre));
        }


        private void cmb_Continentes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Jugar_Click(object sender, RoutedEventArgs e)
        {
            var nombreJugador = txt_Jugador.Text;
            string nombreContinente = (string) cmb_Continentes.SelectedItem;
            IJugador jugador = Juego.GetInstancia().baseDatosJugadores.getOrCreateJugador(nombreJugador);
            IContinente continente = Juego.GetInstancia().baseDatosGeografica.getContinente(nombreContinente);
            IPartida partida = Juego.GetInstancia().baseDatosJugadores.getJugador(nombreJugador).getNuevaPartida(continente);
            juego ventanaJuego = new juego(partida);
            
            ventanaJuego.Show();
        }
    }
}
