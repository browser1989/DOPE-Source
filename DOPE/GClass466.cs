﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass466 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 32739;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 5;
		}
	}

	public GClass466(bool bool_1 = false, int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_1;
		this.bool_0 = bool_1;
	}

	public virtual int vmethod_0()
	{
		return 32739;
	}

	public virtual int vmethod_1()
	{
		return 5;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 16) | this.int_0 << 16);
		this.bool_0 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(32739);
		binaryStream_0.smethod_4(this.int_0 << 16 | U.smethod_0(this.int_0, 16));
		binaryStream_0.WriteBoolean(this.bool_0);
	}

	public int int_0;

	public bool bool_0;
}
