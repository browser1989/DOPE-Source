﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass172 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 2;
		}
	}

	public GClass172(string string_0 = "", int int_1 = 0)
	{
		Class13.F93tSdiz1aNIA();
		this.CsyIaJbmBQ = "";
		base..ctor();
		this.CsyIaJbmBQ = string_0;
		this.int_0 = int_1;
	}

	public virtual int vmethod_0()
	{
		return 14;
	}

	public virtual int vmethod_1()
	{
		return 2;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.CsyIaJbmBQ = binaryStream_0.smethod_2();
		this.int_0 = (int)binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14);
		binaryStream_0.smethod_3(this.CsyIaJbmBQ);
		binaryStream_0.smethod_7(this.int_0);
	}

	public string CsyIaJbmBQ;

	public int int_0;
}
