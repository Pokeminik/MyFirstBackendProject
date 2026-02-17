using MyFirstAsyncApp;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        List<string> users = ["Ivan", "Oleg"];
        users.Add("Dmitro");
        Console.WriteLine("Починаю завантаження даних...");

        string data = await FetchDataFromInternet();

        Console.WriteLine($"Дані отримано: {data}");

        foreach (var user in users)
        {
            Console.WriteLine($"Користувач: {user.ToUpper()}");
        }

        List<DriverLicense> licenses = new List<DriverLicense>
        {
        new DriverLicense { Id = 1, FirstName = "Ivan", LastName = "Sirko", Category = "B", IssueDate = new DateTime(2020, 05, 10) },
        new DriverLicense { Id = 2, FirstName = "Oleg", LastName = "Honchar", Category = "C", IssueDate = new DateTime(2021, 08, 22) },
        new DriverLicense { Id = 3, FirstName = "Dmitro", LastName = "Kozak", Category = "B", IssueDate = new DateTime(2019, 11, 01) }
        };

        var categoryB = licenses.Where(l => l.Category == "B").ToList();
        var id2 = licenses.FirstOrDefault(l => l.Id == 2);

        Console.WriteLine("Водії з категорією B:");

        foreach (var lic in categoryB)
        {
            Console.WriteLine($"{lic.FirstName} {lic.LastName}");
        }
        Console.WriteLine($"Водій з ID2: {id2.FirstName} {id2.LastName}");
    }

    static async Task<string> FetchDataFromInternet()
    {
        await Task.Delay(2000);
        return "Успіх";
    }
}