using System.Linq;

// ReSharper disable InconsistentNaming

namespace Great_Code_Off_2021
{
    public class Solution
    {
        // ReSharper disable once UnusedMember.Global
        /// <summary>
        /// </summary>
        /// <param name="N">number of forms</param>
        /// <param name="K">number of colors</param>
        /// <param name="A">from</param>
        /// <param name="B">to</param>
        /// <param name="C">color value</param>
        /// <returns></returns>
        public int solution(int N, int K, int[] A, int[] B, int[] C)
        {
            var Values = Enumerable.Repeat(0, N).ToArray();
            var Counts = Enumerable.Repeat(0, N).ToArray();
            if (N == 0 || K == 0 || A == null || B == null || C == null
                || A.Length == 0 || B.Length == 0 || C.Length == 0
                || A.Length != B.Length || B.Length != C.Length) return 0;
            var instructions = A.Length;
            for (var instr = 0; instr < instructions; instr++)
            {
                for (var i = A[instr]; i <= B[instr]; i++)
                {
                    if (Values[i - 1] + 1 == C[instr])
                    {
                        Values[i - 1] =   C[instr];
                        Counts[i - 1]++;
                    }
                    else
                    {
                        Values[i - 1] = -1;
                        Counts[i - 1]=int.MinValue;
                    }
                }
            }

            return Counts.Count(x => x == K);
        }
    }
}