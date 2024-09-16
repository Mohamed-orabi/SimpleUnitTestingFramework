using System.Reflection;

namespace SimpleUnitTesting
{
    public class TestRunner
    {
        public void RunTests()
        {
            // Get all types in the current assembly
            var allTypes = Assembly.GetExecutingAssembly().GetTypes();

            // Find all types marked with the [TestClass] attribute
            var testClasses = allTypes.Where(t => t.GetCustomAttributes<TestClassAttribute>().Any());


            foreach (var testClass in testClasses)
            {
                Console.WriteLine($"Running tests in {testClass.Name}...");

                // Create an instance of the test class
                var classInstance = Activator.CreateInstance(testClass);

                // Find all methods marked with the [TestMethod] attribute
                var testMethods = testClass.GetMethods().Where(m => m.GetCustomAttributes<TestMethodAttribute>().Any());
                foreach (var testMethod in testMethods)
                {
                    try
                    {
                        Console.WriteLine($"Running {testMethod.Name}...");

                        // Invoke the test method
                        testMethod.Invoke(classInstance, null);

                        Console.WriteLine($"{testMethod.Name} passed!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"{testMethod.Name} failed! Exception: {ex.InnerException?.Message}");
                    }
                }


            }
        }
    }
}