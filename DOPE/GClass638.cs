﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass638 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18218;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 14;
		}
	}

	public GClass638(int int_3 = 0, double double_1 = 0.0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_1 = int_3;
		this.double_0 = double_1;
		this.int_0 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 18218;
	}

	public virtual int vmethod_1()
	{
		return 14;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
		this.int_1 = (int)binaryStream_0.smethod_1();
		this.int_2 = (int)binaryStream_0.smethod_1();
		this.double_0 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18218);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.smethod_7(22046);
		binaryStream_0.smethod_7(this.int_1);
		binaryStream_0.smethod_7(this.int_2);
		binaryStream_0.WriteDouble(this.double_0);
	}

	public int int_0;

	public int int_1;

	public int int_2;

	public double double_0;
}
