using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Juego_de_Dados__Parcial_
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        // Cantidad de Jugadores
        public static int CantidadJugadores = 0;
        
        // Declaracion de los Nombres de los Jugadores
        public static string Player1 = "", Player2 = "", Player3 = "";
        Thread th;
        private void Inicio_Load(object sender, EventArgs e)
        {
            rbn_1player.Checked = true;
        }
        private void CorrerJuego ()
        {
            // Carga los strings con los nombres de los players.
                Player1 = txt_player1.Text;
                Player2 = txt_player2.Text;
                Player3 = txt_player3.Text;

                // Cierra este form y abre el del juego.
                this.Close();
                th = new Thread(runjuego);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
        }
        private void rbn_1player_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton1 esta activo, deshabilita los textbox de los player 2 y 3.
            txt_player1.Enabled = true;
            txt_player2.Enabled = false;
            txt_player3.Enabled = false;
            // Carga con el valor 1 a la cantidad de jugadores.
            CantidadJugadores = 1;
            txt_player2.Text = "";
            txt_player3.Text = "";
        }

        private void rbn_2player_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton2 esta activo, deshabilita el textbox del player 3.
            txt_player1.Enabled = true;
            txt_player2.Enabled = true;
            txt_player3.Enabled = false;
            // Carga con el valor 2 a la cantidad de jugadores.
            CantidadJugadores = 2;
            txt_player3.Text = "";
        }

        private void rbn_3player_CheckedChanged(object sender, EventArgs e)
        {
            // Si el radioButton3 esta activo, habilita todos los textbox de los players.
            txt_player1.Enabled = true;
            txt_player2.Enabled = true;
            txt_player3.Enabled = true;
            // Carga con el valor 3 a la cantidad de jugadores.
            CantidadJugadores = 3;
        }

        private void btn_jugar_Click(object sender, EventArgs e)
        {
            switch (CantidadJugadores)
            {
                case 1:
                    // Si alguno de los textbox esta vacio, da un mensaje de error, sino continua con el programa
                    if (txt_player1.Text == "")
                    {
                        MessageBox.Show("No podes dejar los nombres en blanco capo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CorrerJuego();
                    }
                    break;
                case 2:
                    // Si alguno de los textbox esta vacio, da un mensaje de error, sino continua con el programa
                    if ((txt_player1.Text == "") || (txt_player2.Text == ""))
                    {
                        MessageBox.Show("No podes dejar los nombres en blanco capo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CorrerJuego();
                    }
                    break;
                case 3:
                    // Si alguno de los textbox esta vacio, da un mensaje de error, sino continua con el programa
                    if ((txt_player1.Text == "") || (txt_player2.Text == "") || (txt_player3.Text == ""))
                    {
                        MessageBox.Show("No podes dejar los nombres en blanco capo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CorrerJuego();
                    }
                    break;
            }
        }
        private void runjuego(object obj)
        {
            Application.Run(new Juego());
        }

    }
}
