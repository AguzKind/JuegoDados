namespace Juego_de_Dados__Parcial_
{
    partial class Juego
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgv_jugadores = new System.Windows.Forms.DataGridView();
            this.Jugador1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jugador3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_tirar = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_jugador = new System.Windows.Forms.Label();
            this.lbl_turno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgv_jugadores
            // 
            this.dgv_jugadores.AllowUserToAddRows = false;
            this.dgv_jugadores.AllowUserToDeleteRows = false;
            this.dgv_jugadores.AllowUserToOrderColumns = true;
            this.dgv_jugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_jugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_jugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Jugador1,
            this.Jugador2,
            this.Jugador3});
            this.dgv_jugadores.Location = new System.Drawing.Point(666, 12);
            this.dgv_jugadores.Name = "dgv_jugadores";
            this.dgv_jugadores.ReadOnly = true;
            this.dgv_jugadores.RowHeadersVisible = false;
            this.dgv_jugadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgv_jugadores.Size = new System.Drawing.Size(779, 281);
            this.dgv_jugadores.TabIndex = 0;
            // 
            // Jugador1
            // 
            this.Jugador1.HeaderText = "Jugador 1";
            this.Jugador1.Name = "Jugador1";
            this.Jugador1.ReadOnly = true;
            // 
            // Jugador2
            // 
            this.Jugador2.HeaderText = "Jugador 2";
            this.Jugador2.Name = "Jugador2";
            this.Jugador2.ReadOnly = true;
            // 
            // Jugador3
            // 
            this.Jugador3.HeaderText = "Jugador 3";
            this.Jugador3.Name = "Jugador3";
            this.Jugador3.ReadOnly = true;
            // 
            // btn_tirar
            // 
            this.btn_tirar.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_tirar.Location = new System.Drawing.Point(1300, 458);
            this.btn_tirar.Name = "btn_tirar";
            this.btn_tirar.Size = new System.Drawing.Size(136, 58);
            this.btn_tirar.TabIndex = 6;
            this.btn_tirar.Text = "Tirar";
            this.btn_tirar.UseVisualStyleBackColor = true;
            this.btn_tirar.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Juego_de_Dados__Parcial_.Properties.Resources.dado5;
            this.pictureBox5.Location = new System.Drawing.Point(384, 172);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(143, 121);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Juego_de_Dados__Parcial_.Properties.Resources.dado4;
            this.pictureBox4.Location = new System.Drawing.Point(155, 172);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(143, 121);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Juego_de_Dados__Parcial_.Properties.Resources.dado3;
            this.pictureBox3.Location = new System.Drawing.Point(477, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 121);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Juego_de_Dados__Parcial_.Properties.Resources.dado2;
            this.pictureBox2.Location = new System.Drawing.Point(260, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Juego_de_Dados__Parcial_.Properties.Resources.dado1;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_jugador
            // 
            this.lbl_jugador.AutoSize = true;
            this.lbl_jugador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_jugador.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_jugador.Location = new System.Drawing.Point(12, 386);
            this.lbl_jugador.Name = "lbl_jugador";
            this.lbl_jugador.Size = new System.Drawing.Size(146, 40);
            this.lbl_jugador.TabIndex = 7;
            this.lbl_jugador.Text = "Jugador:";
            // 
            // lbl_turno
            // 
            this.lbl_turno.AutoSize = true;
            this.lbl_turno.BackColor = System.Drawing.Color.Transparent;
            this.lbl_turno.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.lbl_turno.Location = new System.Drawing.Point(12, 452);
            this.lbl_turno.Name = "lbl_turno";
            this.lbl_turno.Size = new System.Drawing.Size(111, 40);
            this.lbl_turno.TabIndex = 8;
            this.lbl_turno.Text = "Turno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Font = new System.Drawing.Font("Tw Cen MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reiniciar.Location = new System.Drawing.Point(1132, 458);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(136, 58);
            this.btn_reiniciar.TabIndex = 10;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Juego_de_Dados__Parcial_.Properties.Resources._69241851_la_textura_de_fieltro_verde_para_el_póker_en_un_tema_del_casino_foto_de_alta_resolución_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1457, 528);
            this.Controls.Add(this.btn_reiniciar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_turno);
            this.Controls.Add(this.lbl_jugador);
            this.Controls.Add(this.btn_tirar);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_jugadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Juego";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetrucha";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_jugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgv_jugadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jugador3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_tirar;
        private System.Windows.Forms.Label lbl_jugador;
        private System.Windows.Forms.Label lbl_turno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_reiniciar;
    }
}