﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass139 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 20687;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass139(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.Id = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 20687;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 14) | this.Id << 18);
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 13) | this.int_0 << 19);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(20687);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.fUeiimuocMk(this.Id << 14 | U.smethod_0(this.Id, 18));
		binaryStream_0.smethod_5(-21101);
		binaryStream_0.fUeiimuocMk(this.int_0 << 13 | U.smethod_0(this.int_0, 19));
		binaryStream_0.fUeiimuocMk(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
	}

	public int Id;

	public int int_0;

	public int int_1;
}