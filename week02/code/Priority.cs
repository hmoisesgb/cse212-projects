public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Add 4 values (A,1), (B,2), (C,3), (D,4) with different priorities 
        // to the Queue using the Enqueue method, and run until the queue is empty,
        // the Dequeue should remove the items with the highest priority first
        // Expected Result: D,C,B,A
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("A",1);
        priorityQueue.Enqueue("B",2);
        priorityQueue.Enqueue("C",3);
        priorityQueue.Enqueue("D",4);

        for (int i = 0; i < 4;i++){
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: The Dequeue method did not remove the item after saving its value.
        // The second defect was that the for did not loop through all the values in the queue

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Add 4 values (A,1), (B,2), (C,1), (D,2) to the Queue 
        // using the Enqueue method, and run until the queue is empty,
        // there are 2 pairs of items with the same priority, the Dequeue method
        // should remove the items closes to the front of the queue of each pair first
        // Expected Result: B,D,A,C
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("A",1);
        priorityQueue.Enqueue("B",2);
        priorityQueue.Enqueue("C",1);
        priorityQueue.Enqueue("D",2);

        for (int i = 0; i < 4;i++){
            Console.WriteLine(priorityQueue.Dequeue());
        }

        // Defect(s) Found: If the priority value was the same the program still replaced the highPriorityIndex as the condition was >= instead of >
        // this caused the Dequeue method to dequeue the value that was more closer to the end of the queue instead of the beginning

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Try to dequeue with an empty queue
        // Expected Result: Error message should be displayed
        Console.WriteLine("Test 3");
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");
    }
}