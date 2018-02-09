using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var departmentDict = new Dictionary<string, List<string>>();
            var doctorDict = new Dictionary<string, List<string>>();

            var department = string.Empty;
            var doctor = string.Empty;
            var patient = string.Empty;
            
            var room = 0;

            while (input != "Output")
            {
                var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                department = tokens[0];
                doctor = tokens[1] + " " + tokens[2];
                patient = tokens[3];

                if (!departmentDict.ContainsKey(department))
                {
                    departmentDict.Add(department, new List<string>());
                }
                departmentDict[department].Add(patient);

                if (!doctorDict.ContainsKey(doctor))
                {
                    doctorDict.Add(doctor, new List<string>());
                }
                doctorDict[doctor].Add(patient);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                var tokens = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length == 1)
                {
                    foreach (var patients in departmentDict[tokens[0]])
                    {
                        Console.WriteLine(patients);
                    }
                }
                else if (tokens.Length == 2)
                {
                    if (int.TryParse(tokens[1], out room))
                    {
                        department = tokens[0];
                        var patientsInRoom = departmentDict[department]
                            .Skip((room - 1) * 3)
                            .Take(3)
                            .OrderBy(a => a)
                            .ToList();

                        foreach (var patients in patientsInRoom)
                        {
                            Console.WriteLine(patients);
                        }
                    }
                    else
                    {
                        var patients = doctorDict[input]
                            .OrderBy(a => a)
                            .ToList();

                        foreach (var pat in patients)
                        {
                            Console.WriteLine(pat);
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}