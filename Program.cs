using System.Text.Json;
using Exercicio_Desafio.Consultas;
using Exercicio_Desafio.Mapeamentos;

using (HttpClient httpClient = new HttpClient())
{
    string jsonUrl = "https://raw.githubusercontent.com/arthurhardman/PetHouseAPI/master/Boletim";
    string githubToken = "x";
    httpClient.DefaultRequestHeaders.Add("Authorization", $"token {githubToken}");

    try
    {
        string resposta = await httpClient.GetStringAsync(jsonUrl);
        var consultasMapeamento = JsonSerializer.Deserialize<List<Mapeamento>>(resposta)!;

        var consultas = consultasMapeamento.Select(c => new Consulta(c.NomeAluno, c.NomeMateria, c.NomeProfessor, c.Nota, c.Serie, c.Sexo, c.Telefone));


    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Erro na requisição HTTP: {ex.Message}");
    }
}
