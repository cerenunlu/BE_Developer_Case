using System;
using System.IO;
// using Newtonsoft;
// using Newtonsoft.Json;
using System.Text.Json;
using System.Collections.Generic;
namespace KaizenJson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ReadFile();
        }

         public static void ReadFile(){
         string dosya_yolu=@"C:\Users\MSI PC\Desktop\response.json.rtf";
         String st=File.ReadAllText(dosya_yolu);
        
       var list = JsonSerializer.Deserialize<List<Test>>(st);
      foreach (var item in list)
      {
          Console.WriteLine(item.description);
         
      }
      
        }
    }
    public class Test{
        public string locale {get;set;}
        public string description {get;set;}
       
    }
}
