public class Solution {
    public bool IsPalindrome(int x) {

        string test = x.ToString();
        char[] charArray = test.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return test == reversed;

    }
}