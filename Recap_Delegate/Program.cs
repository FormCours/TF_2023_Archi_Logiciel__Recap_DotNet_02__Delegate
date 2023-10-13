// Type de délégué pré-défini
// - Action    -> delegate void Action();
// - Func      -> delegate TResult Func<out TResult>()
// - Predicate -> delegate bool Predicate<in T>(T obj)

List<int> Rechercher1(List<int> nombre, Func<int, bool> del)
{
    List<int> result = new List<int>();

    foreach (int n in nombre)
    {
        if( del(n) )
        {
            result.Add(n);
        }
    }

    return result;
}

List<int> Rechercher2(List<int> nombre, Func<int, int, bool> alberto)
{
    List<int> result = new List<int>();

    for(int i = 0; (i < nombre.Count -1); i++)
    {
        if (alberto(nombre[i], nombre[2]))
        {
            result.Add(nombre[i]);
        }
    }

    return result;
}


string ConcatNumber(List<int> nombres)
{
    return string.Join(", ", nombres);
}

List<int> test = new List<int> { 5, 9, 6, 1, 2, 8, 10, 12, 22, 3, 13, 12 };
Console.WriteLine($"Valeur initial : {ConcatNumber(test)}");

List<int> r1 = Rechercher1(test, nb => nb % 2 == 0);
Console.WriteLine($"Paire : {ConcatNumber(r1)}");


List<int> r2 = Rechercher2(test, (v1, v2) => v1 > v2);
Console.WriteLine($"Plus Grand : {ConcatNumber(r2)}");

bool TestNombre(int nb1, int nb2)
{
    return nb1 < nb2;
}
List<int> r3 = Rechercher2(test, TestNombre);
Console.WriteLine($"Plus Petit : {ConcatNumber(r3)}");
