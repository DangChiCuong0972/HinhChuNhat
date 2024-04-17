internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao chieu dai :" );
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao chieu rong :");
        double height = double.Parse(Console.ReadLine());

        Rectangle re = new Rectangle(width,height);

        Console.WriteLine("Your Rectange : \n " + re.Display()  );
        Console.WriteLine("Dien tich la :" + re.AreaRecTangle());
        Console.WriteLine("Chu vi la :" + re.Chu_Vi() );

        
    }
}