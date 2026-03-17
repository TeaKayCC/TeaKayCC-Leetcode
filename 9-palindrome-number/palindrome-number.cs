public class Solution {
    public bool IsPalindrome(int x) {
        
        string forward = x.ToString();
        string backward = "";
        
                for (int i = forward.Length - 1; i >= 0; i--)
        {
            backward += forward[i];
        }

        if (forward == backward) return true;
        else return false;
    }
}