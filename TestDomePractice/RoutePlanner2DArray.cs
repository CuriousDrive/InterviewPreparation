using System;

public class RoutePlanner
{
    public static bool RouteExists(int fromRow, int fromColumn, int toRow, int toColumn,
                                      bool[,] mapMatrix)
    {
        int currentRow = fromRow;
        int currentColumn = fromColumn;
        if (!mapMatrix[currentRow, currentColumn])
            return false;

        while (true)
        {
            if (currentRow + 1 < mapMatrix.Length && mapMatrix[currentRow + 1, currentColumn])
            {
                currentRow++;
                if (currentRow == toRow && currentColumn == toColumn)
                    return true;
            }

            if (currentColumn + 1 < mapMatrix.Length && mapMatrix[currentRow, currentColumn + 1])
            {
                currentColumn++;
                if (currentRow == toRow && currentColumn == toColumn)
                    return true;
            }
        }
    }

    public static void Main2(string[] args)
    {
        bool[,] mapMatrix = {
            {true, false, false},
            {true, true, false},
            {false, true, true}
        };

        Console.WriteLine(RouteExists(0, 0, 2, 2, mapMatrix));
    }
}