﻿using System;
using System.Text;

public class Book
{
    private string author;
    private string title;
    private decimal price;

    public string Author
    {
        get { return this.author; }
        set
        {
            var authorName = value.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            if (authorName.Length > 1 && char.IsDigit(authorName[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            this.author = value;
        }
    }

    public string Title
    {
        get { return this.title; }
        set
        {
            if (value?.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            this.title = value;
        }
    }

    public virtual decimal Price
    {
        get { return this.price; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }
            this.price = value;
        }
    }

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;
    }

    public override string ToString()
    {
        var resultBuilder = new StringBuilder();
        resultBuilder.AppendLine($"Type: {this.GetType().Name}")
            .AppendLine($"Title: {this.Title}")
            .AppendLine($"Author: {this.Author}")
            .AppendLine($"Price: {this.Price:F2}");

        string result = resultBuilder.ToString().TrimEnd();
        return result;
    }

}