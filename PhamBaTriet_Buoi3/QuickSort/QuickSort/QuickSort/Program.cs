using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo mảng với 6 phần tử
            int[] arr = { 3, 6, 8, 10, 1, 2 };
            int n = arr.Length;

            // In ra mảng ban đầu
            Console.WriteLine("Mang ban dau:");
            PrintArray(arr, n);

            // Gọi phương thức QuickSort để sắp xếp mảng
            QuickSort(arr, 0, n - 1);

            // In ra mảng đã được sắp xếp
            Console.WriteLine("Mang da sap xep:");
            PrintArray(arr, n);

            // Dừng lại để xem kết quả
            Console.WriteLine("Nhan phim bat ki de tiep tuc...");
            Console.ReadLine();
        }

        // Phương thức QuickSort
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Lấy vị trí phân chia (pivot)
                int pi = Partition(arr, low, high);

                // Đệ quy sắp xếp các phần tử trước và sau pivot
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }

        // Phương thức Partition để phân chia mảng
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; // Chọn pivot là phần tử cuối
            int i = (low - 1); // Chỉ số của phần tử nhỏ hơn

            for (int j = low; j <= high - 1; j++)
            {
                // Nếu phần tử hiện tại nhỏ hơn pivot
                if (arr[j] < pivot)
                {
                    i++; // Tăng chỉ số của phần tử nhỏ hơn
                    Swap(ref arr[i], ref arr[j]); // Hoán đổi phần tử
                }
            }

            // Hoán đổi phần tử sau cùng với phần tử lớn hơn pivot
            Swap(ref arr[i + 1], ref arr[high]);
            return (i + 1); // Trả về vị trí pivot
        }

        // Phương thức Swap để hoán đổi giá trị của hai phần tử
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Phương thức PrintArray để in ra các phần tử của mảng
        static void PrintArray(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }
    }
}
