using System;

///<summary>Class Shape</summary>
class Shape
{
	///<summary>Throws an error "is not implemented"</summary>
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

	///The width of rectangle
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

	///The height of rectangle
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

	///<summary>returns the area of a rectangle overrides the area defined in base class</summary>
	public new int Area()
	{
		return height * width;
	}

    ///<summary>Overrides the ToString method.</summary>
	public override string ToString()
	{
		return String.Format("[Rectangle] {0} / {1}", width, height);
	}
}


///<summary>Class Rectangle inherits from class Shape</summary>
class Square : Rectangle
{
	private int size;

	///the size of the width and the height of class Square
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
				throw new System.ArgumentException("Size must be greater than or equal to 0");
			}
			size = value;
			Height = value;
			Width = value;
		}
	}
}
