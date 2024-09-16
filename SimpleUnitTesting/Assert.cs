namespace SimpleUnitTesting
{
    public static class Assert
    {
        public static void AreEqual(object expected, object actual)
        {
            if (!expected.Equals(actual))
            {
                throw new Exception($"Assert.AreEqual failed! Expected: {expected}, Actual: {actual}");
            }
        }

        public static void IsTrue(bool condition)
        {
            if (!condition)
            {
                throw new Exception($"Assert.IsTrue failed!");
            }
        }
    }
}
