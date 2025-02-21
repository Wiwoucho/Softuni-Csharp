using System;
using System.Runtime.InteropServices;


int numSongs = int.Parse(Console.ReadLine());
List<Songs> songs = new List<Songs>();

for (int i = 0;  i < numSongs;  i++)
{
    string[] data = Console.ReadLine().Split("_");

    string type = data[0];
    string name = data[1];
    string time = data[2];

    Songs song = new Songs();

    song.TypeList = type;
    song.Name = name;
    song.Time = time;

    songs.Add(song);
}

string typeList = Console.ReadLine();


List<Songs> filteredSongs = songs.Where(s => s.TypeList == typeList ? typeList != "all" : typeList == "all").ToList();


foreach (Songs song in filteredSongs)
{
    Console.WriteLine(song.Name);
}
class Songs
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }
}

