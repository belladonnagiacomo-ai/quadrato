namespace quadrato
{
    internal class Program
    {
        static bool quadrato(int[] array)
        {
            for (int i = 0; i < array.Length; i++) {

               
                if (array[i]  < array[i - 1] * array[i - 1]) {

                    return true;
                }
               if(i == 0)
                {
                    return false;
                }

            }
          return false;
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 9, 10, 77, 6, 34, 8 };
            Console.WriteLine(quadrato(array));
        }
    }
}
