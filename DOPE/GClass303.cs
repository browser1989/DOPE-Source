﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass303 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -26546;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 10;
		}
	}

	public GClass303(string string_1 = "", double double_1 = 0.0)
	{
		Class13.F93tSdiz1aNIA();
		this.string_0 = "";
		base..ctor();
		this.string_0 = string_1;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return -26546;
	}

	public virtual int vmethod_1()
	{
		return 10;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-26546);
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public string string_0;

	public double double_0;
}
