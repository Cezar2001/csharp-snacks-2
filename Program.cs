using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Scrivere un codice csharp che crea un accumulatore e poi lo utilizza
//Esempio: var accumulatore1 = CreaAccumulatore();
//accumulatore1(10) => 10
//accumulatore1(40) => 50
//accumulatore1(90) => 140

var Maker = () =>
{
    long totale = 0;
    return (int n) =>
    {
        totale += n;
        return totale;
    };
};
var acc1 = Maker();
var acc2 = Maker();
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc1(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));
Console.WriteLine(acc2(10));

var somma = (int n) => { n++; Console.WriteLine(n); };
somma(9);



Console.WriteLine("\n");
//Data una lista di interi, metterli tutti al quadrato
List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
List<int> lsquare = AlQuadrato(list);
foreach (int n in lsquare)
{
    Console.WriteLine(n);
}


List<int> AlQuadrato(List<int> lsquare)
{
    List<int> lout = new List<int>();
    foreach (int n in list)
    {
        lout.Add(n * n);
    }
    return lout;
}


Console.WriteLine("\n");
//Realizzare un metodo che esegue l'elevamento al cubo
List<int> lCube = AlCubo(list);
foreach (int n in lCube)
{
    Console.WriteLine(n);
}

List<int> AlCubo(List<int> list)
{
    List<int> lout = new List<int>();
    foreach (int n in list)
    {
        lout.Add(n * n * n);
    }
    return lout;
}



Console.WriteLine("\n");
List<int> EseguiIlCalcolo(List<int> list, Func<int, int> fun)
{
    List<int> lout = new List<int>();
    foreach (int n in list)
        lout.Add(fun(n));
    return lout;
}

Console.WriteLine("\n");

int MettiAllaQuinta(int i)
{
    return i * i * i * i * i;
}

Console.WriteLine("\n");

List<int> lquinta = EseguiIlCalcolo(list, MettiAllaQuinta);
foreach (int n in lquinta)
    Console.WriteLine(n);


Console.WriteLine("\n");
List<int> lcalcolo = EseguiIlCalcolo(list, (n) => n * (n + 1) / 2);
foreach (int n in lcalcolo)
    Console.WriteLine(n);

//Abbiamo in questo modo costruito una funzione "generale" per trasformare
//tutti gli elementi di una stringa da numero intero a numero intero => nuovo = f(vecchio);
//Purtroppo per come è stata costruita, questa funzione si applica esclusivamente alle lista di numeri interi 
//e torna una lista di numeri interi


Console.WriteLine("\n");
//Se invece avessi voluto data una lista di stringhe, ottenere una lista delle loro lunghezze
List<string> ls = new List<string>() { "uno", "due", "tre", "quattro", "cinque"};

List<int> EseguiIlCalcoloStringa(List<string> list, Func<string, int> fun)
{
    List<int> lout = new List<int>();
    foreach (string n in list)
        lout.Add(fun(n));
    return lout;
}

var lslen = ls.Select( s => s.Length);

foreach (int n in lslen)
    Console.WriteLine(n);


Console.WriteLine("\n");
//alternativa quadrato
var listaDeiQuadrati = list.Select(n => n * n);
foreach(int n in listaDeiQuadrati)
    Console.WriteLine(n);



Console.WriteLine("\n");
//Question??
//Data una lista di interi, estrarre dalla lista tutti i numeri pari
List<int> EstraiPari(List<int> lista)
{
    List<int> listaPari = new List<int>();
    foreach(int i in list)
        if ((i % 2) == 0)
            listaPari.Add(i);
    return listaPari;
}

List<int> listaPari = EstraiPari(list);
foreach (int n in listaPari)
    Console.WriteLine(n);


Console.WriteLine("\n");
//alternativa numeri pari (best practice)
var lPari = list.Where(n => (n % 2) == 0);
foreach (int n in lPari)
    Console.WriteLine(n);


Console.WriteLine("\n");
//alternativa numeri pari con la Select
var lpari = list.Select(n =>
{
    if ((n % 2) == 0)
    {
        return n;
    }
    else
    {
        return -1;
    }
});


Console.WriteLine("\n");
//ordinare una lista di interi
list = new List<int>() { 3, 22, 34, 45, 15, 60, 8, 2, 91 };
list.Sort();
list.Reverse();  //sort e reverse vanno insieme per fare un ordine decrescente
foreach (int n in list)
    Console.WriteLine(n);


Console.WriteLine("\n");
//ordina una lista di stringhe
//ordinamento crescente
list = new List<int>() { 3, 22, 34, 45, 15, 60, 8, 2, 91 };
list.Sort((int v1, int v2) =>
{ 
   if (v1 < v2)
        return -1;
   if ( v1 == v2)
        return 0;
   else
        return 1;
});
foreach (int n in list)
    Console.WriteLine(n);


Console.WriteLine("\n");
//ordinamento decrescente
list = new List<int>() { 3, 22, 34, 45, 15, 60, 8, 2, 91 };
list.Sort((int v1, int v2) =>
{
    if (v1 < v2)
        return 1;
    if (v1 == v2)
        return 0;
    else
        return -1;
});
foreach (int n in list)
    Console.WriteLine(n);



Console.WriteLine("\n");
//Data la lista di stringhe {"uno", "due", "tre", "quattro", "cinque", "sei"}
//ordinala e stampala in modo decrescente
List<string> listString = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };
listString.Sort();
listString.Reverse(); //ordine opposto
foreach (string s in listString)
    Console.WriteLine(s);


Console.WriteLine("\n");
//alternativa ordine stringa
listString = new List<string>() { "uno", "due", "tre", "quattro", "cinque", "sei" };
listString.Sort((string s1, string s2) => -s1.CompareTo(s2));

foreach (string s in listString)
    Console.WriteLine(s);


//Esercizio finale
//Data una lista di coppie <DateTime, int>,
//stampale ordinate rispetto alla stringa
//una coppia in csharp si dichiara come
//Tuple<string, int> quindi una lista di coppie sarà
List<Tuple<string, int>> lcoppie = new List<Tuple<string, int>>()
{
    new Tuple<string, int> ("uno", 1),
    new Tuple<string, int> ("due", 2),
    new Tuple<string, int> ("otto", 8),
    new Tuple<string, int> ("dodici", 12),
    new Tuple<string, int> ("venti", 20),
};

listString.Sort((string s1, string s2) => -s1.CompareTo(s2));




double microseconds = DateTime.Now.Ticks / (TimeSpan.TicksPerMillisecond / 10000);
Console.WriteLine("microseconds: {0}", microseconds);