using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;

namespace Juego_de_Dados__Parcial_
{
    public partial class Juego : Form
    {
        public Juego()
        {
            InitializeComponent();
        }
        // Puntero de la conexión a la DB
        private OleDbConnection ConexionConBD;

        // Puntero que tendrá los datos de la conexión y la consulta a realizar
        private OleDbCommand Orden;

        // Objeto receptor de los datos resultantes de la consulta a la DB
        private OleDbDataReader Lector;

        // Datos en modo cadena, de conexion a mi DB.
        private string conexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\JuegoDadosParcial.mdb;";
        Thread th;
        public int CantidadJugadores = Inicio.CantidadJugadores;
        public string Player1 = "Jugador 1: " + Inicio.Player1;
        public string Player2 = "Jugador 2: " + Inicio.Player2;
        public string Player3 = "Jugador 3: " + Inicio.Player3;
        int NumJugadorNow = 1;
        int[] PuntosJugador1_1 = new int[5];
        string[,] DadosTiradas = new string[3, 3];
        int sumJug1 = 0;
        int sumJug2 = 0;
        int sumJug3 = 0;
        int sumWinner = 0;
        string Winner = "";
        int dado1, dado2, dado3, dado4, dado5;
        int Turno = 1;
        string dadosPuntoComa1 = "";
        string dadosPuntoComa2 = "";
        string dadosPuntoComa3 = "";
        string dadosPuntoComaWinner = "";
        private void Juego_Load(object sender, EventArgs e)
        {
            btn_reiniciar.Visible = false;
            switch (CantidadJugadores)
            {
                case 1:
                    // Si solo hay 1 jugador, se borran los jugadores 2 y 3 de la datagridview.
                    dgv_jugadores.Columns.Remove("Jugador2");
                    dgv_jugadores.Columns.Remove("Jugador3");
                    // Se cambia el nombre del Jugador 1 en el datagridview por el nombre ingresado anteriormente.
                    dgv_jugadores.Columns[0].HeaderText = Player1;
                    lbl_jugador.Text = Player1;
                    break;
                case 2:
                    // Si solo hay 2 jugadores, se borra el jugador 3 de la datagridview.
                    dgv_jugadores.Columns.Remove("Jugador3");
                    // Se cambian los nombres de los Jugadores 1 y 2 en el datagridview por los nombres ingresados anteriormente.
                    dgv_jugadores.Columns[0].HeaderText = Player1;
                    dgv_jugadores.Columns[1].HeaderText = Player2;
                    lbl_jugador.Text = Player1;
                    break;
                case 3:
                    // Se cambian los nombres de los Jugadores 1, 2 y 3 en el datagridview por los nombres ingresados anteriormente.
                    dgv_jugadores.Columns[0].HeaderText = Player1;
                    dgv_jugadores.Columns[1].HeaderText = Player2;
                    dgv_jugadores.Columns[2].HeaderText = Player3;
                    lbl_jugador.Text = Player1;
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cargo en el label1 la fecha y hora para luego guardarla en la BD.
            label1.Text = DateTime.Now.ToString("dd/MM/yyyy h:mm:ss tt");
        }
        private void GuardarBD()
        {
            // Gilada de la BD.
            string consulta = "INSERT INTO jugadas (cant_jugadores, nombre_jugador, dados_tirados, puntaje_total, fecha_hora) VALUES (" + CantidadJugadores + ", '" + Convert.ToString(Winner) + "', '" + Convert.ToString(dadosPuntoComaWinner) + "', " + sumWinner + ",'" + Convert.ToString(label1.Text) + "');";
            ConexionConBD = new OleDbConnection(conexion);
            Orden = new OleDbCommand(consulta, ConexionConBD);
            ConexionConBD.Open();
            Orden.ExecuteNonQuery();
            ConexionConBD.Close();

        }
        private void TirarDados()
        {
            // Cargo un random para el azar de los dados.
            Random random = new Random();

            // Uso un for para que de la ilusion de la tirada de dados.
            for (int i = 1; i <= 15; i++)
            {
                dado1 = random.Next(1, 7);
                dado2 = random.Next(1, 7);
                dado3 = random.Next(1, 7);
                dado4 = random.Next(1, 7);
                dado5 = random.Next(1, 7);

                // Dependiendo del resultado final del random, se guarda en un array con la posicion segun el dado lanzado.
                switch (dado1)
                {
                    case 1:
                        pictureBox1.Image = Image.FromFile("C:\\dados\\dado1.png");
                        PuntosJugador1_1[0] = 1;
                        break;
                    case 2:
                        pictureBox1.Image = Image.FromFile("C:\\dados\\dado2.png");
                        PuntosJugador1_1[0] = 2;
                        break;
                    case 3:
                        pictureBox1.Image = Image.FromFile("C:\\dados\\dado3.png");
                        PuntosJugador1_1[0] = 3;
                        break;
                    case 4:
                        pictureBox1.Image = Image.FromFile("C:\\dados\\dado4.png");
                        PuntosJugador1_1[0] = 4;
                        break;
                    case 5:
                        pictureBox1.Image = Image.FromFile("C:\\dados\\dado5.png");
                        PuntosJugador1_1[0] = 5;
                        break;
                    case 6:
                        pictureBox1.Image = Image.FromFile("C:\\dados\\dado6.png");
                        PuntosJugador1_1[0] = 6;
                        break;
                }
                switch (dado2)
                {
                    case 1:
                        pictureBox2.Image = Image.FromFile("C:\\dados\\dado1.png");
                        PuntosJugador1_1[1] = 1;
                        break;
                    case 2:
                        pictureBox2.Image = Image.FromFile("C:\\dados\\dado2.png");
                        PuntosJugador1_1[1] = 2;
                        break;
                    case 3:
                        pictureBox2.Image = Image.FromFile("C:\\dados\\dado3.png");
                        PuntosJugador1_1[1] = 3;
                        break;
                    case 4:
                        pictureBox2.Image = Image.FromFile("C:\\dados\\dado4.png");
                        PuntosJugador1_1[1] = 4;
                        break;
                    case 5:
                        pictureBox2.Image = Image.FromFile("C:\\dados\\dado5.png");
                        PuntosJugador1_1[1] = 5;
                        break;
                    case 6:
                        pictureBox2.Image = Image.FromFile("C:\\dados\\dado6.png");
                        PuntosJugador1_1[1] = 6;
                        break;
                }
                switch (dado3)
                {
                    case 1:
                        pictureBox3.Image = Image.FromFile("C:\\dados\\dado1.png");
                        PuntosJugador1_1[2] = 1;
                        break;
                    case 2:
                        pictureBox3.Image = Image.FromFile("C:\\dados\\dado2.png");
                        PuntosJugador1_1[2] = 2;
                        break;
                    case 3:
                        pictureBox3.Image = Image.FromFile("C:\\dados\\dado3.png");
                        PuntosJugador1_1[2] = 3;
                        break;
                    case 4:
                        pictureBox3.Image = Image.FromFile("C:\\dados\\dado4.png");
                        PuntosJugador1_1[2] = 4;
                        break;
                    case 5:
                        pictureBox3.Image = Image.FromFile("C:\\dados\\dado5.png");
                        PuntosJugador1_1[2] = 5;
                        break;
                    case 6:
                        pictureBox3.Image = Image.FromFile("C:\\dados\\dado6.png");
                        PuntosJugador1_1[2] = 6;
                        break;
                }
                switch (dado4)
                {
                    case 1:
                        pictureBox4.Image = Image.FromFile("C:\\dados\\dado1.png");
                        PuntosJugador1_1[3] = 1;
                        break;
                    case 2:
                        pictureBox4.Image = Image.FromFile("C:\\dados\\dado2.png");
                        PuntosJugador1_1[3] = 2;
                        break;
                    case 3:
                        pictureBox4.Image = Image.FromFile("C:\\dados\\dado3.png");
                        PuntosJugador1_1[3] = 3;
                        break;
                    case 4:
                        pictureBox4.Image = Image.FromFile("C:\\dados\\dado4.png");
                        PuntosJugador1_1[3] = 4;
                        break;
                    case 5:
                        pictureBox4.Image = Image.FromFile("C:\\dados\\dado5.png");
                        PuntosJugador1_1[3] = 5;
                        break;
                    case 6:
                        pictureBox4.Image = Image.FromFile("C:\\dados\\dado6.png");
                        PuntosJugador1_1[3] = 6;
                        break;
                }
                switch (dado5)
                {
                    case 1:
                        pictureBox5.Image = Image.FromFile("C:\\dados\\dado1.png");
                        PuntosJugador1_1[4] = 1;
                        break;
                    case 2:
                        pictureBox5.Image = Image.FromFile("C:\\dados\\dado2.png");
                        PuntosJugador1_1[4] = 2;
                        break;
                    case 3:
                        pictureBox5.Image = Image.FromFile("C:\\dados\\dado3.png");
                        PuntosJugador1_1[4] = 3;
                        break;
                    case 4:
                        pictureBox5.Image = Image.FromFile("C:\\dados\\dado4.png");
                        PuntosJugador1_1[4] = 4;
                        break;
                    case 5:
                        pictureBox5.Image = Image.FromFile("C:\\dados\\dado5.png");
                        PuntosJugador1_1[4] = 5;
                        break;
                    case 6:
                        pictureBox5.Image = Image.FromFile("C:\\dados\\dado6.png");
                        PuntosJugador1_1[4] = 6;
                        break;
                }
                Application.DoEvents();
                Thread.Sleep(50);
                lbl_turno.Text = "Turno: " + Turno;
            }

        }
        private void DadoQueMasSalio(string DameDados)
        {
            int promedio;
            int[] DadoQueMasSalio = new int[15];
            // Separo con el Split el string ya que tiene ';'.
            string[] Temp = DameDados.Split(';');
            for (int i = 0; i <= 14; i++)
            {
                // Cargo el array int con el array string.
                DadoQueMasSalio[i] = Convert.ToInt16(Temp[i]);
            }
            // Encontrado en internet, Es para saber el nº que mas salio.
            var groups = DadoQueMasSalio.GroupBy(x => x);
            var largest = groups.OrderByDescending(x => x.Count()).First();
            promedio = largest.Key;
            MessageBox.Show("El dado que mas le salio al ganador es el: " + promedio, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            lbl_turno.Text = "Turno: " + Turno;
            switch (CantidadJugadores)
            {
                case 1:
                    switch (Turno)
                    {
                        case 1:
                            TirarDados();
                            for (int i = 0; i <= 4; i++)
                            {
                                //A ca se guarda la sumatoria de los dados
                                sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                            }
                            // Aca se guardan los dados en la ronda 1, 2 o 3
                            DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                            // Aca se carga en la DGV los datos de las jugadas de cada jugador.
                            dgv_jugadores.Rows.Add(DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] + " = " + Convert.ToString(sumJug1));
                            Turno = 2;
                            break;
                        case 2:
                            TirarDados();
                            for (int i = 0; i <= 4; i++)
                            {
                                sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                            }
                            DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                            dgv_jugadores.Rows.Add(DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] + " = " + Convert.ToString(sumJug1));
                            Turno = 3;
                            break;
                        case 3:
                            TirarDados();
                            for (int i = 0; i <= 4; i++)
                            {
                                sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                            }
                            DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                            dgv_jugadores.Rows.Add(DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] + " = " + Convert.ToString(sumJug1));
                            btn_tirar.Enabled = false;
                            MessageBox.Show("Felicidades " + Player1 + ", Sacaste " + sumJug1 + " Puntos!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Winner = Player1;
                            sumWinner = sumJug1;
                            dadosPuntoComaWinner = dadosPuntoComa1;
                            DadoQueMasSalio(dadosPuntoComaWinner);
                            btn_reiniciar.Visible = true;
                            GuardarBD();
                            btn_reiniciar.Visible = true;
                            break;
                            
                    }

                    break;
                case 2:
                    switch (NumJugadorNow)
                    {
                        case 1:
                            switch (Turno)
                            {
                                case 1:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                        dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                                    dgv_jugadores.Rows.Add();
                                    dgv_jugadores.Rows[0].Cells[0].Value = dadosPuntoComa1 + " = " + Convert.ToString(sumJug1);
                                    NumJugadorNow = 2;
                                    lbl_jugador.Text = Player2;
                                    break;
                                case 2:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                        dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                                    dgv_jugadores.Rows.Add();
                                    dgv_jugadores.Rows[1].Cells[0].Value = dadosPuntoComa1 + " = " + Convert.ToString(sumJug1);
                                    NumJugadorNow = 2;
                                    lbl_jugador.Text = Player2;
                                    break;
                                case 3:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                        dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                                    dgv_jugadores.Rows.Add();
                                    dgv_jugadores.Rows[2].Cells[0].Value = dadosPuntoComa1 + " = " + Convert.ToString(sumJug1);
                                    NumJugadorNow = 2;
                                    lbl_jugador.Text = Player2;
                                    break;
                            }
                            break;
                        case 2:
                            switch (Turno)
                            {
                                case 1:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug2 = sumJug2 + PuntosJugador1_1[i];
                                        dadosPuntoComa2 = dadosPuntoComa2 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa2;
                                    dgv_jugadores.Rows[0].Cells[1].Value = dadosPuntoComa2 + " = " + Convert.ToString(sumJug2);
                                    NumJugadorNow = 1;
                                    Turno = 2;
                                    lbl_jugador.Text = Player1;
                                    break;
                                case 2:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug2 = sumJug2 + PuntosJugador1_1[i];
                                        dadosPuntoComa2 = dadosPuntoComa2 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa2;
                                    dgv_jugadores.Rows[1].Cells[1].Value = dadosPuntoComa2 + " = " + Convert.ToString(sumJug2);
                                    NumJugadorNow = 1;
                                    Turno = 3;
                                    lbl_jugador.Text = Player2;
                                    break;
                                case 3:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug2 = sumJug2 + PuntosJugador1_1[i];
                                        dadosPuntoComa2 = dadosPuntoComa2 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa2;
                                    dgv_jugadores.Rows[2].Cells[1].Value = dadosPuntoComa2 + " = " + Convert.ToString(sumJug2);
                                    btn_tirar.Enabled = false;
                                    if (sumJug1 > sumJug2)
                                    {
                                        MessageBox.Show("Felicidades " + Player1 + ", Ganaste el partido con " + sumJug1 + " Puntos!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player1;
                                        sumWinner = sumJug1;
                                        dadosPuntoComaWinner = dadosPuntoComa1;
                                    }
                                    else if (sumJug2 == sumJug1)
                                    {
                                        MessageBox.Show("Empate!!. " + Player1 + " y " + Player2 + " Sacaron " + sumJug1 + " Puntos.", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player1 + " | " + Player2;
                                        dadosPuntoComaWinner = dadosPuntoComa1 + " | " + dadosPuntoComa2;
                                        sumWinner = sumJug1;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Felicidades " + Player2 + ", Ganaste el partido con " + sumJug2 + " Puntos!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    btn_reiniciar.Visible = true;
                                    GuardarBD();
                                    DadoQueMasSalio(dadosPuntoComaWinner);
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (NumJugadorNow)
                    {
                        case 1:
                            switch (Turno)
                            {
                                case 1:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                        dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                                    dgv_jugadores.Rows.Add();
                                    dgv_jugadores.Rows[0].Cells[0].Value = dadosPuntoComa1 + " = " + Convert.ToString(sumJug1);
                                    NumJugadorNow = 2;
                                    lbl_jugador.Text = Player2;
                                    break;
                                case 2:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                        dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                                    dgv_jugadores.Rows.Add();
                                    dgv_jugadores.Rows[1].Cells[0].Value = dadosPuntoComa1 + " = " + Convert.ToString(sumJug1);
                                    NumJugadorNow = 2;
                                    lbl_jugador.Text = Player2;
                                    break;
                                case 3:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug1 = sumJug1 + PuntosJugador1_1[i];
                                        dadosPuntoComa1 = dadosPuntoComa1 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa1;
                                    dgv_jugadores.Rows.Add();
                                    dgv_jugadores.Rows[2].Cells[0].Value = dadosPuntoComa1 + " = " + Convert.ToString(sumJug1);
                                    NumJugadorNow = 2;
                                    lbl_jugador.Text = Player2;
                                    break;
                            }
                            break;
                        case 2:
                            switch (Turno)
                            {
                                case 1:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug2 = sumJug2 + PuntosJugador1_1[i];
                                        dadosPuntoComa2 = dadosPuntoComa2 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa2;
                                    dgv_jugadores.Rows[0].Cells[1].Value = dadosPuntoComa2 + " = " + Convert.ToString(sumJug2);
                                    NumJugadorNow = 3;
                                    lbl_jugador.Text = Player3;
                                    break;
                                case 2:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug2 = sumJug2 + PuntosJugador1_1[i];
                                        dadosPuntoComa2 = dadosPuntoComa2 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa2;
                                    dgv_jugadores.Rows[1].Cells[1].Value = dadosPuntoComa2 + " = " + Convert.ToString(sumJug2);
                                    NumJugadorNow = 3;
                                    lbl_jugador.Text = Player3;
                                    break;
                                case 3:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug2 = sumJug2 + PuntosJugador1_1[i];
                                        dadosPuntoComa2 = dadosPuntoComa2 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa2;
                                    dgv_jugadores.Rows[2].Cells[1].Value = dadosPuntoComa2 + " = " + Convert.ToString(sumJug2);
                                    NumJugadorNow = 3;
                                    lbl_jugador.Text = Player3;
                                    break;
                            }
                            break;
                        case 3:
                            switch (Turno)
                            {
                                case 1:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug3 = sumJug3 + PuntosJugador1_1[i];
                                        dadosPuntoComa3 = dadosPuntoComa3 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa3;
                                    dgv_jugadores.Rows[0].Cells[2].Value = dadosPuntoComa3 + " = " + Convert.ToString(sumJug3);
                                    NumJugadorNow = 1;
                                    lbl_jugador.Text = Player1;
                                    Turno = 2;
                                    break;
                                case 2:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug3 = sumJug3 + PuntosJugador1_1[i];
                                        dadosPuntoComa3 = dadosPuntoComa3 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa3;
                                    dgv_jugadores.Rows[1].Cells[2].Value = dadosPuntoComa3 + " = " + Convert.ToString(sumJug3);
                                    NumJugadorNow = 1;
                                    NumJugadorNow = 1;
                                    lbl_jugador.Text = Player1;
                                    Turno = 3;
                                    break;
                                case 3:
                                    TirarDados();
                                    for (int i = 0; i <= 4; i++)
                                    {
                                        //Aca se guarda la sumatoria de los dados
                                        sumJug3 = sumJug3 + PuntosJugador1_1[i];
                                        dadosPuntoComa3 = dadosPuntoComa3 + Convert.ToString(PuntosJugador1_1[i]) + ";";
                                    }
                                    //Aca se guardan los dados en la ronda 1, 2 o 3
                                    DadosTiradas[Convert.ToInt16(NumJugadorNow - 1), Turno - 1] = dadosPuntoComa3;
                                    dgv_jugadores.Rows[2].Cells[2].Value = dadosPuntoComa3 + " = " + Convert.ToString(sumJug3);
                                    btn_tirar.Enabled = false;
                                    if ((sumJug1 > sumJug2) && (sumJug1 > sumJug3))
                                    {
                                        MessageBox.Show("Felicidades " + Player1 + ", Ganaste el partido con " + sumJug1 + " Puntos!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player1;
                                        dadosPuntoComaWinner = dadosPuntoComa1;
                                        sumWinner = sumJug1;
                                    }
                                    if ((sumJug2 > sumJug1) && (sumJug2 > sumJug3))
                                    {
                                        MessageBox.Show("Felicidades " + Player2 + ", Ganaste el partido con " + sumJug2 + " Puntos!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player2;
                                        dadosPuntoComaWinner = dadosPuntoComa2;
                                        sumWinner = sumJug2;
                                    }
                                    if ((sumJug3 > sumJug1) && (sumJug3 > sumJug2))
                                    {
                                        MessageBox.Show("Felicidades " + Player3 + ", Ganaste el partido con " + sumJug3 + " Puntos!!", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player3;
                                        dadosPuntoComaWinner = dadosPuntoComa3;
                                        sumWinner = sumJug3;
                                    }
                                    if ((sumJug1 == sumJug2) && (sumJug1 > sumJug3))
                                    {
                                        MessageBox.Show("Oof. Hubo un empate entre " + Player1 + " y " + Player2 + "con " + sumJug1 + " puntos cada uno.", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player1 + " | " + Player2;
                                        dadosPuntoComaWinner = dadosPuntoComa1 + " | " + dadosPuntoComa2;
                                        sumWinner = sumJug1;
                                    }
                                    if ((sumJug1 == sumJug3) && (sumJug1 > sumJug2))
                                    {
                                        MessageBox.Show("Oof. Hubo un empate entre " + Player1 + " y " + Player3 + "con " + sumJug1 + " puntos cada uno.", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player1 + " | " + Player3;
                                        dadosPuntoComaWinner = dadosPuntoComa1 + " | " + dadosPuntoComa3;
                                        sumWinner = sumJug1;
                                    }
                                    if ((sumJug2 == sumJug3) && (sumJug2 > sumJug1))
                                    {
                                        MessageBox.Show("Oof. Hubo un empate entre " + Player2 + " y " + Player3 + "con " + sumJug2 + " puntos cada uno.", "Juego Terminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Winner = Player2 + " | " + Player3;
                                        dadosPuntoComaWinner = dadosPuntoComa2 + " | " + dadosPuntoComa3;
                                        sumWinner = sumJug2;
                                    }
                                    btn_reiniciar.Visible = true;
                                    GuardarBD();
                                    DadoQueMasSalio(dadosPuntoComaWinner);
                                    break;
                                    
                            }
                            break;

                    }
                    break;
            }
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            // Se activa el boton de reiniciar, si el usuario le da click, vuelve al form "Inicio" y se reinicia todo, si clickea en no, no sucede nada.
            DialogResult reiniciar = MessageBox.Show("Esta seguro que desea reiniciar el juego?", "Atencion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (reiniciar == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(Reiniciar);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
            }

        }
        private void Reiniciar(object obj)
        {
            Application.Run(new Inicio());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

        

