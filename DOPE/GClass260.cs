﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass260 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 21505;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass260()
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 21505;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(21505);
	}
}
