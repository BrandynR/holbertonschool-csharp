using System;

///<summary>Class for Shape</summary>
class Shape
{
	///<summary>Throws an NotImplementedException with the message Area() is not implemented</summary>
	public virtual int Area()
	{
		throw new System.NotImplementedException("Area() is not implemented");
	}
}
