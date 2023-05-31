namespace WordLib
{
    public static class WordLib
    {
        public static bool IsPalindrome(string word)
        {
            if (string.IsNullOrEmpty(word))
                throw new ArgumentException("Word cannot be null or empty.");

            word = word.ToLower(); // Convert the word to lowercase for case-insensitive comparison

            int left = 0;
            int right = word.Length - 1;

            while (left < right)
            {
                if (word[left] != word[right])
                    return false;

                left++;
                right--;
            }

            return true;
        }
    }
}