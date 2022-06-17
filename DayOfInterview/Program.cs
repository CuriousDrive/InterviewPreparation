Console.WriteLine( TimeRequiredToBuy(new int[] {2,3,2}, 2));

int TimeRequiredToBuy(int[] tickets, int k) {
    
    int timeTaken = 0;
    int counter = 0;
    
    while(tickets[k] != 0)
    {
        if(tickets[counter] > 0)
        {
            tickets[counter]--;
            timeTaken++;
        }

        counter++;
        if(counter == tickets.Length)
            counter = 0;
    }

    return timeTaken;
}