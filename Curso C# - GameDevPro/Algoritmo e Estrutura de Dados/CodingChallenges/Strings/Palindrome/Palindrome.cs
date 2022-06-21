using System.Text;

public static class PalindromeChallenge
{
    public static bool Palindrome(string str)
    {
        var leftIndex = 0; 
        var rigthIndex = str.Length - 1;
        while(leftIndex < rigthIndex)
        {
            if(str[leftIndex] != str[rigthIndex])
            {
                return false;
            }
            leftIndex++;
            rigthIndex--;

        }
        return true;
    }
}