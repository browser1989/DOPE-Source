﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass419 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return -11674;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass419(Vector<GClass377> vector_1 = null, int int_1 = 0)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
		this.int_0 = int_1;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass377>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return -11674;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = (int)binaryStream_0.smethod_1();
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			GClass377 gclass = (GClass377)GClass86.smethod_2((int)binaryStream_0.smethod_1());
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			i++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(-11674);
		binaryStream_0.smethod_7(this.int_0);
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (GClass377 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
	}

	public int int_0;

	public Vector<GClass377> vector_0;
}
