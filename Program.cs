using CellularAutomata;

int[] neighborhood = new int[3];
Generation generation = new Generation();

generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("001"));
generation.AddCell(new Cell("010"));
generation.AddCell(new Cell("100"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));
generation.AddCell(new Cell("000"));

Generation secondGeneration = generation.NextGeneration();
Generation thirdGeneration = secondGeneration.NextGeneration();
Generation fourthGeneration = thirdGeneration.NextGeneration();
Generation fifthGeneration = fourthGeneration.NextGeneration();
Generation sixthGeneration = fifthGeneration.NextGeneration();
Generation seventhGeneration = sixthGeneration.NextGeneration();
Generation eighthGeneration = seventhGeneration.NextGeneration();

List<Generation> generations = new List<Generation>{
    generation,
    secondGeneration,
    thirdGeneration,
    fourthGeneration,
    fifthGeneration,
    sixthGeneration,
    seventhGeneration,
    eighthGeneration,
};

foreach (Generation currentGeneration in generations) {
    foreach (Cell cell in currentGeneration.Cells) {
        Console.Write(cell + " ");
    }
    Console.WriteLine();
}
