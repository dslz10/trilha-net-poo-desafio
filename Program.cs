using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia");
Nokia aparelhoNokia = new Nokia("+5511996325682", "A25", "Numero imei", 64);
aparelhoNokia.Ligar();
aparelhoNokia.InstalarAplicativo("Whatsapp");
aparelhoNokia.InstalarAplicativo("Duolingo");

Console.WriteLine("Smartphone Iphone");
Iphone aparelhoIphone = new Iphone("+5511996325600", "13x", "Numero imei", 128);
aparelhoIphone.Ligar();
aparelhoIphone.InstalarAplicativo("Facebook");
aparelhoIphone.InstalarAplicativo("Instagram");