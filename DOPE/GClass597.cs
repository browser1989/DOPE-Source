﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass597 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -23060;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass597(Vector<GClass197> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass197>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -23060;
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
			GClass197 gclass = (GClass197)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_0(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-23060);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass197 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
	}

	public Vector<GClass197> vector_0;
}
