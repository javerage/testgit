using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica1MCD.Pages
{
    public class MCDModel : PageModel
    {
        [BindProperty]
        public double Num1 { get; set; }
        [BindProperty]
        public double Num2 { get; set; }
        [BindProperty]
        public double Num3 { get; set; }
        [BindProperty]
        public double Result { get; set; }
        [BindProperty]
        public string Resultado { get; set; }


        public void OnPostResultado()
        {
            double a = Math.Max(Num1, Num2);
            double b = Math.Min(Num1, Num2);
            double c = Math.Max(Num1, Num3);
            double d = Math.Min(Num1, Num3);
            double e = Math.Max(Num2, Num3);
            double f = Math.Min(Num2, Num3);

            double Result;


            if (Num1 < 1)
            {
                do
                {
                    Result = f;
                    f = e % f;
                    e = Result;

                } while (!(f == 0));
            }
            if (Num2 < 1)
            {
                do
                {
                    Result = d;
                    d = c % d;
                    c = Result;

                }
                while (!(d == 0));

            }
            if (Num3 < 0)
            {
                do
                {
                    Result = b;
                    b = a % b;
                    a = Result;
                } while (!(b == 0));
                Resultado = $"los numeros que insertaste son  {Num1}, { Num2}, {Num3} su maximo comun divisor es {Result }";

            }
        }






        public void OnGet()
        {
        }











    }
   
    
}
