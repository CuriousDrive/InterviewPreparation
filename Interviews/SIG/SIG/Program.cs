// See https://aka.ms/new-console-template for more information
Console.WriteLine();

int[] solution(int[] balances, string[] requests) {

    long dayInSeconds = 86400;
    Dictionary<int,List<(long,int)>> accountIndexWithdrawalTimestamp = new Dictionary<int, List<(long, int)>>();

    for(int i = 0; i < requests.Length; i++)
    {
        string[] splitRequest = requests[i].Split(' ');

        if(splitRequest.Length == 4)
        {
            string operation = splitRequest[0];
            long timestamp = Convert.ToInt64(splitRequest[1]);
            int accountIndex = Convert.ToInt32(splitRequest[2])-1;
            int amount = Convert.ToInt32(splitRequest[3]);

            // if the account id is invalid
            if((accountIndex+1) > balances.Length)
            {
                return GetInvalidRequest(i);
            }

            // apply cashback
            foreach (var accountIndexWithdrawalTimestampEntry in accountIndexWithdrawalTimestamp)
            {
                Dictionary<int,List<(long, int)>> cashbackEntriesToBeRemoved = new Dictionary<int,List<(long, int)>>();
                
                // applying cashback from the history
                foreach(var cashbackEntryToBeApplied in accountIndexWithdrawalTimestampEntry.Value)
                {
                    if(timestamp - cashbackEntryToBeApplied.Item1 <= dayInSeconds)
                    {
                        int accountIndexOfCashBackToBeApplied = accountIndexWithdrawalTimestampEntry.Key;
                        
                        int cashbackAmount = (int)Math.Floor(cashbackEntryToBeApplied.Item2*(2/(decimal)100));
                        balances[accountIndexOfCashBackToBeApplied] += cashbackAmount;

                        if(!cashbackEntriesToBeRemoved.ContainsKey(accountIndexOfCashBackToBeApplied))
                        {
                            cashbackEntriesToBeRemoved.Add(accountIndexOfCashBackToBeApplied,new List<(long,int)>() { cashbackEntryToBeApplied }); 
                        }
                        else
                        {
                            cashbackEntriesToBeRemoved[accountIndexOfCashBackToBeApplied].Add(cashbackEntryToBeApplied);
                        }
                    }
                }

                // removing cashback entries from history
                foreach(var cashBackEntryToBeRemoved in cashbackEntriesToBeRemoved)
                {
                    foreach(var item in cashBackEntryToBeRemoved.Value)
                    {
                        accountIndexWithdrawalTimestamp[cashBackEntryToBeRemoved.Key].Remove(item);
                    }
                }
            }
            
            // if the transaction is withdraw
            if(operation == "withdraw")
            {
                // if the withdrawal amount is greater than balance
                if(balances[accountIndex] - amount < 0)
                {
                    return GetInvalidRequest(i);
                }
                else
                {
                    balances[accountIndex] -= amount;
                    if(!accountIndexWithdrawalTimestamp.ContainsKey(accountIndex))
                    {
                        accountIndexWithdrawalTimestamp.Add(accountIndex, new List<(long, int)>() {(timestamp, amount)});
                    }
                    else
                    {
                        accountIndexWithdrawalTimestamp[accountIndex].Add((timestamp,amount));
                    }
                }
            }
            
            // if the transaction is deposit
            if(operation == "deposit")
            {
                balances[accountIndex] += amount;
            }
        }
    }
    return balances;
}

int[] GetInvalidRequest(int index)
{
    List<int> result = new List<int>();
    
    index++;
    index = index*(-1);
    result.Add(index);
    
    return result.ToArray();    
}