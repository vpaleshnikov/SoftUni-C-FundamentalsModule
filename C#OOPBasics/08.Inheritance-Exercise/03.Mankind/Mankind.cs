using System;

public class Mankind
{
    public static void Main()
    {
        try
        {
            var studentInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            var studentFirstName = studentInfo[0];
            var studentLastName = studentInfo[1];
            var studentFacultyNumber = studentInfo[2];

            var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

            var workerInfo = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            var workerFirstName = workerInfo[0];
            var workerLastName = workerInfo[1];
            var workerWeekSalary = decimal.Parse(workerInfo[2]);
            var workerHoursPerDay = decimal.Parse(workerInfo[3]);

            var worker = new Worker(workerFirstName, workerLastName, workerWeekSalary, workerHoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException argumentException)
        {
            Console.WriteLine(argumentException.Message);
        }
    }
}