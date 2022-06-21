public static class ValidateSubsequenceChallenge
{
    public static bool ValidateSubSequence(int[] arr, int[] sequence)
    {
        var i = 0;
        foreach(var val in arr)
        {
            if(sequence[i] == val)
            {
                i++;
            }
            if(i == sequence.Length)
            {
                break;
            }
        }
        return i == sequence.Length;
    }
}