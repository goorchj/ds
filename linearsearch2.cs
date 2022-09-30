class ls2

{

    public static void Main3 (string[] args)
    {

        int[] element = {45,87,30,20,97,63,75,86,71};
        int item =75;
                int noe=element.Length;
                int flag = -1;
                for(int i=0;i<noe;i++)
                {
                if(element[i]== item)
                {
                Console.WriteLine(" The item " + item + " is found in position" + (i+1) );
                flag =-1;
                break;
                }
                else
                flag = 100;
                }
                if (flag==100)

                Console.WriteLine (" The item " + " is not found");
    }
}