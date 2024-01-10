using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_CSharp_OO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        public override string InstalarAplicativo(string nome)
        {
          string text = $"Instalando o aplicativo {nome} no seu aparelho Nokia";
          Console.WriteLine(text);
          return text;
        }
    }
}