﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass258 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 9881;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 24;
		}
	}

	public GClass258(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.double_0 = double_3;
		this.double_2 = double_4;
		this.double_1 = double_5;
	}

	public virtual int vmethod_0()
	{
		return 9881;
	}

	public virtual int vmethod_1()
	{
		return 24;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.double_0 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.double_1 = binaryStream_0.ReadDouble();
		binaryStream_0.smethod_1();
		this.double_2 = binaryStream_0.ReadDouble();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(9881);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteDouble(this.double_0);
		binaryStream_0.smethod_7(18537);
		binaryStream_0.WriteDouble(this.double_1);
		binaryStream_0.smethod_7(-7679);
		binaryStream_0.WriteDouble(this.double_2);
	}

	public double double_0;

	public double double_1;

	public double double_2;
}
