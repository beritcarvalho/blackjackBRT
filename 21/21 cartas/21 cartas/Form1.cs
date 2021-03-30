using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_cartas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnReiniciar.Enabled = false;
            pibFundoCarta.Visible = false;
            lblUltimaCarta.Visible = false;
            lblDescricaoPontos.Visible = false;
            lblPontos.Visible = false;
        }
        int pontos = 0;
        int cartaatual = 0;
        int ultimacarta = 0;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            lblDescricaoPontos.Visible = true;
            lblPontos.Visible = true;
            pibCartas.Visible = true;
            pibFundoCarta.Visible = true;
            lblPontos.Location = new Point(90, 250);
            int numAleatorio;
            Random sorteio = new Random();
            numAleatorio = sorteio.Next(1, 14);

            

            ultimacarta = cartaatual;
            if (ultimacarta == 0)
            {
                lblUltimaCarta.Visible = false;
            }
            else
            {
                lblUltimaCarta.Visible = true;
                switch (ultimacarta)
                {
                    case 1:
                        pibUltimaCarta.Image = Properties.Resources._01___ouro;
                        break;
                    case 2:
                        pibUltimaCarta.Image = Properties.Resources._02___ouro;
                        break;

                    case 3:
                        pibUltimaCarta.Image = Properties.Resources._03___ouro;
                        break;
                    case 4:
                        pibUltimaCarta.Image = Properties.Resources._04___ouro;
                        break;
                    case 5:
                        pibUltimaCarta.Image = Properties.Resources._05___ouro;
                        break;
                    case 6:
                        pibUltimaCarta.Image = Properties.Resources._06___ouro;
                        break;
                    case 7:
                        pibUltimaCarta.Image = Properties.Resources._07___ouro;
                        break;
                    case 8:
                        pibUltimaCarta.Image = Properties.Resources._08___ouro;
                        break;
                    case 9:
                        pibUltimaCarta.Image = Properties.Resources._09___ouro;
                        break;
                    case 10:
                        pibUltimaCarta.Image = Properties.Resources._10___ouro;
                        break;
                    case 11:
                        pibUltimaCarta.Image = Properties.Resources._11___ouro;
                        break;
                    case 12:
                        pibUltimaCarta.Image = Properties.Resources._12___ouro;
                        break;
                    case 13:
                        pibUltimaCarta.Image = Properties.Resources._13___ouro;
                        break;

                }
            }



            switch (numAleatorio)
            {
                case 1:
                    pibCartas.Image = Properties.Resources._01___ouro;
                    pontos += 1;
                    cartaatual = 1;
                    break;
                case 2:
                    pibCartas.Image = Properties.Resources._02___ouro;
                    pontos += 2;
                    cartaatual = 2;
                    break;

                case 3:
                    pibCartas.Image = Properties.Resources._03___ouro;
                    pontos += 3;
                    cartaatual = 3;
                    break;
                case 4:
                    pibCartas.Image = Properties.Resources._04___ouro;
                    pontos += 4;
                    cartaatual = 4;
                    break;
                case 5:
                    pibCartas.Image = Properties.Resources._05___ouro;
                    pontos += 5;
                    cartaatual = 6;
                    break;
                case 6:
                    pibCartas.Image = Properties.Resources._06___ouro;
                    pontos += 6;
                    cartaatual = 6;
                    break;
                case 7:
                    pibCartas.Image = Properties.Resources._07___ouro;
                    pontos += 7;
                    cartaatual = 7;
                    break;
                case 8:
                    pibCartas.Image = Properties.Resources._08___ouro;
                    pontos += 8;
                    cartaatual = 8;
                    break;
                case 9:
                    pibCartas.Image = Properties.Resources._09___ouro;
                    pontos += 9;
                    cartaatual = 9;
                    break;
                case 10:
                    pibCartas.Image = Properties.Resources._10___ouro;
                    pontos += 10;
                    cartaatual = 10;
                    break;
                case 11:
                    pibCartas.Image = Properties.Resources._11___ouro;
                    pontos += 11;
                    cartaatual = 11;
                    break;
                case 12:
                    pibCartas.Image = Properties.Resources._12___ouro;
                    pontos += 12;
                    cartaatual = 12;
                    break;
                case 13:
                    pibCartas.Image = Properties.Resources._13___ouro;
                    pontos += 13;
                    cartaatual = 13;
                    break;

            }
            lblPontos.Text = pontos.ToString();


            
            if (pontos <= 21)
            {
                if (pontos == 21) {
                    lblPontos.Text = ("VOCÊ GANHOU!!!");
                    btnJogar.Enabled = false;
                    btnReiniciar.Enabled = true;
                    pibCartas.Visible = false;
                    pibFundoCarta.Visible = false;
                    lblPontos.Location = new Point(8, 86);
                    lblDescricaoPontos.Visible = false;
                }

            }
            else
            {
                lblPontos.Text = ("VOCÊ PERDEU!!!");
                btnJogar.Enabled = false;
                btnReiniciar.Enabled = true;
                pibCartas.Visible = false;
                pibFundoCarta.Visible = false;
                lblPontos.Location = new Point(8,86);
                lblDescricaoPontos.Visible = false;

            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {            
            lblPontos.Visible = false;
            pibFundoCarta.Visible = false;
            pibCartas.Visible = true;
            pibCartas.Image = Properties.Resources._0;
            pibUltimaCarta.Image = Properties.Resources.fundo_carta_vazia;
            pontos = 0;
            lblPontos.Text = pontos.ToString();
            btnJogar.Enabled = true;
            cartaatual = 0;
            ultimacarta = 0;
            lblUltimaCarta.Visible = false;

        }
    }
}
