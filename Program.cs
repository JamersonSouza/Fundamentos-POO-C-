
using projeto_CSharp_OO.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("Olá seja bem-vindo, Qual SmartPhone deseja ligar?");

bool exibirMenu = true;
Smartphone nokia = new Nokia(numero: "(81) 9 1234-5678", modelo: "Tijolão", imei: "123456789", memoria: 128);
Smartphone iphone = new Iphone(numero: "(81) 9 8765-4321", modelo: "XR", imei: "123456789", memoria: 256);

while (exibirMenu)
{
    Console.WriteLine("1 - Nokia");
    Console.WriteLine("2 - Iphone");
    Console.WriteLine("3 - Encerrar");
    Console.WriteLine("Pressione um NÚMERO para continuar ou encerrar.");
    switch (Console.ReadLine())
    {
        case "1":
        nokia.Ligar();
        if(nokia.IsSmartphonePower()){
        Console.WriteLine( @"
        _   _    ___    _  __  ___      _    
        | \ | |  / _ \  | |/ / |_ _|    / \   
        |  \| | | | | | | ' /   | |    / _ \  
        | |\  | | |_| | | . \   | |   / ___ \ 
        |_| \_|  \___/  |_|\_\ |___| /_/   \_\
        ");
        Console.WriteLine("Deseja fazer a instalação de um Aplicativo? \n");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        string enter = Console.ReadLine();

        if (enter == "1" || enter == "sim")
        {
        Console.WriteLine("Escolha um aplicativo para instalar: \n");
        List<string> apps = new List<string> { "1 - WhatsApp \n", "2 - Instagram \n", "3 - Facebook \n", "4 - Spotify\n"};

        foreach (var app in apps)
        {
            Console.WriteLine(app);
        }
          string AppSelected = Console.ReadLine();
            switch (AppSelected.ToLower())
        {
            case "1":
            case "whatsapp":
                nokia.InstalarAplicativo(AppSelected);
                break;
            case "2":
            case "instagram":
                nokia.InstalarAplicativo(AppSelected);
                break;
            case "3":
            case "facebook":
                nokia.InstalarAplicativo(AppSelected);
                break;
            case "4":
            case "spotify":
                  nokia.InstalarAplicativo(AppSelected);
                break;
            
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
        }
        else if (enter == "2" || enter == "não" || enter == "nao")
        {
            Console.WriteLine("Nenhum app será instalado.");
            nokia.ReceberLigacao();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
        exibirMenu = false;
        }else{
            Console.WriteLine("Ocorreu um erro ao tentar ligar o aparelho");
            exibirMenu = false;
        }
         break;
         
        case "2":
        nokia.Ligar();
        if(nokia.IsSmartphonePower()){
        Console.WriteLine(@"
   AAAAA   PPPP   PPPP   L       EEEEE  
  A     A  P   P  P   P  L       E      
  AAAAAAA  PPPP   PPPP   L       EEEE   
  A     A  P      P      L       E      
  A     A  P      P      LLLLL   EEEEE  
"); 
        Console.WriteLine("Deseja fazer a instalação de um Aplicativo? \n");
        Console.WriteLine("1 - Sim");
        Console.WriteLine("2 - Não");
        string enter = Console.ReadLine();

        if (enter == "1" || enter == "sim")
        {
        Console.WriteLine("Escolha um aplicativo para instalar: \n");
        List<string> apps = new List<string> { "1 - Apple Music \n", "2 - Uber \n", "3 - Apple Podcasts \n", "4 - Ifood\n"};

        foreach (var app in apps)
        {
            Console.WriteLine(app);
        }
          string AppSelected = Console.ReadLine();
            switch (AppSelected.ToLower())
        {
            case "1":
            case "whatsapp":
                iphone.InstalarAplicativo(AppSelected);
                break;
            case "2":
            case "instagram":
                iphone.InstalarAplicativo(AppSelected);
                break;
            case "3":
            case "facebook":
                iphone.InstalarAplicativo(AppSelected);
                break;
            case "4":
            case "spotify":
                  iphone.InstalarAplicativo(AppSelected);
                break;
            
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
        }
        else if (enter == "2" || enter == "não" || enter == "nao")
        {
            Console.WriteLine("Nenhum app será instalado.");
            iphone.ReceberLigacao();
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
        exibirMenu = false;
        }else{
            Console.WriteLine("Ocorreu um erro ao tentar ligar o aparelho");
            exibirMenu = false;
        }
            break;

        case "3":
            exibirMenu = false;
            Console.WriteLine("O programa se encerrou");
            break;

        default:
         Console.WriteLine("Opção inválida");
         break;

    }
    
   
}
