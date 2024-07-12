namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string capacidade) : base(numero, modelo, imei, capacidade)
        {
           
            Capacidade = capacidade;
        }
        
        public string Capacidade { get; set; }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no iPhone.");
        }
    }
}