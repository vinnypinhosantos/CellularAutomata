using System.Dynamic;

namespace CellularAutomata;

public class Generation 
{
    public List<Cell> Cells { get; set;}
    public Generation () 
    {
        Cells = new List<Cell>{};
    }
    public void AddCell(Cell cell) 
    {
        Cells.Add(cell);
    }
    public Generation NextGeneration() 
    {
        var currentStates = new List<string>{};
        var newStates = new List<Cell>{};
        foreach (Cell cell in Cells)
        {
            currentStates.Add(cell.NewState);
        }
        for (int i = 0; i <= currentStates.Count - 1; i++) {
            if (i == 0) 
            {
                var neighborhood = "0" +currentStates[i] + currentStates[i+1];
                newStates.Add(new Cell(neighborhood));
            }
            else if (i == currentStates.Count - 1) 
            {
                var neighborhood = currentStates[i-1] + currentStates[i] + "0";
                newStates.Add(new Cell(neighborhood));
            }            
            else 
            {
                var neighborhood = currentStates[i-1] + currentStates[i] + currentStates[i + 1];
                newStates.Add(new Cell(neighborhood));
            }
        }
        var nextGeneration = new Generation
        {
            Cells = newStates
        };
        return nextGeneration; 
    }
}