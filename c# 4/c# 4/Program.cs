using System;
// using Website;
// using Magazine;
// using Shop;
// using System.ComponentModel.DataAnnotations;
// using System.Reflection;
// namespace nameof_Operator
// {
// class User
// {
//     public string Name{get;set;}
//     public int Age{get;set;}
//         public override string ToString()
//         {
//             return $"Name: {Name}, Age: {Age}";

//         }
//     }
// class Program
// {
//     static void Main(string[] args)
//     {
//         User user= new User(){Name="Bill",Age=21};
//         Console.WriteLine(user);
//         double cash =2.65;
//         Console.WriteLine(cash.ToString("C2"));

//     }
// }
// }









//задание1
// namespace Website
// {
//     class Website1
//     {
//         public string Title { get; set; }
//         public string URL { get; set; }
//         public string Opisanie { get; set; }
//         public string IP { get; set; }

//         public Website1() {}
//         public Website1(string title, string url, string opisanie, string ip)
//         {
//             Title = title;
//             URL = url;
//             Opisanie = opisanie;
//             IP = ip;
//         }
//         public override string ToString()
//         {
//             return $"Название: {Title}\n" +
//                    $"URL: {URL}\n" +
//                    $"Описание: {Opisanie}\n" + 
//                    $"IP: {IP}";               
//         }
//     }
//     class Vivod
//     {
//         static void Main(string[] args)
//         {
//             Website1 site = new Website1
//             {
//                 Title = "Primer",
//                 URL = "https://primer.com",
//                 Opisanie = "Opisanie",
//                 IP = "123.12.1.1"
//             };
//             Console.WriteLine(site);
//         }
//     }
// }








//задание 2
// namespace Magazine
// {
//     class Magazine1
//     {
//         public string Title { get; set; }
//         public string God { get; set; }
//         public string Opisanie { get; set; }
//         public string Telephone { get; set; }
//         public string Email { get; set; }

//         public Magazine1() {}
//         public Magazine1(string title, string god, string opisanie, string telephone,string email)
//         {
//             Title = title;
//             God = god;
//             Opisanie = opisanie;
//             Telephone = telephone;
//             Email = email;
//         }
//         public override string ToString()
//         {
//             return $"Название: {Title}\n" +
//                    $"Год основания: {God}\n" +
//                    $"Описание: {Opisanie}\n" + 
//                    $"Телефон: {Telephone}\n" +
//                    $"Email: {Email}";               
//         }
//     }
//     class Vivod
//     {
//         static void Main(string[] args)
//         {
//             Magazine1 site = new Magazine1
//             {
//                 Title = "Primer",
//                 God = "21.07.1983",
//                 Opisanie = "Opisanie",
//                 Telephone = "12345678231",
//                 Email = "primer@gmail.com"
//             };
//             Console.WriteLine(site);
//         }
//     }
// }






//задание 3
// namespace Shop
// {
//     class Shop1
//     {
//         public string Title { get; set; }
//         public string Address { get; set; }
//         public string Opisanie { get; set; }
//         public string Telephone { get; set; }
//         public string Email { get; set; }

//         public Shop1() {}
//         public Shop1(string title, string address, string opisanie, string telephone,string email)
//         {
//             Title = title;
//             Address = address;
//             Opisanie = opisanie;
//             Telephone = telephone;
//             Email = email;
//         }
//         public override string ToString()
//         {
//             return $"Название: {Title}\n" +
//                    $"Адресс: {Address}\n" +
//                    $"Описание: {Opisanie}\n" + 
//                    $"Телефон: {Telephone}\n" +
//                    $"Email: {Email}";               
//         }
//     }
//     class Vivod
//     {
//         static void Main(string[] args)
//         {
//             Shop1 site = new Shop1
//             {
//                 Title = "Primer",
//                 Address = "Primer addressa",
//                 Opisanie = "Opisanie",
//                 Telephone = "12345678231",
//                 Email = "primer@gmail.com"
//             };
//             Console.WriteLine(site);
//         }
//     }
// }