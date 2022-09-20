// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, ameba. CSVReader version 0.0.1");

string filename = "/home/user/Projects/CSVReader/employees.csv";

using (StreamReader reader = new StreamReader(filename))
{
    String? line;
    while ((line = reader.ReadLine()) !=null) {
            System.Console.WriteLine(line);
    }
}