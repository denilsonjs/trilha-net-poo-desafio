using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
class Program
{
    static void Main(string[] args)
    {
        Nokia tel1 = new Nokia("123456");

        tel1.Ligar();
        tel1.ReceberLigacao();
        tel1.InstalarAplicativo("Telegram");

        Iphone tel2 = new Iphone("67890");
        tel2.Ligar();
        tel2.ReceberLigacao();
        tel2.InstalarAplicativo("Instagram");

    }    

}