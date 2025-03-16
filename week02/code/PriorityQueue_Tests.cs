using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Can I add people to the queue and remove them in the correct order?
    // Expected Result: Bob, Tim, Sue, Jimmy
    // Defect(s) Found: Dequeue method is not removing the item with the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        List<string> expectedResult = new List<string> { "Bob", "Tim", "Sue", "Jimmy" };

        // Add the people to the queue
        priorityQueue.Enqueue("Bob", 4);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("Jimmy", 1);

        for (int i = 0; i < expectedResult.Count; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
        }
    }

    [TestMethod]
    // Scenario: Get the people in the queue in the correct order
    // Expected Result:  { "Jimmy", "Tim", "Bob", "Sue" }
    // Defect(s) Found: It failed to check for the last person in queue.
    public void TestPriorityQueue_2()
        {
        var priorityQueue = new PriorityQueue();

        List<string> expectedResult = new List<string> { "Sue", "Tim", "Bob", "Jimmy" };

        // Add the people to the queue
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 4);
        priorityQueue.Enqueue("Jimmy", 1);

        for (int i = 0; i < expectedResult.Count; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
        }
    }

    [TestMethod]
    // Scenario: Get the people in the queue in the correct order
    // Expected Result:  { "Jimmy", "Tim", "Bob", "Sue" }
    // Defect(s) Found: It was not checking for the last person in queue.
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        List<string> expectedResult = new List<string> { "Jimmy", "Tim", "Sue", "Bob" };

        // Add the people to the queue
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 2);
        priorityQueue.Enqueue("Jimmy", 4);

        for (int i = 0; i < expectedResult.Count; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
        }
    }

    [TestMethod]
    // Scenario: if the queue is empty, throw an exception
    // Expected Result: InvalidOperationException
    // Defect(s) Found: None
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: If two people have the same priority, the first person added should be removed first
    // Expected Result: Bob, Tim, Sue, Jimmy
    // Defect(s) Found: IT was using >= instead of > to check for the highest priority.
    public void TestPriorityQueue_5()
    {
        var priorityQueue = new PriorityQueue();

        List<string> expectedResult = new List<string> { "Bob", "Tim", "Jimmy", "Sue" };

        // Add the people to the queue
        priorityQueue.Enqueue("Bob", 3);
        priorityQueue.Enqueue("Tim", 3);
        priorityQueue.Enqueue("Sue", 1);
        priorityQueue.Enqueue("Jimmy", 2);

        for (int i = 0; i < expectedResult.Count; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
        }
    }
}