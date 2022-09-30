using System;
using System.Collections;

namespace LearnStack
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Tạo 1 Stack rỗng
            Stack MyStacks = new Stack();

            //  Thực hiện thêm vài phần tử vào Stack thông qua hàm Push()
            MyStacks.Push("Java");
            MyStacks.Push("C#");
            MyStacks.Push("Javascript");

            //  Thử sử dụng các phương thức của Stack
            Console.WriteLine("Cac phuong thuc cuar Stack: ");

            Console.WriteLine($"So phan tu hien tai cua Stack: {MyStacks.Count}");

            //  Lưu ý ở đây ta chỉ muốn xem giá trị mà không muốn nó khỏi Stack thì ta sẽ dùng Peek()
            Console.WriteLine($"Phan tu dau cua Stack: {MyStacks.Peek()}"); //Javascript

            //  Kiểm tra lại số phần tử để chắc chắn rằng hàm Peek() không xoá phần tử ra khỏi Stack
            Console.WriteLine($"So phan tu cua Stack sau khi goi ham Peek(): {MyStacks.Count}");


            //  Thực hiện các phần tử ra khỏi Stack

            Console.WriteLine("Popping...");

            int Length = MyStacks.Count;
            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine(" " + MyStacks.Pop());
            }
            Console.WriteLine();

            //  Kiểm tra lại số phần tử Stack sau khi Pop()
            Console.WriteLine($"So phan tu cua Stack sau khi goi ham Pop() con: {MyStacks.Count} nha");

            Console.ReadLine();
        }
    }
}