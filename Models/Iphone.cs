using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_CSharp_OO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override string InstalarAplicativo(string nome)
        {
            string text = $"Obtendo app {nome} a partir da Apple Store...";
          Console.WriteLine(text);
          return text;
        }
    }
}