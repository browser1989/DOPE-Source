﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass611 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 17585;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 17;
		}
	}

	public GClass611(int int_3 = 0, int int_4 = 0, int int_5 = 0, int int_6 = 0, bool bool_1 = false)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		this.Id = int_3;
		this.int_1 = int_4;
		this.int_2 = int_5;
		this.int_0 = int_6;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 17585;
	}

	public virtual int vmethod_1()
	{
		return 17;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 4 | U.smethod_0(this.int_0, 28));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 1) | this.int_1 << 31);
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 4) | this.Id << 28);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 9 | U.smethod_0(this.int_2, 23));
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(17585);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31800);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 4) | this.int_0 << 28);
		binaryStream_0.smethod_4(this.int_1 << 1 | U.smethod_0(this.int_1, 31));
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.smethod_4(this.Id << 4 | U.smethod_0(this.Id, 28));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 9) | this.int_2 << 23);
	}

	public int int_0;

	public int int_1;

	public bool bool_0;

	public int Id;

	public int int_2;
}
