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
    }

    static async Task<string> FetchDataFromInternet()
    {
        await Task.Delay(2000);
        return "Успіх";
    }
}