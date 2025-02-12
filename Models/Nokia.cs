namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia( string  numero ) : base (numero)
        {
            this.Numero = numero;
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
          Console.WriteLine("Android Instalando Aplicativo "+ nomeApp );            
        }
    }
}