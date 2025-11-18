namespace quadrato
{
    internal class Program
    {
        static bool quadrato(int[] array)
        {
            for (int i = 0; i < array.Length; i++) {

               
                if (i > 0 && array[i]  < array[i - 1] * array[i - 1]) {

                    
                    return true;
                  
                }

            }
          return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 5,9,10 };
            if (quadrato(array) == true)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("true");
            }
            
        }
    }
}
