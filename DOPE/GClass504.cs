﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass504 : GClass501, GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23129;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 1;
		}
	}

	public GClass504(bool bool_1 = false)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.bool_0 = bool_1;
	}

	public override int vmethod_0()
	{
		return -23129;
	}

	public override int vmethod_1()
	{
		return 1;
	}

	public override void imethod_0(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		base.imethod_0(binaryStream_0);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public override void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23129);
		base.imethod_1(binaryStream_0);
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public bool bool_0;
}
