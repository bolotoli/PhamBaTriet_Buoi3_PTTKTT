using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimKiemNhiPhan
{
    class Program
    {
        // Phương thức tìm kiếm nhị phân đệ quy
        static int BinarySearch(int[] array, int target, int left, int right)
        {
            if (left > right)
            {
                return -1; // Không tìm thấy phần tử
            }

            int mid = left + (right - left) / 2;

            // Kiểm tra xem phần tử giữa có phải là phần tử cần tìm không
            if (array[mid] == target)
            {
                return mid;
            }

            // Nếu phần tử giữa lớn hơn phần tử cần tìm, tìm kiếm bên trái
            if (array[mid] > target)
            {
                return BinarySearch(array, target, left, mid - 1);
            }

            // Nếu phần tử giữa nhỏ hơn phần tử cần tìm, tìm kiếm bên phải
            return BinarySearch(array, target, mid + 1, right);
        }

        static void Main(string[] args)
        {
            // Mảng đã sắp xếp
            int[] array = { 2, 3, 4, 10, 40 };

            // Phần tử cần tìm
            Console.Write("Nhap phan tu can tim: ");
            int target;
            while (!int.TryParse(Console.ReadLine(), out target))
            {
                Console.WriteLine("Gia tri nhap vao khong hop le. Vui long nhap lai.");
            }

            // Gọi phương thức tìm kiếm nhị phân
            int result = BinarySearch(array, target, 0, array.Length - 1);

            // Xuất kết quả ra màn hình
            if (result != -1)
            {
                Console.WriteLine("Phan tu " + target + " duoc tim thay tai chi so: " + result);
            }
            else
            {
                Console.WriteLine("Phan Tu " + target + " khong ton tai trong mang.");
            }

            // Giữ màn hình để người dùng có thể đọc kết quả
            Console.WriteLine("Nhan phim bat ki de ket thuc...");
            Console.ReadKey();
        }
    }
}
