﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass766 : GClass765, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 3259;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 60;
		}
	}

	public GClass766(double double_3 = 0.0, double double_4 = 0.0, double double_5 = 0.0, int int_3 = 0, int int_4 = 0, int int_5 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor(double_3, double_4, double_5);
		this.int_2 = int_3;
		this.int_1 = int_4;
		this.int_0 = int_5;
	}

	public override int vmethod_0()
	{
		return 3259;
	}

	public override int vmethod_1()
	{
		return 60;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		base.imethod_1(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 11) | this.int_0 << 21);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 5) | this.int_1 << 27);
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 1 | U.smethod_0(this.int_2, 31));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(3259);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 11 | U.smethod_0(this.int_0, 21));
		binaryStream_0.smethod_4(this.int_1 << 5 | U.smethod_0(this.int_1, 27));
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 1) | this.int_2 << 31);
	}

	public int int_0;

	public int int_1;

	public int int_2;
}
