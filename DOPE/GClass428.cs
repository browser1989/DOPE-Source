﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass428 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 152;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass428(int int_0 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.IowsQoJcTI = int_0;
	}

	public virtual int vmethod_0()
	{
		return 152;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.IowsQoJcTI = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(152);
		binaryStream_0.smethod_7(this.IowsQoJcTI);
	}

	public int IowsQoJcTI;
}
