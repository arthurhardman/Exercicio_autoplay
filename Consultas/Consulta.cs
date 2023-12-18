namespace Exercicio_Desafio.Consultas;

public class Consulta
{
    public string NomeAluno { get; protected set; }
    public string NomeMateria { get; protected set; }
    public string NomeProfessor { get; protected set; }
    public string Serie { get; protected set; }
    public double Nota { get; protected set; }
    public string Telefone { get; protected set; }
    public SexoEnum Sexo { get; protected set; }

    public Consulta(string nomeAluno, string nomeMateria, string nomeProfessor, string nota,
     string serie, string sexo, string telefone)
    {
        SetNome(nomeAluno);
        SetNomeMateria(nomeMateria);
        SetNomeProfessor(nomeProfessor);
        SetNota(nota);
        SetSerie(serie);
        SetSexo(sexo);
        SetTelefone(telefone);
    }

    public void SetNome(string nomeAluno)
    {
        if (string.IsNullOrEmpty(nomeAluno))
        {
            throw new Exception("O nome não pode ser nulo");
        }

        NomeAluno = nomeAluno;
    }

    public void SetNomeMateria(string nomeMateria)
    {
        if (string.IsNullOrEmpty(nomeMateria))
        {
            throw new Exception("O nome não pode ser nulo");
        }

        NomeMateria = nomeMateria;
    }

    public void SetNomeProfessor(string nomeProfessor)
    {
        if (string.IsNullOrEmpty(nomeProfessor))
        {
            throw new Exception("O nome não pode ser nulo");
        }

        NomeProfessor = nomeProfessor;
    }

    public void SetSerie(string serie)
    {
        if (string.IsNullOrEmpty(serie))
        {
            throw new Exception("O nome não pode ser nulo");
        }

        Serie = serie;
    }

    public void SetNota(string nota)
    {
        Nota = double.Parse(nota);
    }

    public void SetTelefone(string telefone)
    {
        if (string.IsNullOrEmpty(telefone))
        {
            throw new Exception("O nome não pode ser nulo");
        }

        Telefone = telefone;
    }

    public void SetSexo(string sexo)
    {
        if (sexo == "Masculino")
        {
            Sexo = SexoEnum.Masculino;
        }
        else
        {
            Sexo = SexoEnum.Feminino;
        }
    }
}