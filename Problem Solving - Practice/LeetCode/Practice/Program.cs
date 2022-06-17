Console.WriteLine(LengthOfLongestSubstring("pwwkew"));

int solution(string s, string t) {
    int totalCount = 0;
    for(int i = 0; i < s.Length; i++)
    {
        if(Char.IsDigit(s[i]))
        {
            string newString = s.Remove(i,1);
            if(string.Compare(newString, t) == -1)
                totalCount++;
        }
    }
    for(int i = 0; i < t.Length; i++)
    {
        if(Char.IsDigit(t[i]))
        {
            string newString = t.Remove(i,1);
            if(string.Compare(s,newString) == -1)
                totalCount++;
        }
    }
    return totalCount;
}