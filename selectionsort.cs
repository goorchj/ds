using System;

namespace selection sort

{

class bsort
{

    static void selectionsort(string[] args)
    {

        int[] arr = new int[6] {59,1,99,67,10,23};
        int n = 6;
        Console.WriteLine("Selection sort");
        Console.WriteLine("Initial array is:");
        for (int i =0; i < n-1; i++)
        {
            Console.Write(arr[1]+ "");
            int temp, smallest;
            for (int i=0; < n-1;i++)
            {
                smallest=i;
                for ( int j=i+1;j<n;j++){
                    if (arr[j] < arr[smallest]){
                        smallest=j;
                    }
                }
                temp = arr[smallest];
                arr[smallest]= arr[i];
                arr[i]= temp

            }
            Console.WriteLine();
            Console.Write("sorted array is;");
            
        }
    }

}


}