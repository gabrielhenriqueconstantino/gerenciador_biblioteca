public class Livro
{
    public string Titulo { get; private set; }
    public string Autor { get; private set; }
    public int Ano { get; private set; }
    public string ISBN { get; private set; }
    public bool Disponivel { get; private set; }

    public Livro(string titulo, string autor, int ano, string isbn)
    {
        Titulo = titulo;
        Autor = autor;
        Ano = ano;
        ISBN = isbn;
        Disponivel = true;
    }

    public void MarcarComoEmprestado()
    {
        Disponivel = false;
    }

    public void MarcarComoDevolvido()
    {
        Disponivel = true;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Título: {Titulo}, Autor: {Autor}, Ano: {Ano}, ISBN: {ISBN}, Status: {(Disponivel ? "Disponível" : "Emprestado")}");
    }
}

