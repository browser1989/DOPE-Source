﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass160 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 22217;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass160()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 22217;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(22217);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(27748);
		binaryStream_0.smethod_7(14143);
	}
}
