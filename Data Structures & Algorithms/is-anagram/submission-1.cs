public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        char[] arrayS = s.ToCharArray();
        Array.Sort(arrayS);
        string sortedS = new string(arrayS);
        
        char[] arrayT = t.ToCharArray();
        Array.Sort(arrayT);
        string sortedT = new string(arrayT);

        return sortedS == sortedT;
    }
}
