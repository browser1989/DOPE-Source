﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass749 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 10121;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 16;
		}
	}

	public GClass749(int int_3 = 0, int int_4 = 0, int int_5 = 0, Vector<GClass746> vector_1 = null)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.int_2 = int_3;
		this.int_0 = int_4;
		this.int_1 = int_5;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass746>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 10121;
	}

	public virtual int vmethod_1()
	{
		return 16;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass746 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass746;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 2) | this.int_0 << 30);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 13 | U.smethod_0(this.int_1, 19));
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (this.int_2 << 8 | U.smethod_0(this.int_2, 24));
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(10121);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass746 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.int_0 << 2 | U.smethod_0(this.int_0, 30));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 13) | this.int_1 << 19);
		binaryStream_0.smethod_4(U.smethod_0(this.int_2, 8) | this.int_2 << 24);
	}

	public Vector<GClass746> vector_0;

	public int int_0;

	public int int_1;

	public int int_2;
}
