using LeftJoinLinq;
using System;
using System.Linq;

// Left Outer Join using Query Syntax
var QSOuterJoin = from emp in Employee.GetAllEmployees()
                  join add in Address.GetAddress()
                  on emp.AddressId equals add.ID
                  into EmployeeAddressGroup
                  from address in EmployeeAddressGroup.DefaultIfEmpty()
                  select new { emp, address };

foreach (var item in QSOuterJoin)
{
    Console.WriteLine($"Name : {item.emp.Name}, Address : {item.address?.AddressLine} ");
}

Console.WriteLine(string.Empty);

// Left Outer Join in Linq using Method Syntax
var MSOuterJOIN = Employee.GetAllEmployees()
                             .GroupJoin(
                                   Address.GetAddress(),
                                   emp => emp.AddressId,
                                   add => add.ID,
                                   (emp, add) => new { emp, add }
                             )
                             .SelectMany(
                                   x => x.add.DefaultIfEmpty(),
                                   (employee, address) => new { employee, address }
                              );

foreach (var item in MSOuterJOIN)
{
    Console.WriteLine($"Name : {item.employee.emp.Name}, Address : {item.address?.AddressLine} ");
}

Console.ReadLine();
