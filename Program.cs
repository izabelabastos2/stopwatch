using System.Threading;



Menu();

static void Menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("M = Minuto => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.WriteLine("Quanto deseja contar?");

    string usr_data = Console.ReadLine().ToLower();
    //Definir o dado para um caracter apenas utiliza-se o char
    //queremos pegar o último dígito que o usr digitou
    //todo dado do tipo String possui uma função de acesso
    //ao seu subtipo chamada: Substring, que pega uma parte da cadeia
    //de caracteres que compõe o dado.
    //Deve-se passar como argumento o valor inicial e segundo a
    //quantidade de caracteres que queremos pegar
    int penultimo_caracter = usr_data.Length - 1;
    char type = char.Parse(usr_data.Substring(penultimo_caracter, 1));

    //do caracter 0 pega tds os outros caracteres menos 1
    int time = int.Parse(usr_data.Substring(0, usr_data.Length - 1));
    Console.WriteLine(time);
    Console.WriteLine(type);

    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;


    if (time == 0)
        System.Environment.Exit(0);

    PreStart(time * multiplier);
}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Ready...");
    Thread.Sleep(1000);
    Console.WriteLine("Set...");
    Thread.Sleep(1000);
    Console.WriteLine("Go...");
    Thread.Sleep(2400);
    Start(time);

}
static void Start(int time)
{

    int currentTime = 0;
    while (currentTime != time)
    {
        Console.Clear();
        currentTime++;
        Console.WriteLine(currentTime);

        //esperar 1 segundo antes da prox. iteração
        //dormir em milisegundos
        Thread.Sleep(1000);
    }

    Console.Clear();
    Console.WriteLine("Stopwatch finalizado");
    Thread.Sleep(2400);

    Menu();
}
