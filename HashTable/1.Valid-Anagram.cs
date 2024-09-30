public bool IsAnagram(string s, string t)
{
    var hash = new Dictionary<char, int>();
    if (s.Length != t.Length) return false;
    for (int i = 0; i < s.Length; i++)
    {
        if (hash.ContainsKey(s[i]))
        {
            hash[s[i]]++;
        }
        else
        {
            hash.Add(s[i], 1);
        }
    }
    for (int i = 0; i < t.Length; i++)
    {
        if (hash.ContainsKey(t[i]) && hash[t[i]] != 0)
        {
            hash[t[i]] -= 1;
        }
        else
        {
            return false;
        }
    }
    return true;
}
