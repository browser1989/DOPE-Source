﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass622 : GClass618, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -15348;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass622(string string_0 = "", int int_0 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(string_0);
		this.Value = int_0;
	}

	public override int vmethod_0()
	{
		return -15348;
	}

	public override int vmethod_1()
	{
		return 4;
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_1(binaryStream_0);
		this.Value = binaryStream_0.smethod_0();
		this.Value = (this.Value << 5 | U.smethod_0(this.Value, 27));
	}

	public override void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15348);
		base.imethod_2(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.Value, 5) | this.Value << 27);
	}

	public int Value;
}
