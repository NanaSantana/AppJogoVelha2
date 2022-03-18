using System;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";
        int jogadas = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        //async deixa assicrono junto com o await,
        //no app ele faz com q pare o jogo quando alguem vencer
        // await tá no displayalert

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Contando jogadas
            // jogadas = jogadas + 1
            jogadas++;

            // Identificando qual botão disparou o evento
            Button btn = (Button)sender;

            // Desabilitando o botão
            btn.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verificando se a linha 1 teve ganhador.
            // && --> significa "e"
            // == --> comparar
            // || --> ou (coloca uma nova regra)

            if ((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") ||
               (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") ||
               (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") ||

               (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") ||
               (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") ||
               (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") ||

               (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") ||
               (btn30.Text == "X" && btn21.Text == "X" && btn12.Text == "X"))
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                zerar();
                jogadas = 0;  

            }
            else if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") ||
                     (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") ||
                     (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") ||

                     (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") ||
                     (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") ||
                     (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") ||

                     (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") ||
                     (btn30.Text == "O" && btn21.Text == "O" && btn12.Text == "O"))
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");
                zerar();
                jogadas = 0;

            }
            else if (jogadas == 9)
            {
                await DisplayAlert("Deu velha :c", "ninguem ganhou seus inuteis", "😪");
                zerar();
                jogadas = 0;

            }

        }

        void zerar()
        {
            btn10.IsEnabled = true;
            btn10.Text = "";
            btn11.IsEnabled = true;
            btn11.Text = "";
            btn12.IsEnabled = true;
            btn12.Text = "";

            btn20.IsEnabled = true;
            btn20.Text = "";
            btn21.IsEnabled = true;
            btn21.Text = "";
            btn22.IsEnabled = true;
            btn22.Text = "";

            btn30.IsEnabled = true;
            btn30.Text = "";
            btn31.IsEnabled = true;
            btn31.Text = "";
            btn32.IsEnabled = true;
            btn32.Text = "";
        }
    }
}
