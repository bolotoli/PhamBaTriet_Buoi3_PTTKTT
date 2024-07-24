using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTongMang
{
    class Program
    {
        // Hàm tính tổng của một mảng sử dụng phương pháp chia để trị
        static int SumArray(int[] arr, int left, int right)
        {
            // Điều kiện cơ sở: nếu mảng chỉ có một phần tử
            if (left == right)
            {
                return arr[left];
            }

            // Tìm chỉ số giữa của mảng
            int mid = (left + right) / 2;

            // Tính tổng của phần bên trái và bên phải bằng cách đệ quy
            int leftSum = SumArray(arr, left, mid);
            int rightSum = SumArray(arr, mid + 1, right);

            // Kết hợp kết quả của hai phần
            return leftSum + rightSum;
        }

        static void Main()
        {
            // Tạo một mảng từ 1 đến n
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = i + 1;
            }

            // Tính tổng của mảng
            int sum = SumArray(arr, 0, arr.Length - 1);

            // In ra kết quả
            Console.WriteLine("Tong cua mang tu 1 den " + n + " là: " + sum);

            // Giữ cửa sổ console mở
            Console.ReadLine();
        }
    }
}
