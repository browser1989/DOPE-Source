﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass635 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 60;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass635()
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 60;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(60);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-10652);
	}
}
