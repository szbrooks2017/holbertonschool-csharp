using System;

///<summary> Class that is the base class</summary>
class Shape
{
    ///<summary> the area of a shape</summary>
    public virtual int Area()
    {
        throw new NotImplementedException("Area() is not implemented");
    }

}

///<summary> Subclass of Shape</summary>
class Rectangle : Shape
{
    // width of the rectangle
    private int width;
    // height of the rectangle
    private int height;

    ///<summary> gets and sets width, width must be non-negative</summary>
    public int Width
    {
        get { return width; }
        set { 
            if (value < 0)
            {
                throw new ArgumentException("Width must be greater than or equal to 0");
            }
            else
            {
                width = value;
            }
        }
    }
    ///<summary> gets and sets height, height must be non-negative</summary>
    public int Height
    {
        get { return height; }
        set { 
            if (value < 0)
            {
                throw new ArgumentException("Height must be greater than or equal to 0");
            }
            else
            {
                height = value;
            }
        }
    }
    ///<summary> sets area</summary>
    public new int Area()
    {
        return height * width;
    }

    ///<summary> sets public override</summary>
    public override string ToString()
    {
        return string.Format("[Rectangle] {0} / {1}", width, height);
    }
}