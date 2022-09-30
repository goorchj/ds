using System;
namespace insertion
{
    class insertion
    {
        public static void Main(string[]args)
        {
            int[] element = {45,87,30,20,97,63,75,86,71};
            int count =element.Length;
            int temp;
            int j=0;
            for(int i=0;i<count;i++)
            {
                Temp = element[i+1];
                j= i;
                while (j >=0 && temp< element [j])
                                      
                element [j+1]= element  [j];
                j=j-1;
            

            }

                element [j]=temp;
        }

              for (int i=0;i<count;i++)
              Console.Writeline(element [i]);

    }
}


