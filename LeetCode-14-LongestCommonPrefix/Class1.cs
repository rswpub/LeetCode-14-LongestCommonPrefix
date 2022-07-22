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
            CheckConstraints();

            throw new NotImplementedException();
        }

        private void CheckConstraints()
        {
            // Constraints:

            // 1 <= strs.length <= 200
            // 0 <= strs[i].length <= 200
            // strs[i] consists of only lowercase English letters.
        }
    }

    public class ConstraintViolationException : Exception { }
}