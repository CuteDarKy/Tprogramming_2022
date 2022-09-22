﻿namespace CourseApp;

using System;

public class Country
{
    private double square;

    public Country(string name, string capital, double sq)
    {
        this.Name = name;
        this.Capital = capital;
        this.Square = sq;
    }

    public Country(string n, string cap)
    {
        this.Name = n;
        this.Capital = cap;
        Square = 1000;
    }

    public Country(string n)
    {
        this.Name = n;
        Capital = "Moscow";
        Square = 1000;
    }

    public string Name { get; set; }

    public string Capital { get; set; }

    public double Square
    {
        get
        {
            return square;
        }

        set
        {
            square = value;
        }
    }

    public void Print()
    {
        Console.WriteLine($"Название: {Name}  Столица: {Capital}  Площадь: {Square} км^2");
    }

    public void TheCapital()
    {
        Console.WriteLine($"The capital of {Name} is {Capital}");
    }

    public void Welcome()
    {
        Console.WriteLine($"Welcome to the {Name}! \n");
    }
}