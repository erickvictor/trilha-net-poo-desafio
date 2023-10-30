using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "92981445050", modelo: "5320", imei: "1234567890123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Skype");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "92981774545", modelo: "iPhone 12", imei: "0123456789012", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");