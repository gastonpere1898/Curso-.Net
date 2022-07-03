// Crear una clase Billetera que tenga las siguientes propiedades públicas del tipo entero:

//BilletesDe10
//BilletesDe20
//BilletesDe50
//BilletesDe100
//BilletesDe200
//BilletesDe500
//BilletesDe1000

//Agregar un método que se llame Total del tipo decimal, y que devuelva el Importe Total en la billetera
//teniendo en cuenta la cantidad de billetes que se tenga de cada tipo.

//Agregar un metodo que se llame Combinar, que reciba como parámetro otra billetera y que devuelva una nueva
//Billetera con la suma o combinacion del dinero de ambas billeteras.  
//Una vez combinadas las 2 billeteras (y creada la tercera), las 2 primeras billeteras deberan quedar en cero. (Sin billetes)
using Clase13_EJ_obligatorio.Modelo;

var billetera1 = new Billetera()
{
    BilletesDe10 = 1,
    BilletesDe20 = 1,
    BilletesDe50 = 1,
    BilletesDe100 = 1,
    BilletesDe200 = 1,
    BilletesDe500 = 1,
    BilletesDe1000=1
};

var billetera2 = new Billetera()
{
    BilletesDe10 = 1,
    BilletesDe20 = 1,
    BilletesDe50 = 1,
    BilletesDe100 = 1,
    BilletesDe200 = 1,
    BilletesDe500 = 1,
    BilletesDe1000 = 1
};





Console.WriteLine("La billetera 1 tiene:");
Console.WriteLine(billetera1.BilletesDe10 + " billetes de 10");
Console.WriteLine(billetera1.BilletesDe20 + " billetes de 20");
Console.WriteLine(billetera1.BilletesDe50 + " billetes de 50");
Console.WriteLine(billetera1.BilletesDe100 + " billetes de 100");
Console.WriteLine(billetera1.BilletesDe200 + " billetes de 200");
Console.WriteLine(billetera1.BilletesDe500 + " billetes de 500");
Console.WriteLine(billetera1.BilletesDe1000 + " billetes de 1000");
Console.WriteLine($"La cantidad de dinero es: {billetera1.Total()}");

Console.WriteLine("________________________________________________________");

Console.WriteLine("La billetera 2 tiene:");
Console.WriteLine(billetera2.BilletesDe10 + " billetes de 10");
Console.WriteLine(billetera2.BilletesDe20 + " billetes de 20");
Console.WriteLine(billetera2.BilletesDe50 + " billetes de 50");
Console.WriteLine(billetera2.BilletesDe100 + " billetes de 100");
Console.WriteLine(billetera2.BilletesDe200 + " billetes de 200");
Console.WriteLine(billetera2.BilletesDe500 + " billetes de 500");
Console.WriteLine(billetera2.BilletesDe1000 + " billetes de 1000");
Console.WriteLine($"La cantidad de dinero es: { billetera2.Total()}");

Console.WriteLine("________________________________________________________");

var billetera3 = billetera1.Combinar(billetera2);


Console.WriteLine($"La cantidad de dinero en la Billetera3 es: {billetera3.Total()}");
Console.WriteLine();
Console.WriteLine("la billetera 1 y billetera 2, quedo sin dinero:");
Console.WriteLine();
Console.WriteLine("La billetera 1 tiene:");
Console.WriteLine( billetera1.BilletesDe10 + " billetes de 10");
Console.WriteLine( billetera1.BilletesDe20 + " billetes de 20");
Console.WriteLine( billetera1.BilletesDe50 + " billetes de 50");
Console.WriteLine( billetera1.BilletesDe100 + " billetes de 100");
Console.WriteLine( billetera1.BilletesDe200 + " billetes de 200");
Console.WriteLine( billetera1.BilletesDe500 + " billetes de 500");
Console.WriteLine($"La cantidad de dinero es: {billetera1.Total()}");
Console.WriteLine();
Console.WriteLine("La billetera 2 tiene:");
Console.WriteLine( billetera2.BilletesDe10 + " billetes de 10");
Console.WriteLine( billetera2.BilletesDe20 + " billetes de 20");
Console.WriteLine( billetera2.BilletesDe50 + " billetes de 50");
Console.WriteLine( billetera2.BilletesDe100 + " billetes de 100");
Console.WriteLine( billetera2.BilletesDe200 + " billetes de 200");
Console.WriteLine( billetera2.BilletesDe500 + " billetes de 500");
Console.WriteLine( billetera2.BilletesDe1000 + " billetes de 1000");
Console.WriteLine($"La cantidad de dinero es: {billetera2.Total()}");


