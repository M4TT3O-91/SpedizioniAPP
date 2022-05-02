using SpeditionLibrary;
using SpeditionLibrary.Entities;

var plico1 = new Plico("Giovanni","Roberto")
{
    Altezza = 10,
    Larghezza = 5,
    Valore = 100
};

var plico2 = new Plico("Giovanni", "Mario")
{
    Altezza = 10,
    Larghezza = 5,
    Valore = 100
};

var pacco1 = new Pacco("Lucia", "Anna")
{
    Altezza = 5,
    Larghezza = 20,
    Profondita = 5,
    Valore = 200
};

var pacco2 = new Pacco("Lucia", "Anna")
{
    Altezza = 5,
    Larghezza = 20,
    Profondita = 5,
    Valore = 200
};

Console.WriteLine($"Il pacco P1: {pacco1} è ugulae a Pacco P2 {pacco2}");
Console.WriteLine(pacco1.Equals(pacco2) ? "I pacchi sono uguali" : "I pacchi sono diversi");

var bartolini = new Corriere( "Bartolini");

bartolini.corriereList.Add(plico1);
bartolini.corriereList.Add(plico2);
bartolini.corriereList.Add(pacco1);
bartolini.corriereList.Add(pacco2);

bartolini.PrintSpedizioni();



Console.ReadLine();
