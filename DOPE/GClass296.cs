﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass296 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -13836;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass296(int int_1 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.bool_0 = bool_1;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return -13836;
	}

	public virtual int vmethod_1()
	{
		return 1;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-13836);
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_7(this.int_0);
	}

	public bool bool_0;

	public int int_0;
}
