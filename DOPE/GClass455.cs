﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass455 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 279;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 9;
		}
	}

	public GClass455(int int_2 = 0, int int_3 = 0, bool bool_1 = false)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 279;
	}

	public virtual int vmethod_1()
	{
		return 9;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 12) | this.int_0 << 20);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 4 | U.smethod_0(this.int_1, 28));
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(279);
		binaryStream_0.smethod_4(this.int_0 << 12 | U.smethod_0(this.int_0, 20));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 4) | this.int_1 << 28);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;
}
