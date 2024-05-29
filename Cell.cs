using System.Xml;

namespace CellularAutomata;

public class Cell 
{
    public string Neighborhood { get; set; }
    public string NewState { get; set; }
    public static Dictionary<string, string> Rules = new Dictionary<string, string> {
        {"111", "0"},
        {"110", "1"},
        {"101", "0"},
        {"100", "1"},
        {"011", "1"},
        {"010", "0"},
        {"001", "1"},
        {"000", "0"},
    };
    public Cell (string neighborhood) {
        Neighborhood = neighborhood;
        NewState = SetNewState(neighborhood);
    }  
    public string SetNewState(string neighborhood) {
        if (Rules.TryGetValue(neighborhood, out string newState)) 
        {
            return newState;
        }
        else
        {
            throw new ArgumentException("Padrão inválido", nameof(neighborhood));
        }
    }

    public override string ToString()
    {
        if (Neighborhood[1] == '1') 
        {
            Console.BackgroundColor = ConsoleColor.White;
        }
        else {
            Console.BackgroundColor = ConsoleColor.Black;
        }
        return "";
    }
}