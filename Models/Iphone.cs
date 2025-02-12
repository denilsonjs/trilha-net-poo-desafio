namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone( string  numero ) : base (numero)
        {
            this.Numero = numero;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
       public override void InstalarAplicativo(string nomeApp)
       {
         Console.WriteLine("IOS Instalando Aplicativo "+ nomeApp );
       }

    }
}