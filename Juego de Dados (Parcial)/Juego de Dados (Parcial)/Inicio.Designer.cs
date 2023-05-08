namespace Juego_de_Dados__Parcial_
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbn_1player = new System.Windows.Forms.RadioButton();
            this.rbn_2player = new System.Windows.Forms.RadioButton();
            this.rbn_3player = new System.Windows.Forms.RadioButton();
            this.txt_player1 = new System.Windows.Forms.TextBox();
            this.txt_player2 = new System.Windows.Forms.TextBox();
            this.txt_player3 = new System.Windows.Forms.TextBox();
            this.btn_jugar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(495, 120);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a la Generala Trucha\r\n  (Genetrucha para los amigos).\r\n ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(532, 120);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cuantas personas van a participar?\r\n\r\n ";
            // 
            // rbn_1player
            // 
            this.rbn_1player.AutoSize = true;
            this.rbn_1player.BackColor = System.Drawing.Color.Transparent;
            this.rbn_1player.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.rbn_1player.Location = new System.Drawing.Point(85, 341);
            this.rbn_1player.Name = "rbn_1player";
            this.rbn_1player.Size = new System.Drawing.Size(183, 44);
            this.rbn_1player.TabIndex = 2;
            this.rbn_1player.TabStop = true;
            this.rbn_1player.Text = "1 Jugador";
            this.rbn_1player.UseVisualStyleBackColor = false;
            this.rbn_1player.CheckedChanged += new System.EventHandler(this.rbn_1player_CheckedChanged);
            // 
            // rbn_2player
            // 
            this.rbn_2player.AutoSize = true;
            this.rbn_2player.BackColor = System.Drawing.Color.Transparent;
            this.rbn_2player.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.rbn_2player.Location = new System.Drawing.Point(403, 341);
            this.rbn_2player.Name = "rbn_2player";
            this.rbn_2player.Size = new System.Drawing.Size(215, 44);
            this.rbn_2player.TabIndex = 3;
            this.rbn_2player.TabStop = true;
            this.rbn_2player.Text = "2 Jugadores";
            this.rbn_2player.UseVisualStyleBackColor = false;
            this.rbn_2player.CheckedChanged += new System.EventHandler(this.rbn_2player_CheckedChanged);
            // 
            // rbn_3player
            // 
            this.rbn_3player.AutoSize = true;
            this.rbn_3player.BackColor = System.Drawing.Color.Transparent;
            this.rbn_3player.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.rbn_3player.Location = new System.Drawing.Point(729, 341);
            this.rbn_3player.Name = "rbn_3player";
            this.rbn_3player.Size = new System.Drawing.Size(215, 44);
            this.rbn_3player.TabIndex = 4;
            this.rbn_3player.TabStop = true;
            this.rbn_3player.Text = "3 Jugadores";
            this.rbn_3player.UseVisualStyleBackColor = false;
            this.rbn_3player.CheckedChanged += new System.EventHandler(this.rbn_3player_CheckedChanged);
            // 
            // txt_player1
            // 
            this.txt_player1.Location = new System.Drawing.Point(85, 424);
            this.txt_player1.Name = "txt_player1";
            this.txt_player1.Size = new System.Drawing.Size(183, 20);
            this.txt_player1.TabIndex = 5;
            // 
            // txt_player2
            // 
            this.txt_player2.Enabled = false;
            this.txt_player2.Location = new System.Drawing.Point(403, 424);
            this.txt_player2.Name = "txt_player2";
            this.txt_player2.Size = new System.Drawing.Size(215, 20);
            this.txt_player2.TabIndex = 6;
            // 
            // txt_player3
            // 
            this.txt_player3.Enabled = false;
            this.txt_player3.Location = new System.Drawing.Point(729, 424);
            this.txt_player3.Name = "txt_player3";
            this.txt_player3.Size = new System.Drawing.Size(215, 20);
            this.txt_player3.TabIndex = 7;
            // 
            // btn_jugar
            // 
            this.btn_jugar.Font = new System.Drawing.Font("Tw Cen MT", 26.25F, System.Drawing.FontStyle.Bold);
            this.btn_jugar.Location = new System.Drawing.Point(356, 493);
            this.btn_jugar.Name = "btn_jugar";
            this.btn_jugar.Size = new System.Drawing.Size(308, 63);
            this.btn_jugar.TabIndex = 8;
            this.btn_jugar.Text = "Jugar!";
            this.btn_jugar.UseVisualStyleBackColor = true;
            this.btn_jugar.Click += new System.EventHandler(this.btn_jugar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.BackgroundImage = global::Juego_de_Dados__Parcial_.Properties.Resources._69241851_la_textura_de_fieltro_verde_para_el_póker_en_un_tema_del_casino_foto_de_alta_resolución_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 584);
            this.Controls.Add(this.btn_jugar);
            this.Controls.Add(this.txt_player3);
            this.Controls.Add(this.txt_player2);
            this.Controls.Add(this.txt_player1);
            this.Controls.Add(this.rbn_3player);
            this.Controls.Add(this.rbn_2player);
            this.Controls.Add(this.rbn_1player);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genetrucha";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbn_1player;
        private System.Windows.Forms.RadioButton rbn_2player;
        private System.Windows.Forms.RadioButton rbn_3player;
        private System.Windows.Forms.TextBox txt_player1;
        private System.Windows.Forms.TextBox txt_player2;
        private System.Windows.Forms.TextBox txt_player3;
        private System.Windows.Forms.Button btn_jugar;
    }
}

