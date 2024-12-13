


//Parallel.For(0 ,19 , i =>
//{
//Console.WriteLine($"Number : {i} , Handled By TheadId :{Thread.CurrentThread.ManagedThreadId}" );
//});

Task task1 = Task.Run(() =>
{
    Console.WriteLine("Task 1 Running ... ");
    Thread.Sleep(1000);
    Console.WriteLine("Task 1 Done");
});

Task task2 = Task.Run(() =>
{
    Console.WriteLine("Task 2 Running ...");
    Thread.Sleep(1000);
    Console.WriteLine("Task 2  Done");
});

//await Task.WhenAll(task1, task2);
