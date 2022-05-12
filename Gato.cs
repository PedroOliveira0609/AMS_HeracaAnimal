namespace AMS_HerancaAnimal
{
    public class Gato : Animal
    {
        public string Mia = "Miau";

        public void gravarDados(string raca, string nome, int idade, string mia){
            this.Raca = raca;
            this._Nome = nome;
            this.Idade = idade;
            this.Mia = mia;
        }

        public void mostrarDados(){
            Console.WriteLine("-------------------------");
            Console.Write("A raça do gato é:");Console.WriteLine(this.Raca);
            Console.Write("O nome do gato é:");Console.WriteLine(this._Nome);
            Console.Write("A idade dele é:");Console.WriteLine(this.Idade);
            Console.Write("O que ele faz:");Console.WriteLine(this.Mia);
        }
    }
}