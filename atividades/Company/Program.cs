﻿using System.ComponentModel;
using Company;

Tree <Person> company = new Tree<Person> ();
company.Root = new TreeNode<Person> ()
{
    Data = new Person (100, "Marcin Jamro", "CEO"),
    Parent = null
};
company.Root.Children = new List<TreeNode<Person>> ()
{
    Data = new Person (1, "John Smith", "Head of Development"),
    Parent = company.Root
}