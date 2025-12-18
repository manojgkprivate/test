using System;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json.Nodes;
using Newtonsoft.Json;

class Program
{
    static void Main()
    {
        string inputfile = @"D:/dotnet-project/helloword/input.txt";
        string outputfile = @"D:/dotnet-project/helloword/output.json";

        if(!File.Exists(inputfile))
        {
            Console.WriteLine("the file path dont exites");
            return;
        }

        string content = File.ReadAllText(inputfile);

        Console.WriteLine("the contetn is");
        Console.WriteLine("-------------------");
        Console.WriteLine(content);


        var jsondata= new
        {
            filename= inputfile,
            textcontent = content,
            savedon= DateTime.Now 
        };


        string jsonstring = JsonConvert.SerializeObject(jsondata,Formatting.Indented);
        
        File.WriteAllText(outputfile, jsonstring);



    }

}
