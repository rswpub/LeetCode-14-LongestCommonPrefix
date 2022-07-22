using System.Text.RegularExpressions;

namespace LeetCode_14_LongestCommonPrefix
{
    public class Class1
    {
        public string LongestCommonPrefix(string[] strs)
        {
            // Write a function to find the longest common prefix string amongst an array of strings.
            // If there is no common prefix, return an empty string "".
            // 
            // Example:
            // 
            // Input: strs = ["flower", "flow", "flight"]
            // Output: "fl"

            // Check validation constraints
            CheckConstraints(strs);

            throw new NotImplementedException();
        }

        private void CheckConstraints(string[] strs)
        {
            // Constraints:
            //
            // 1 <= strs.length <= 200
            // 0 <= strs[i].length <= 200
            // strs[i] consists of only lowercase English letters.


            // Make sure the string array doesn't contain too many or too few strings
            if ((strs.Length < 1) || (strs.Length > 200))
            {
                throw new ConstraintViolationException();
            }

            foreach (string str in strs)
            {
                // Make sure each string is the proper length
                if (str.Length > 200)
                {
                    throw new ConstraintViolationException();
                }

                // Use a RegEx to make sure the given string only contains lowercase English letters
                Regex regex = new Regex(@"^[a-z]+$");
                if (!regex.IsMatch(str))
                {
                    throw new ConstraintViolationException();
                }
            }
        }
    }

    public class ConstraintViolationException : Exception { }
}