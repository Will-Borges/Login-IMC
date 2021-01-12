using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Xunit;

namespace MeuProjeto.Models
{
    public class CalculoIMC
    {
        //[Required(ErrorMessage = "Informe o peso")]
        [Display(Name = "Peso:")]
        public string Peso { get; set; }

        [Display(Name = "Altura:")]
        public string Altura { get; set; }


        [Display(Name = "Resultado:")]
        public string Result => Calcular();       

        private string Calcular()
        {

            if (Convert.ToDecimal(Peso) != 0)
            {
                decimal resultCalculo = Convert.ToDecimal(Peso) / (Convert.ToDecimal(Altura) * 2);

                if (resultCalculo < 10)
                {
                    return Convert.ToString(resultCalculo) + " - Desnutrição Grau V";
                }
                else if (resultCalculo >= 10 & resultCalculo < 13)
                {
                    return Convert.ToString(resultCalculo) + " - Desnutrição Grau IV";
                }
                else if (resultCalculo >= 13 & resultCalculo < 16)
                {
                    return Convert.ToString(resultCalculo) + " - Desnutrição Grau III";
                }
                else if (resultCalculo >= 16 & resultCalculo < 17)
                {
                    return Convert.ToString(resultCalculo) + " - Desnutrição Grau II";
                }
                else if (resultCalculo >= 17 & resultCalculo < (decimal)18.5)
                {
                    return Convert.ToString(resultCalculo) + " - Desnutrição Grau I";
                }
                else if (resultCalculo >= (decimal)18.5 & resultCalculo < 25)
                {
                    return Convert.ToString(resultCalculo) + " - Normal";
                }
                else if (resultCalculo >= 25 & resultCalculo < 30)
                {
                    return Convert.ToString(resultCalculo) + " - Pré-obesidade";
                }
                else if (resultCalculo >= 30 & resultCalculo < 35)
                {
                    return Convert.ToString(resultCalculo) + " - Obesidade Grau I";
                }
                else if (resultCalculo >= 35 & resultCalculo < 40)
                {
                    return Convert.ToString(resultCalculo) + " - Obesidade Grau II";
                }
                else if (resultCalculo > 40)
                {
                    return Convert.ToString(resultCalculo) + " - Obesidade Grau III";
                }
                return "Valor Inesperado";
            }
            return "O peso dever ser maior que zero.";
        }

    }
}