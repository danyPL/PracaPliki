Console.WriteLine("Podaj ścieżkę pliku: ");
string path = Console.ReadLine();


if (File.Exists(path))
{
    if (Path.GetExtension(path) == ".txt")
    {
        StreamReader sr = new StreamReader(path);
        string data = sr.ReadToEnd();
        sr.Close();
        Console.WriteLine(data);
    }
    
}
else
{
    StreamWriter sr = new StreamWriter(path);

    // Zapisuje tresc uzytkownika do pliku
    Console.WriteLine("Co chcialbys napisac w pliku?");
    string data = " ";

    while (!(data.EndsWith("END;;")))
    {
        sr.WriteLine(data);
        data = Console.ReadLine();

    }
    sr.Close();
}

// Tutaj praca na 6
Console.WriteLine("Podaj katalog który ma zostać wyswietlony");
string path2 = Console.ReadLine();
string[] dirs = Directory.GetFileSystemEntries(path2);
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}