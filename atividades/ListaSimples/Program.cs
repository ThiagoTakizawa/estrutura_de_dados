using System.Collections;

//Utilizando a lista simples
ArrayList arrList = new (); //new ArrayList();
arrList.Add (5);
arrList.Add ("Maurício");
//É possível adicionar um conjunto de valores de uma vez
arrList.AddRange (new int[] {1,2,3});
//Método .Add() insere o valor ao final do vetor
arrList.Insert (1, 15);
//Já o método insert, me permite incluir o valor desejado na posição especificada no primeiro parâmetro

//Lendo valores da lista
object primeiro = arrList [0]!;
int quarto = (int)arrList [3]!;

//Percorrendo a lista com foreach
foreach(object obj in arrList)
{
    Console.Write($"  | {obj}");
}

//Obtendo o tamanho total da lista, quantos elementos tem
int tamanho = arrList.Count;
//Obter a capacidade, quantos podem ser armazenados
int capacidade = arrList.Capacity;

//Percorrendo no modo clássico
for(int i = 0; i < arrList.Count; i++)
{
    Console.Write($" | {arrList[i]}");
}

//Recursos importantes da lista
//Verificar se um valor é contido na lista
bool contemNome = arrList.Contains ("Maurício");
if(!contemNome)
    Console.WriteLine("Nome Maurício não encontrado");

//Para saber  o índice que contém o valor buscado
//Neste caso se o valor existir, ele retorna o índice (número inteiro), caso o valor não exista na lista retorna -1

int indiceDoValor = arrList.IndexOf ("Maurício");
if(indiceDoValor >= 0)
    Console.WriteLine($"Maurício está em [{indiceDoValor}]");
else
    Console.WriteLine("É realmente não tem");

//É possível remover itens da lista
arrList.Remove ("Maurício"); //Remove pelo valor
arrList.RemoveAt (4); //Remove no índice
arrList.RemoveRange(0,2); //O primeiro parâmetro é o índice, o segundo é quantas casas após o índice