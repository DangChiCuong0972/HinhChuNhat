public class Rectangle
{
    public double width = 0;
    public double height = 0;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double AreaRecTangle()
    {
        return width*height;
    }

    public double Chu_Vi()
    {
        return (width + height)*2; 
    }

    public string Display()
    {
        return "Rectangle {" + "width=" + width + " , " + "height = " + height + "}";
    }
}

