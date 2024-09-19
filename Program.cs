using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "(99)9999-9999", modelo: "Nokia Tune", imei: "987654321", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero: "(88)98888-8888", modelo: "Pro Max 15", imei: "123456789", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");