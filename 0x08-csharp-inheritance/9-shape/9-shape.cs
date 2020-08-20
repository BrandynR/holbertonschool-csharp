using System;

///<summary>Class Shape</summary>
class Shape
{
	///<summary>Just throws error</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

///<summary>Class Rectangle inherits from class Shape</summary>
class Rectangle : Shape
{
	private int width;
	private int height;

	///width of rectangle
	public int Width
	{
		get
		{
			return width;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Width must be greater than or equal to 0");
			}
			width = value;
		}
	}

	///height of rectangle
	public int Height
	{
		get
		{
			return height;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Height must be greater than or equal to 0");
			}
			height = value;
		}
	}

	///<summary>Returns the area of a rectangle, overrides the area defined in the base class</summary>
	public new int Area()
	{
		return height * width;
	}

	public override string ToString()
	{
		return String.Format("[Rectangle] {0} / {1}", width, height);
	}
}


///<summary>Class Rectangle inherits from class Shape</summary>
class Square : Rectangle
{
	private int size;

	///The size of the width and the height of class Square
	public int Size
	{
		get
		{
			return size;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentException("Size must be greater than or equal to 0");
			}
			size = value;
			Height = value;
			Width = value;
		}
    }
    public override string ToString()
	{
		return String.Format("[Square] {0} / {0}", size);
	}
}
