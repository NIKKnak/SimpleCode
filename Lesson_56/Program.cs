
using System.Threading.Channels;


// изменить размер массива

class TestClass
{

    static void Main(string[] args)
    {





        int[] myArray = {9,9,5,6,4,5 };


        void Resize<T>(ref T[] arr)
        {
            Console.WriteLine("сколько нужно");
            int result = Convert.ToInt32(Console.ReadLine());
            T[] newArray = new T[result];
            for (int i = 0; i < arr.Length && i < newArray.Length; i++)
            {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }


        Resize(ref myArray);

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write(myArray[i] + " ");
        }



    }


}