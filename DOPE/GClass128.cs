﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass128 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 5;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass128(int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
	}

	public virtual int vmethod_0()
	{
		return 5;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 4 | U.smethod_0(this.int_2, 28));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(5);
		binaryStream_0.smethod_4(this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 4) | this.int_2 << 28);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}
