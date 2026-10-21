public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        for (int i = 0; i < s.Length; i++) {
            for (int j = 0; j < t.Length; j++) {
                if (t[j] == s[i]) {
                    t = t.Remove(j, 1);
                    break;
                }
            }
        }
        
        if (t.Length == 0) return true;

        return false;
    }
}
