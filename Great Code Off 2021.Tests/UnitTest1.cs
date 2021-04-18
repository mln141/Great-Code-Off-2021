using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InconsistentNaming

namespace Great_Code_Off_2021.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Expected_3()//1
        {
            int N = 5, K = 3;
            int[]A = {1, 1, 4, 1, 4}, B = {5, 2, 5, 5, 4}, C ={1, 2, 2, 3, 3};
            Assert.AreEqual(3,new Solution().solution(N,K,A,B,C));
        }

        [TestMethod]
        public void Expected_2()
        {
            int N = 6, K = 4;
            int[] A = {1, 2, 1, 1}, B = {3, 3, 6, 6}, C = {1, 2, 3, 4};
            Assert.AreEqual(2, new Solution().solution(N, K, A, B, C));
        }
        [TestMethod]
        public void Expected_1()//3
        {
            int N = 3, K = 2;
            int[] A = {1, 3, 3, 1, 1}, B = {2, 3, 3, 1, 2}, C = {1, 2, 1, 2, 2};
           Assert.AreEqual(1, new Solution().solution(N, K, A, B, C));
        }

        [TestMethod]
        public void Expected_3_2()//4
        {
            int N = 5, K = 2;
            int[] A = {1, 1, 2}, B = {5, 5, 3}, C = {1, 2, 1};//4
            Assert.AreEqual(3, new Solution().solution(N, K, A, B, C));
        }

    }
}
