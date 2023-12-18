using System.Text.Json.Serialization;

namespace Exercicio_Desafio.Mapeamentos;

public class Mapeamento
{
    [JsonPropertyName("Aluno")]
    public string NomeAluno { get; set; }

    [JsonPropertyName("Matéria")]
    public string NomeMateria { get; set; }

    [JsonPropertyName("Professor")]
    public string NomeProfessor { get; set; }

    [JsonPropertyName("Série")]
    public string Serie { get; set; }

    [JsonPropertyName("Nota")]
    public string Nota { get; set; }

    [JsonPropertyName("Telefone")]
    public string Telefone { get; set; }

    [JsonPropertyName("Sexo")]
    public string Sexo { get; set; }
}