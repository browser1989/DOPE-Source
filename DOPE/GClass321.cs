﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass321 : GClass316, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 12463;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass321(int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
	}

	public override int vmethod_0()
	{
		return 12463;
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
		this.int_0 = (this.int_0 << 11 | U.smethod_0(this.int_0, 21));
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(12463);
		base.imethod_1(binaryStream_0);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 11) | this.int_0 << 21);
	}

	public int int_0;
}
