namespace AMS_HerancaAnimal
{
    public class Cachorro : Animal
    {
        public string Latir = "lati";

        public void gravarDados(string raca, string nome, int idade, string latir){
            this.Raca = raca;
            this._Nome = nome;
            this.Idade = idade;
            this.Latir = latir;
        }

        public void mostrarDados(){
            Console.Write("A raça do cachorro é:");Console.WriteLine(this.Raca);
            Console.Write("O nome do cachorro é:");Console.WriteLine(this._Nome);
            Console.Write("A idade do cachorro é:");Console.WriteLine(this.Idade);
            Console.Write("O que ele faz:");Console.WriteLine(this.Latir);
        }
    }
}