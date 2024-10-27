using Holloman_SortingAlgorithm_HW;
using System.Diagnostics;

/*I have been running accross an interesting bug, You can run the Quick Sort Algorithm if you comment out all other algorithms. When you try running them back to back, like i originally set up, it goes through a stacxk overflow, I am still working out why this is happening.*/

Stopwatch stopwatch = Stopwatch.StartNew();

#region ** Building Randomized Array **
// usage 100 thousand values
Console.WriteLine("Building randomized array.");

stopwatch.Start();

int[] largeArr = GenerateRandomArray(100000, 1, 1000);
Console.WriteLine("Array built.");

stopwatch.Stop();
DisplayRuntime(stopwatch);
#endregion

#region ** Duplication of Randomized Array **
int[] Bubble, Insert, Mg, Quick, Reset;
Bubble = largeArr;
Insert = largeArr;
Mg = largeArr;
Quick = largeArr;
Reset = largeArr;

int[] result = largeArr;
#endregion

#region ** Run Bubble Algorithm **
//stopwatch.Reset();

//Console.WriteLine("\nBubble Sorting Algorithm: ");
//Console.WriteLine("Starting the sort.");

//stopwatch.Start();

//result = Sort.BubbleSort(Bubble, Bubble.Length);
//Console.WriteLine("Finished sorting!");

//stopwatch.Stop();
//DisplayRuntime(stopwatch);

//Console.WriteLine("Press enter to continue.");
//Console.ReadLine();
/**------------------------------------Stop Here-----------------------------------------**/

/*

Reasoning: I believe that the reason Bubble Sort's performance lags behind and becomes the 
slowest in this list of algorithms is because it the longer the array needing to be sorted gets
it's processing spped for the data falls into the [O(n^2)]. This means that it needs to compile
and compare twice as meany times compared to the processing of [O(nlogn)] or even the best case
scenario of [O(n^1)].

 */

// ----------------------------------------------------- Array Test
//ArrayCheck(result);

/**Other*/
result = Reset;
#endregion

#region ** Run Insertion Algorithm **
/** Insertion Sort Opperation **/
//stopwatch.Reset();

//Console.WriteLine("\nInsertion Sorting Algorithm: ");
//Console.WriteLine("Starting the sort.");

//stopwatch.Start();

//result = Sort.InsertionSort(Insert, Insert.Length);
//Console.WriteLine("Finished sorting!");

//stopwatch.Stop();
//DisplayRuntime(stopwatch);

//Console.WriteLine("Press enter to continue.");
//Console.ReadLine();
/**------------------------------------Stop Here-----------------------------------------**/

/*

Reasoning: Inserstion Sorting has a decent performance in comparison to Bubble, because of the
model design. This algorithm performs well up to 100000 because it breaks the work apart more 
efficiently. Essenstially it breaks the array into smaller groups and compares the numbers near 
the break point to see if they are larger or smaller than the point in question. With in the 
perameters of 100000 this algorithms quickly works through it causing it to run at a [O(nlogn)].

 */

// ----------------------------------------------------- Array Test
//ArrayCheck(result);

/**Other*/
result = Reset;
#endregion

#region ** Run Merge Algorithm **
/** Merge Sort Opperation **/
//stopwatch.Reset();

//Console.WriteLine("\nMerge Sorting Algorithm: ");
//Console.WriteLine("Starting the sort.");

//stopwatch.Start();

//result = Sort.MergeSortAlgorithm(Mg, Mg.Length);
//Console.WriteLine("Finished sorting!");

//stopwatch.Stop();
//DisplayRuntime(stopwatch);

//Console.WriteLine("Press enter to continue.");
//Console.ReadLine();
/**------------------------------------Stop Here-----------------------------------------**/

/*

Reasoning: The Merger Sort was the best performing Algorithm, because off its effcient design,
it breaks the array into two groups and filters then in order from smallest to largest number 
value. Due to this precess it only really works through the array once to get to the final 
ordered result. Within the parameters of 100000 it seemed to be working with [O(nlogn)].

 */

// ----------------------------------------------------- Array Test
//ArrayCheck(result);

/**Other*/
result = Reset;
#endregion

#region ** Run Quick Sort Algorithm **
/** Quick Sort Opperation **/
stopwatch.Reset();

Console.WriteLine("\nQuick Sorting Algorithm: ");
Console.WriteLine("Starting the sort.");

stopwatch.Start();

Sort.QuickSort(Quick, 1, Quick.Length - 1);
Console.WriteLine("Finished sorting!");

stopwatch.Stop();
DisplayRuntime(stopwatch);

Console.WriteLine("Press enter to continue.");
Console.ReadLine();
/**------------------------------------Stop Here-----------------------------------------**/

/*

Reasoning: Like with the Insertion Sorting, I feel this one is a middle of the processing 
Algorithms. I do however feel that this one would perform better with a higher amount needing 
to be precessed. Because of the way this one is designed it works very sinmularly as the Merge.
The only difference is the efficency of hw they operate because of how they are both desinged.
Despite the difficulty I faced on getting this one to work with the others, I found this one 
works with [O(nlogn)].

 */

// -----------------------------------------------------  Array Test
ArrayCheck(Quick);
#endregion

#region ** Array Print Test **
static void ArrayCheck(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}
#endregion

#region ** Random Number Array Generator **
static int[] GenerateRandomArray(int length, int minValue, int maxValue)
{
    Random rand = new Random();
    int[] array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = rand.Next(minValue, maxValue); // Generates a random integer within the specified range
    }

    return array;
}
#endregion

#region ** Stop Watch **
static void DisplayRuntime(Stopwatch stopwatch)
{
    TimeSpan ts = stopwatch.Elapsed;

    // Format and display the TimeSpan value.
    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
        ts.Hours, ts.Minutes, ts.Seconds,
        ts.Milliseconds / 10);
    Console.WriteLine("Time Taken: " + elapsedTime);
}
#endregion