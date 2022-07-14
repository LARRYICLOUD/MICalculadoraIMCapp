using System;
using Xamarin.Forms;

namespace MICalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)



        {
            
            
                
                var peso = double.Parse(Peso.Text);
                var altura = double.Parse(Altura.Text);
                var imc = peso/(altura * altura) ;
                IMC.Text = imc.ToString();

                string  varresultado = "";

             if (imc < 18.5)

                {
                    varresultado = "Tienes bajoO peso";

                }
                        else if (imc >= 18.5 && imc <= 24.9)


                {
                    varresultado = "Tu peso esnormal";
                }
                else if (imc >= 25.0 && imc <= 29.9)
                {
                    varresultado = "Tienes sobrepeso";

                }
                else
                {
                    varresultado = "Tienesobesidad, ¡Cuidate!";

                }

                                DisplayAlert("Resultado", varresultado, "OK");

            

            

        }





    }
}

