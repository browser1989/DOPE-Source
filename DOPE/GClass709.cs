﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass709 : GClass708, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -17173;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass709(string string_1 = "", int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return -17173;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 5) | this.int_0 << 27);
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-17173);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(this.int_0 << 5 | U.smethod_0(this.int_0, 27));
	}

	public int int_0;
}
