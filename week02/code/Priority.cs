using System.Collections;

public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: The enqueue function should add an item to the back of the queue.
        // Expected Result: [A (Pri:1), B (Pri:4), C (Pri:2), D (Pri:3)]
        Console.WriteLine("Test 1");
        var priorityList = new PriorityQueue();
        priorityList.Enqueue("A",1);
        priorityList.Enqueue("B",4);
        priorityList.Enqueue("C",2);
        priorityList.Enqueue("D",3);

        Console.WriteLine($"Outcome: {priorityList}");

        // Defect(s) Found: None.

        Console.WriteLine("---------");



        // Test 2
        // Scenario: The dequeue function should remove the item with the highest priority and return its value.
        // Expected Result: [A (Pri:1), C (Pri:2), D (Pri:3)]
        Console.WriteLine("Test 2");
        var details = priorityList.Dequeue();
        Console.WriteLine($"Outcome - Value: {details}");
        Console.WriteLine($"Outcome - Updated Queue: {priorityList}");


        // Defect(s) Found: No queue items were removed.

        Console.WriteLine("---------");



        // Test 3
        // Scenario: If there are more than one item with highest priority, apply FIFO.
        // Expected Result: [A (Pri:1), C (Pri:2), E (Pri:3)]
        Console.WriteLine("Test 3");
        priorityList.Enqueue("E",3);
        priorityList.Dequeue();
        Console.WriteLine($"Outcome: {priorityList}");
        // Defect(s) Found: None.

        Console.WriteLine("---------");



        // Test 4
        // Scenario: If queue is empty, then an error message will be displayed.
        // Expected Result: Error message.
        Console.WriteLine("Test 4");
        priorityList.Dequeue();
        priorityList.Dequeue();
        priorityList.Dequeue();
        priorityList.Dequeue();
        // Defect(s) Found: None.

        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}