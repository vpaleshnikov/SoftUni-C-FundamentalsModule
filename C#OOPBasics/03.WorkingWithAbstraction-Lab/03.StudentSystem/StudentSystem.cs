using System;
using System.Collections.Generic;

public class StudentSystem
{
    private Dictionary<string, Student> repo;

    public StudentSystem()
    {
        this.repo = new Dictionary<string, Student>();
    }

    public Dictionary<string, Student> Repo
    {
        get { return repo; }
        private set { repo = value; }
    }

    public void ParseCommand(string command, Action<string> printFuction)
    {
        var input = command.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

        if (input[0] == "Create")
        {
            Create(input[1], input[2], input[3]);
        }
        else if (input[0] == "Show")
        {
            var name = input[1];
            if (repo.ContainsKey(name))
            {
                printFuction(repo[name].ToString());
            }
        }
    }
    
    private void Create(string name, string ageString, string gradeString)
    {
        var age = int.Parse(ageString);
        var grade = double.Parse(gradeString);
        if (!repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            repo[name] = student;
        }
    }
}