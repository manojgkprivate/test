using System;
using System.Collections.Generic;
using System.Linq;

class Employ
{
    public String name{get; set;}
    public String department{get; set;}

    public int salary {get;set;}
}


class Program
{
    static void Main()
    {
        List<Employ> employ = new List<Employ>
        {
            new Employ() { name = "mannoj", department = "IT", salary = 230000 },
new Employ() { name = "kiran", department = "HR", salary = 34000 },
new Employ() { name = "meena", department = "Support", salary = 160000 }

        };


        var result = employ.Where(e => e.department=="IT").OrderByDescending(e=>e.salary);
        foreach( var e in result)
        {
            Console.WriteLine("name: "+e.name+" and salary is "+e.salary);
        }
    }
}
