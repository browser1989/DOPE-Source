﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass680 : GClass676, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 23772;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 8;
		}
	}

	public GClass680(string string_1 = "", int int_1 = 0)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor(string_1);
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 23772;
	}

	public override int vmethod_1()
	{
		return 8;
	}

	public override void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		base.HrqIugnatr8(binaryStream_0);
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_1();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(23772);
		this.vmethod_2(binaryStream_0);
	}

	protected override void vmethod_2(BinaryStream binaryStream_0)
	{
		base.vmethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		binaryStream_0.smethod_7(27377);
	}

	public int int_0;
}
