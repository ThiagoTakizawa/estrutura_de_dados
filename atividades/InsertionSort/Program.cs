﻿using System.Reflection.Metadata;
using AtvOrdenacao;

string[] names = new string[3]{"Thiago", "Seiji", "Takizawa"};

AtvOrdenacao.InsertionSort.Sort(names);

foreach(string name in names)
    System.Console.WriteLine(name);