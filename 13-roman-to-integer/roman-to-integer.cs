public class Solution {
    public int RomanToInt(string s) {
        
        char[] c = s.ToCharArray();
        int result = 0;
        
        for (int i = 0; i < c.Length; i++)
        {
            // CHECK "I"
            if (c[i] == 'I') 
            {
                if (i != c.Length - 1)
                {
                    if (c[i + 1] == 'V')
                    {
                        result += 4;
                        i++;
                    }
                    else if (c[i + 1] == 'X')
                    {
                        result += 9;
                        i++;
                    }
                    else {
                        result++;
                    }         
                }
                else {
                    result++;
                }                 
            }
            // CHECK "V"
            else if (c[i] == 'V') 
            {
                result += 5;
            }
            // CHECK "X"
            else if (c[i] == 'X') 
            {
                if (i != c.Length - 1)
                {
                    if (c[i + 1] == 'L')
                    {
                        result += 40;
                        i++;
                    }
                    else if (c[i + 1] == 'C')
                    {
                        result += 90;
                        i++;
                    }
                    else {
                        result += 10;
                    }         
                }
                else {
                    result += 10;
                }            
            }
            // CHECK "L"
            else if (c[i] == 'L') 
            {
                result += 50;
            }
            // CHECK "C"
            else if (c[i] == 'C') 
            {
                if (i != c.Length - 1)
                {
                    if (c[i + 1] == 'D')
                    {
                        result +=  400;
                        i++;
                    }
                    else if (c[i + 1] == 'M')
                    {
                        result += 900;
                        i++;
                    }
                    else {
                        result += 100;
                    }         
                }
                else {
                    result += 100;
                }            
            }
            // CHECK "D"
            else if (c[i] == 'D')
            { 
                result += 500;
            }
            // CHECK "M"
            else if (c[i] == 'M') 
            {
                result += 1000;
            }
            Console.WriteLine("current result: " + result);
        }   
        return result;
    }
}