public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var result = new List<IList<string>>();
        var hashMap = new Dictionary<string, List<string>>();

        foreach (var str in strs)
        {
            var charArray = str.ToCharArray();
            Array.Sort(charArray);
            var sortedStr = new string(charArray);

            if (hashMap.ContainsKey(sortedStr))
            {
                hashMap[sortedStr].Add(str);
            }
            else
            {
                hashMap[sortedStr] = new List<string> { str };
            }
        }

        foreach (var group in hashMap.Values)
        {
            result.Add(group);
        }

        return result;
    }
}