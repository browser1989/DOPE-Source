﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass472 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 18032;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass472(int int_2 = 0, int int_3 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.int_1 = int_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 18032;
	}

	public virtual int vmethod_1()
	{
		return 8;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_1();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 1 | U.smethod_0(this.int_1, 31));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(18032);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_7(12898);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 1) | this.int_1 << 31);
	}

	public int int_0;

	public int int_1;
}
