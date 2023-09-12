// See https://aka.ms/new-console-template for more information



using System.Collections;
{
    // A dictionary that takes an int as the key and a string as the value.
    Dictionary<int, string> topGames = new Dictionary<int, string>();
    topGames.Add(1, "Devil May Cry 5");
    topGames.Add(2, "The Witcher 3");
    topGames.Add(3, "Untel Dawn");
    topGames.Add(4, "Skyrim");
    topGames.Add(5, "Minecraft");
    topGames.Add(6, "The legend of Zelda Twilight Princess");
    topGames.Add(7, "Life is strange");
    topGames.Add(8, "Days gone");
    topGames.Add(9, "GTA 5");
    topGames.Add(10, "The Sims 4");
    // Loops through the topGames dictionary and print out each Key/Value pair on a new line.
    foreach (KeyValuePair<int, string> kvp in topGames)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }
    //  If the topGames contains key 1, if it does, it prints to console.
    if (topGames.ContainsKey(1))
    {
        Console.WriteLine($"My favorite game is: {topGames[1]}!");
    }
    // An empty string called result.
    string result = "";
    // Implements the TryGetValue method on topGames for key 11.
    topGames.TryGetValue(11, out result);
    // prints the result to console "There is no game in the eleventh position.".
    if (result != "")
    {
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("There is no game in the eleventh position.");
    }

    if (topGames.ContainsKey(5))
    {
        topGames[5] = "The Last of us";
    }
    // Prints the new value at key 5.
    Console.WriteLine(topGames[5]);

    Hashtable hashTable = new Hashtable(topGames);

    string favGame = (string)hashTable[1];

    Console.WriteLine($"Favorite Game: {favGame}");

    Hashtable capitals = new Hashtable() { 
        { "Oklahoma", "Oklahoma City" },
        { "New York", "Albany" },
        { "Texas", "Austain" },
        { "Ohio", "Colombus" },
    };
    // Loops through the capitals hashtable and print out the DictionaryEntry objects key and value on a new line.
    foreach (DictionaryEntry kvp in capitals)
    {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
    }
    // Clear all elements in the capitals hashtable.
    capitals.Clear();

}


