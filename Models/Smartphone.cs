using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_CSharp_OO.Models
{
    public abstract class Smartphone
    {
           public string Numero { get; set; }
           private string Modelo;
           private string IMEI;
           private int Memoria;
           private bool IsPower = false;

           public Smartphone(string numero, string modelo, string imei, int memoria)
           {
                Numero = numero;
                Modelo = modelo;
                IMEI = imei;
                Memoria = memoria;
           }
    

           public void Ligar()
           {
                Console.WriteLine("Ligando...");
                IsPower = true;
           }

           public void ReceberLigacao()
           {
                Console.WriteLine("Recebendo ligação...");
           }

           public bool IsSmartphonePower()
            {
                return IsPower;
            }   
                
           public abstract string InstalarAplicativo(string nome);

    }
}