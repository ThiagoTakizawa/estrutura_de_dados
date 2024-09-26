//Diferente da HashTable , o Dictionary nos permite especificar o tipo de dado que será utilizado nos pares Key - Value
//Isso nos fornece uma estrutura fortemente tipada

using Dicionário;

Dictionary<string, string> dictionary = new Dictionary<string, string>()
{
    {"Key 1", "Value 1"},
    {"Key 2", "value 2"}
};

//Obtero valor do dictionary
string val = dictionary["Key 1"];

try
{
    val = dictionary["Key 3"];
}
catch (Exception ex)
{
    Console.WriteLine("Erro ao obter valor da Key 3");
    Console.WriteLine(ex.Message);
}

//Verificando se a chave existe antes de acessar para evitar erros e prejuízos de execução
if(dictionary.ContainsKey("Key 2"))
{
    
}

//Outra forma de obter o valor e evitar o erro
dictionary.TryGetValue("Key 4", out string? valor);
if(valor is not null)
{
    Console.WriteLine($"Chave 2: {dictionary["Key 4"]}");
}

//Podemos adicionar da mesma forma pela chave inexistente
dictionary["Key 0"] = "Valor 0";

//Percorrer o Dictionary
foreach(KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine($"{kvp.Key}:{kvp.Value}");
}

//Utilizando tipos abstratos de dados com Dictionary

Dictionary<int, Pessoa> dicPessoa = new Dictionary<int, Pessoa>();

dicPessoa.Add(1, new Pessoa(){Id = 0, BirthDate = new DateTime(1984, 7, 5), Name = "Mauricio Roberto Gonzatto"});
dicPessoa.Add(1, new Pessoa(){Id = 0, BirthDate = new DateTime(2001, 5, 16), Name = "Marco Antonio"});

foreach(KeyValuePair<int, Pessoa> kvp in dicPessoa)
{
    Console.WriteLine(kvp.Key);
    Console.WriteLine(kvp.Value.Name);
    Console.WriteLine(kvp.Value.Id);
    Console.WriteLine(kvp.Value.BirthDate);   
}