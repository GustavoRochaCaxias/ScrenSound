
class Musica
{
    public string Nome { get; set; }
    public string Artista {  get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"A musica {Nome} pertence a banda {Artista}";



    public void ExibirFichaTecnica() {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("A musica esta disponivel no plano");
        }
        else {
            Console.WriteLine("Adquira o plano Plus+");  
        }
        Console.WriteLine("------------------------------------");  
    }
}

