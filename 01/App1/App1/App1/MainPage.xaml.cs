using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Servico;
using App1.Servico.Modelo;


namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BOTAO.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args) {
            string cep = CEP.Text.Trim();
            if (ValidaCEP(cep)) {
                try {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);

                    if (end != null)
                    {
                        RESULTADO.Text = string.Format("Endereço: {0}, {1} {2}, {3}.", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO!", "CEP Inválido! " + cep, "Ok");
                    }
                }catch(Exception e){
                    DisplayAlert("ERRO CRÍTICO", e.Message, "OK");
                }
            }
        }


        private bool ValidaCEP( string cep)
        {
            bool valido = true;

            if(cep.Length != 8)
            {
                DisplayAlert("Erro!", "CEP Inválido! O CEP deve conter 8 digitos.", "OK");
                valido = false;
            }

            int NovoCEP = 0;
            if(!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("Erro!", "CEP Inválido! O CEP deve conter apenas numeros.", "OK");
                valido = false;
            }
                return valido;
        }

    }
}
