public class Solution {
    public bool IsValid(string s) {
        
        bool result = false;
        Stack<char> chars = new Stack<char>();
        char peek;

        if (s.Length == 1)
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(' || s[i] == '{'|| s[i] == '[') 
            { 
                chars.Push(s[i]); 
            }
            else 
            {
                if (s[i] == ')' && chars.Count > 0) 
                {
                    if (chars.Peek() == '(')
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                else if (s[i] == '}' && chars.Count > 0) 
                {
                    if (chars.Peek() == '{')
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return false;
                    }
                    
                }
                else if (s[i] == ']' && chars.Count > 0) 
                {
                    if (chars.Peek() == '[')
                    {
                        chars.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }
                else {
                    return false;
                }
            }
        }

        if (chars.Count > 0) {
            return false;
        }
        else {
            return true;
        }
    }
}