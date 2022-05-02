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
Console.WriteLine(pacco1.Equal(pacco2) ? "I pacchi sono uguali" : "I pacchi sono diversi");

var bartolini = new Corriere("Barolini");

bartolini.CorrList.Add(plico1);
bartolini.CorrList.Add(plico2);
bartolini.CorrList.Add(pacco1);
bartolini.CorrList.Add(pacco2);

bartolini.PrintSpedizioni();

Console.ReadLine();
