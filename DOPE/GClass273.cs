﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass273 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -15496;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass273(Vector<GClass270> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass270>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -15496;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass270 gclass = (GClass270)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-15496);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass270 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass270> vector_0;
}
