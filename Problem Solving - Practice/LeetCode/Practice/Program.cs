Console.WriteLine();

int FindJudge(int n, int[][] trust) {

    List<int> couldBeJudge = new List<int>();
    List<int> personBeingTrusted = new List<int>();

    for(int i = 0; i < trust.Length; i++)
    {
        couldBeJudge.Add(trust[i][0]);
        personBeingTrusted.Add(trust[i][1]);
    }

    return personBeingTrusted.Except(couldBeJudge).FirstOrDefault();
}