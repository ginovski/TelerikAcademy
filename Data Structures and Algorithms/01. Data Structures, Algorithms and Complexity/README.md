## Data Structures, Algorithms and Complexity Homework

1. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the array's size is `n`.

  ```cs
  long Compute(int[] arr)
  {
      long count = 0;
      for (int i=0; i<arr.Length; i++) // O(n)
      {
          int start = 0, end = arr.Length-1;
          while (start < end) // O(n - 1) = O(n)
              if (arr[start] < arr[end])
                  { start++; count++; }
              else 
                  end--;
      }
      return count;
  }
  ```
	
#####Answer: 
The expected running time is O(n^2) because outer for loop iterates n-times and inner while also iterates n-times, because start=0 and end=arr.length - 1 (n - 1)

2.. What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcCount(int[,] matrix)
  {
      long count = 0;
      for (int row=0; row<matrix.GetLength(0); row++)
          if (matrix[row, 0] % 2 == 0)
              for (int col=0; col<matrix.GetLength(1); col++)
                  if (matrix[row,col] > 0)
                      count++;
      return count;
  }
  ```

#####Answer: 
- Worst Case: 
Every member is even and the inner loop will iterate m times on every n time for the rows, so that the running time will be O(n*m)
- Best Case: 
Every member is odd and the inner loop will never iterate, so that the running time will be only for the outer => O(n)

3.. (*) What is the expected running time of the following C# code?
  - Explain why using Markdown.
  - Assume the input matrix has size of `n * m`.

  ```cs
  long CalcSum(int[,] matrix, int row)
  {
      long sum = 0;
      for (int col = 0; col < matrix.GetLength(0); col++) 
          sum += matrix[row, col];
      if (row + 1 < matrix.GetLength(1)) 
          sum += CalcSum(matrix, row + 1);
      return sum;
  }
  
  Console.WriteLine(CalcSum(matrix, 0));
  ```
#####Answer: 
Running time will be O(n^m) because for loop iterates n-times and recursive the method is called to iterate n-times for every row until m