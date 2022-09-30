using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 96;
            Console.WriteLine($"Gia tri cua a1 = {a}");

            Demo(ref a);
            Console.WriteLine($"Gia tri cua a2 = {a}");

            Console.ReadLine();
        }

        static void Demo(ref int a)
        {
            a += 5;
        }
    }
}


/*
Note Ref:

    -   Từ khoá ref phải có trước parameter của hàm và trước tiên biến truyền vào khi gọi hàm sử dụng
    -   Truyền parameter có từ khoá ref bắt buộc phải là 1 biến, không thể truyền vào 1 hằng vì hằng là giá trị không thay đổi
    -   Có thể có 1 hoặc nhiều parameter với từ khoá ref trong lệnh khai báo hàm
    -   Biến truyền vào từ khoá ref phải được khởi tạo giá trị trước khi truyền vào
    -   Hàm sử dụng sẽ trực tiếp thao tác với vùng nhớ của các parameter trên ram. Vì vậy khi kết thúc lời gọi hàm thì các
        giá trị của các parameter bị thay đổi


Note Out:
    -   Out được sử dụng tương tự như ref nhưng khác ở chỗ:
        +   Biến truyền vào parameter có từ khoá out sẽ không cần khởi tạo giá trị trước khi truyền
        +   Parameter phải được khởi tạo giá trị bên trong phân hàm
*/
