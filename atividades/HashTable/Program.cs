﻿//Exemplo de uma agenda telefônica

using System.Collections;

Hashtable phoneBook = new Hashtable()
{
    { "Thomazzi", "49-9961-0150" },     // "Chave", "Valor"
    { "Mauricio Gonzatto", "49-99975-8575" },
    {"Gabriel Bianchi", "49-99105-8904" },
};

//É possível adicionar elementos de diversas formas, pelo prórpio índice chave inexistente
phoneBook["Thiago Padilha"] = "49-99176-8255";

//Ou pelo método Add()
phoneBook.Add("Marcos Henrique", "49-99202-6129");

//Entretanto , a HashTable verifica se há duplicidade de chave e pode lançar uma Exception
try
{
    phoneBook.Add("Mauricio Gonzatto", "49-99975-8575");
}catch(Exception ex)
{
    Console.WriteLine($"Erro ao tentar incluir o valor repetido.");
    Console.WriteLine(ex.Message);
    throw ex;
}

//Percorrendo itens da HashTable
Console.WriteLine("Agenda Telefônica");
if(phoneBook.Count == 0)
{
    Console.WriteLine("A agenda está vazia.");
}
else
{
    foreach(DictionaryEntry entry in phoneBook)
    {
        Console.WriteLine($"{entry.Key}:{entry.Value}");     //Uma instrução não precisa de chaves
    }
}