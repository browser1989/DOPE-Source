﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass305 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31889;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 4;
		}
	}

	public GClass305(Vector<GClass581> vector_1 = null)
	{
		Class13.NP5bWyNzLwONS();
		base..ctor();
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<GClass581>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 31889;
	}

	public virtual int vmethod_1()
	{
		return 4;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass581 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass581;
			gclass.HrqIugnatr8(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31889);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass581 gclass in this.vector_0)
		{
			gclass.imethod_1(binaryStream_0);
		}
		binaryStream_0.smethod_7(24880);
	}

	public Vector<GClass581> vector_0;
}
