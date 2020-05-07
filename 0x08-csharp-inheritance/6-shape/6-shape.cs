using System;

///<summary>Class Shape</summary>
class Shape
{
	///<summary>Throw error "is not implemented"</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}

///<summary>Rectangle Class inherits from class Shape</summary>
class Rectangle : Shape
{
	private int width;
	private int height;

	//Rectangle width
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

	//Rectangle height
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
}
