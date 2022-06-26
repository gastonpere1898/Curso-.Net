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
    BilletesDe10 = 6,

};
var billetera2 = new Billetera()
{
    BilletesDe10 = 2
};





Console.WriteLine("La billetera 1 tiene:");
Console.WriteLine(billetera1.BilletesDe10 +" billetes de 10");


Console.WriteLine("________________________________________________________");

Console.WriteLine("La billetera 2 tiene:");
Console.WriteLine(billetera2.BilletesDe10 + " billetes de 10");

Console.WriteLine("________________________________________________________");

var billetera3 = billetera1.Combinar(billetera2);

Console.WriteLine("Entre las 2 billeteras hay:");
Console.WriteLine(billetera3.BilletesDe10 + " billetes de 10");