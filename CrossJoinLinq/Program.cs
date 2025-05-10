using CrossJoinLinq;
using System;
using System.Linq;

//Example1: Cross Join Using Query Syntax
var CrossJoinResult = from employee in Student.GetAllStudents()
                      from subject in Subject.GetAllSubjects()
                      select new
                      {
                          employee.Name,
                          subject.SubjectName
                      };

foreach (var item in CrossJoinResult)
{
    Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
}

Console.WriteLine(string.Empty);

//Example2: Cross Join using Method Syntax

//Cross Join using SelectMany Method
var CrossJoinResult2 = Student.GetAllStudents()
            .SelectMany(sub => Subject.GetAllSubjects(),
             (std, sub) => new
             {
                 std.Name,
                 sub.SubjectName
             });

foreach (var item in CrossJoinResult2)
{
    Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
}

Console.WriteLine(string.Empty);

//Cross Join using Join Method
var CrossJoinResult3 = Student.GetAllStudents()
            .Join(Subject.GetAllSubjects(),
                std => true,
                sub => true,
                (std, sub) => new
                {
                    std.Name,
                    sub.SubjectName
                }
             );

foreach (var item in CrossJoinResult3)
{
    Console.WriteLine($"Name : {item.Name}, Subject: {item.SubjectName}");
}

Console.ReadLine();