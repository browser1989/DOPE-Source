﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass693 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17366;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass693(int int_3 = 0, int int_4 = 0, int int_5 = 0, double double_1 = 0.0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		this.double_0 = double_1;
	}

	public virtual int vmethod_0()
	{
		return 17366;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.double_0 = (double)binaryStream_0.smethod_8();
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 1 | U.smethod_0(this.int_0, 31));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 3 | U.smethod_0(this.int_2, 29));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(17366);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(this.double_0);
		binaryStream_0.smethod_5(-15492);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 1) | this.int_0 << 31);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_2, 3) | this.int_2 << 29);
	}

	public double double_0;

	public int int_0;

	public int int_1;

	public int int_2;
}