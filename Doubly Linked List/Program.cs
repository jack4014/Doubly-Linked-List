using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Doubly_Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] file1 = System.IO.File.ReadAllLines(@"..\..\..\Numbers1.txt"); //read contents of the first designated file
                string[] file2 = System.IO.File.ReadAllLines(@"..\..\..\Numbers2.txt"); //read contents of the second designated file
                string[] file3 = System.IO.File.ReadAllLines(@"..\..\..\Numbers3.txt"); //read contents of the third designated file

                int[] arr = Array.ConvertAll(file1, int.Parse); //convert contents of the first file into an int array
                int[] arr2 = Array.ConvertAll(file2, int.Parse); //convert contents of the second file into an int array
                int[] arr3 = Array.ConvertAll(file3, int.Parse); //convert contents of the third file into an int array

                DLL doubleLL = new DLL(); //Create the doubly linked list
                for (int i = 0; i < arr.Length; i++)
                {
                    doubleLL.append(arr[i]);
                }
                DLL doubleLL2 = new DLL(); //Create the second doubly linked list
                for (int i = 0; i < arr2.Length; i++)
                {
                    doubleLL2.append(arr2[i]);
                }
                DLL doubleLL3 = new DLL(); //Create the third doubly linked list
                for (int i = 0; i < arr3.Length; i++)
                {
                    doubleLL3.append(arr3[i]);
                }

                doubleLL.printList(doubleLL.Head); //Call the print list method for the first linked list
                doubleLL.printMiddle(); //Call the print middle method for the first linked list
                doubleLL.printPrime(); //Call the print prime method for the first linked list
                Console.WriteLine();
                doubleLL2.printList(doubleLL2.Head); //Call the print list method for the second linked list
                doubleLL2.printMiddle(); //Call the print middle list method for the second linked list
                doubleLL2.printPrime(); //Call the print prime method for the second linked list
                Console.WriteLine();
                doubleLL3.printList(doubleLL3.Head); //Call the print list method for the third linked list
                doubleLL3.printMiddle(); //Call the print middle method for the third linked list
                doubleLL3.printPrime(); //Call the print prime method for the third linked list
            }
            catch (FormatException error_1) //format error handling 
            {
                Console.WriteLine("Formatting Error");
                Console.WriteLine(error_1.Message);
            }
            catch (FileNotFoundException error_2) //file not found error handling
            {
                Console.WriteLine("File Not Found");
                Console.WriteLine(error_2.Message);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

    }

}
