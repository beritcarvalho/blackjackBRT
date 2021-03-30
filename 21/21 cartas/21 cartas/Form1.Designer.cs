
namespace _21_cartas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pibFundoCarta = new System.Windows.Forms.PictureBox();
            this.pibCartas = new System.Windows.Forms.PictureBox();
            this.lblPontos = new System.Windows.Forms.Label();
            this.lblDescricaoPontos = new System.Windows.Forms.Label();
            this.lblUltimaCarta = new System.Windows.Forms.Label();
            this.pibUltimaCarta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFundoCarta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCartas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibUltimaCarta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(10, 206);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(102, 32);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Enabled = false;
            this.btnReiniciar.Location = new System.Drawing.Point(118, 206);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(102, 32);
            this.btnReiniciar.TabIndex = 1;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-4, -10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 464);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pibFundoCarta
            // 
            this.pibFundoCarta.BackColor = System.Drawing.SystemColors.Control;
            this.pibFundoCarta.Image = global::_21_cartas.Properties.Resources.carta_vazia_com_sombra;
            this.pibFundoCarta.Location = new System.Drawing.Point(45, 10);
            this.pibFundoCarta.Name = "pibFundoCarta";
            this.pibFundoCarta.Size = new System.Drawing.Size(150, 190);
            this.pibFundoCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibFundoCarta.TabIndex = 0;
            this.pibFundoCarta.TabStop = false;
            // 
            // pibCartas
            // 
            this.pibCartas.Image = global::_21_cartas.Properties.Resources._0;
            this.pibCartas.Location = new System.Drawing.Point(47, 12);
            this.pibCartas.Name = "pibCartas";
            this.pibCartas.Size = new System.Drawing.Size(139, 185);
            this.pibCartas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibCartas.TabIndex = 3;
            this.pibCartas.TabStop = false;
            // 
            // lblPontos
            // 
            this.lblPontos.AutoSize = true;
            this.lblPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblPontos.Font = new System.Drawing.Font("Microsoft JhengHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPontos.ForeColor = System.Drawing.Color.White;
            this.lblPontos.Image = global::_21_cartas.Properties.Resources.fundo_verde;
            this.lblPontos.Location = new System.Drawing.Point(90, 250);
            this.lblPontos.Name = "lblPontos";
            this.lblPontos.Size = new System.Drawing.Size(31, 35);
            this.lblPontos.TabIndex = 4;
            this.lblPontos.Text = "0";
            // 
            // lblDescricaoPontos
            // 
            this.lblDescricaoPontos.AutoSize = true;
            this.lblDescricaoPontos.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricaoPontos.Font = new System.Drawing.Font("Microsoft JhengHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDescricaoPontos.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescricaoPontos.Image = global::_21_cartas.Properties.Resources.fundo_verde;
            this.lblDescricaoPontos.Location = new System.Drawing.Point(10, 258);
            this.lblDescricaoPontos.Name = "lblDescricaoPontos";
            this.lblDescricaoPontos.Size = new System.Drawing.Size(92, 27);
            this.lblDescricaoPontos.TabIndex = 5;
            this.lblDescricaoPontos.Text = "Pontos: ";
            // 
            // lblUltimaCarta
            // 
            this.lblUltimaCarta.AutoSize = true;
            this.lblUltimaCarta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUltimaCarta.ForeColor = System.Drawing.Color.White;
            this.lblUltimaCarta.Image = global::_21_cartas.Properties.Resources.fundo_verde;
            this.lblUltimaCarta.Location = new System.Drawing.Point(10, 362);
            this.lblUltimaCarta.Name = "lblUltimaCarta";
            this.lblUltimaCarta.Size = new System.Drawing.Size(101, 21);
            this.lblUltimaCarta.TabIndex = 6;
            this.lblUltimaCarta.Text = "Última carta: ";
            // 
            // pibUltimaCarta
            // 
            this.pibUltimaCarta.Image = global::_21_cartas.Properties.Resources.fundo_carta_vazia;
            this.pibUltimaCarta.Location = new System.Drawing.Point(117, 350);
            this.pibUltimaCarta.Name = "pibUltimaCarta";
            this.pibUltimaCarta.Size = new System.Drawing.Size(57, 76);
            this.pibUltimaCarta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibUltimaCarta.TabIndex = 7;
            this.pibUltimaCarta.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 438);
            this.Controls.Add(this.lblPontos);
            this.Controls.Add(this.pibUltimaCarta);
            this.Controls.Add(this.lblUltimaCarta);
            this.Controls.Add(this.lblDescricaoPontos);
            this.Controls.Add(this.pibCartas);
            this.Controls.Add(this.pibFundoCarta);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Black Jack (Versão 1.0)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFundoCarta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibCartas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibUltimaCarta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pibFundoCarta;
        private System.Windows.Forms.PictureBox pibCartas;
        private System.Windows.Forms.Label lblPontos;
        private System.Windows.Forms.Label lblDescricaoPontos;
        private System.Windows.Forms.Label lblUltimaCarta;
        private System.Windows.Forms.PictureBox pibUltimaCarta;
    }
}

