using System;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Tạo các biến và gán giá trị
        string username = "user123";
        string password = "pass123";
        string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        // Sử dụng StringWriter để lưu thông tin
        using (StringWriter writer = new StringWriter())
        {
            writer.WriteLine($"Username: {username}");
            writer.WriteLine($"Password: {password}");
            writer.WriteLine($"Time: {time}");

            // Chuyển đổi nội dung StringWriter thành chuỗi
            string data = writer.ToString();

            // Sử dụng StringReader để đọc thông tin từ chuỗi
            using (StringReader reader = new StringReader(data))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}