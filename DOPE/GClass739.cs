﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass739 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 1001;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 0;
		}
	}

	public GClass739()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}

	public virtual int vmethod_0()
	{
		return 1001;
	}

	public virtual int vmethod_1()
	{
		return 0;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(1001);
	}
}
