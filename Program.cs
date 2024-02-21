string mensagemDeBoasVindas = "Bem vindo";
//List<string> listaDebandas = new List<string>{"U2"};

Dictionary<string,List<int>> dicionarioBandas = new Dictionary<string,List<int>>();
dicionarioBandas.Add("betles", new List<int>{1,2,3,4});
dicionarioBandas.Add("slit", new List<int>());

void ExibeBoasVindas()
{
Console.WriteLine(@"


██████╗░██╗░░░░░░█████╗░██╗░░░██╗  ███╗░░░███╗██╗░░░██╗░██████╗██╗░█████╗░
██╔══██╗██║░░░░░██╔══██╗╚██╗░██╔╝  ████╗░████║██║░░░██║██╔════╝██║██╔══██╗
██████╔╝██║░░░░░███████║░╚████╔╝░  ██╔████╔██║██║░░░██║╚█████╗░██║██║░░╚═╝
██╔═══╝░██║░░░░░██╔══██║░░╚██╔╝░░  ██║╚██╔╝██║██║░░░██║░╚═══██╗██║██║░░██╗
██║░░░░░███████╗██║░░██║░░░██║░░░  ██║░╚═╝░██║╚██████╔╝██████╔╝██║╚█████╔╝
╚═╝░░░░░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ╚═╝░░░░░╚═╝░╚═════╝░╚═════╝░╚═╝░╚════╝░
");
Console.WriteLine(mensagemDeBoasVindas);

}

void ExibirOpcoesMenu()
{
ExibeBoasVindas();
Console.WriteLine("Digite 1 para registar uma banda");
Console.WriteLine("Digite 2 para mostrar todas as bandas");
Console.WriteLine("Digite 3 para avaliar uma banda");
Console.WriteLine("Digite 4 para exibir a média de uma banda");
Console.WriteLine("Digite -1 para sair");

Console.WriteLine("\nDigite uma opção: ");
string opcao = Console.ReadLine()!;
int opcaoNumeria = int.Parse(opcao);
switch (opcaoNumeria) 
{
    case 1:
         RegistraBanda();
         break;
    case 2:
         ExibeListaDeBandas();
         break;
    case 3:
         AtribuiNota();
         break;
    case 4:
         Mediadenotas();
         break;
    case -1:
         saindo();
         break;
    default:
        Console.WriteLine("Opção inválida");
        break;        
}
}

void RegistraBanda()
{
    Console.Clear();
    ExibeOTituloDasOpcoes("Registro das bandas");
    Console.WriteLine("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine($"A Banda {nomeDaBanda} registrada com sucesso!!");
    dicionarioBandas.Add(nomeDaBanda , new List<int>());
    Thread.Sleep(5000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibeListaDeBandas() 
{
    Console.Clear();
    ExibeOTituloDasOpcoes("Exibindo bandas registradas");
    
  
    foreach (string bandas in dicionarioBandas.Keys)
    {
        Console.WriteLine($"Bandas:{bandas}");
    }
    Console.WriteLine("Digite qualquer tecla para sair");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void ExibeOTituloDasOpcoes(string titulo) {
    int quantidade = titulo.Length;
    string aste = string.Empty.PadLeft(quantidade,'*');
    Console.WriteLine(aste);
    Console.WriteLine(titulo);
    Console.WriteLine(aste);
}

void AtribuiNota() 
{
    Console.Clear();
    ExibeOTituloDasOpcoes("Avalia banda");
    Console.WriteLine("Digite o nome da banda que deseja avaliar");
    string nomeDaBanda = Console.ReadLine()!;

    if (dicionarioBandas.ContainsKey(nomeDaBanda)) {
        Console.Write($"Digite a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!);
        dicionarioBandas[nomeDaBanda].Add(nota);
        Thread.Sleep(2000);
        Console.WriteLine("A nota da banda foi atribuida com sucesso");
        Console.WriteLine("Digite qualquer tecla para sair");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();

    } else {
        Console.WriteLine($"A banda {nomeDaBanda} não esta registrada");
        Console.WriteLine("Digite qualquer tecla para sair");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesMenu();
    }
}
void Mediadenotas()
{
    Console.Clear();
    ExibeOTituloDasOpcoes("Media de notas de uma banda");
    Console.WriteLine("Escreva o nome da banda para obter a média de suas notas: ");
    string nomeDaBanda = Console.ReadLine()!;
    
    if (dicionarioBandas.ContainsKey(nomeDaBanda)) 
    {
        List<int> lista = dicionarioBandas[nomeDaBanda];
        Console.WriteLine($"A média da banda {nomeDaBanda} é : {lista.Average()}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else {
            Console.WriteLine("Banda não encontrada, digite qualquer tecla para voltar para o menu principal");  
            Console.ReadKey();
            Console.Clear();
            ExibirOpcoesMenu();
          }
}
void saindo() {
    Console.WriteLine(@"

█▄▄ █▄█ █▀▀   █▄▄ █▄█ █▀▀
█▄█ ░█░ ██▄   █▄█ ░█░ ██▄
");
}
ExibirOpcoesMenu();