﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass483 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 31962;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 20;
		}
	}

	public GClass483(int int_0 = 0, Vector<GClass575> vector_3 = null, GClass498 gclass498_1 = null, Vector<GClass569> vector_4 = null, Vector<GClass694> vector_5 = null, string string_2 = "", string string_3 = "")
	{
		Class13.plZSWFPzBWWEZ();
		this.string_0 = "";
		this.string_1 = "";
		base..ctor();
		this.Id = int_0;
		if (vector_3 == null)
		{
			this.vector_0 = new Vector<GClass575>();
		}
		else
		{
			this.vector_0 = vector_3;
		}
		if (gclass498_1 == null)
		{
			this.gclass498_0 = new GClass498(0, false, false, false, 0, null);
		}
		else
		{
			this.gclass498_0 = gclass498_1;
		}
		if (vector_4 == null)
		{
			this.vector_1 = new Vector<GClass569>();
		}
		else
		{
			this.vector_1 = vector_4;
		}
		if (vector_5 == null)
		{
			this.vector_2 = new Vector<GClass694>();
		}
		else
		{
			this.vector_2 = vector_5;
		}
		this.string_1 = string_2;
		this.string_0 = string_3;
	}

	public virtual int vmethod_0()
	{
		return 31962;
	}

	public virtual int vmethod_1()
	{
		return 20;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.string_0 = binaryStream_0.smethod_2();
		binaryStream_0.smethod_1();
		this.Id = binaryStream_0.smethod_0();
		this.Id = (U.smethod_0(this.Id, 4) | this.Id << 28);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int num = 0;
		uint num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass575 gclass = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass575;
			gclass.imethod_1(binaryStream_0);
			this.vector_0.method_0(gclass);
			num++;
		}
		while (this.vector_1.Length > 0)
		{
			this.vector_1.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass569 gclass2 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass569;
			gclass2.imethod_1(binaryStream_0);
			this.vector_1.method_0(gclass2);
			num++;
		}
		this.gclass498_0 = (GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass498);
		this.gclass498_0.imethod_1(binaryStream_0);
		this.string_1 = binaryStream_0.smethod_2();
		while (this.vector_2.Length > 0)
		{
			this.vector_2.method_1();
		}
		num = 0;
		num2 = (uint)binaryStream_0.smethod_0();
		while ((long)num < (long)((ulong)num2))
		{
			GClass694 gclass3 = GClass86.smethod_2((int)binaryStream_0.smethod_1()) as GClass694;
			gclass3.imethod_1(binaryStream_0);
			this.vector_2.method_0(gclass3);
			num++;
		}
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(31962);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_3(this.string_0);
		binaryStream_0.smethod_7(22987);
		binaryStream_0.smethod_4(this.Id << 4 | U.smethod_0(this.Id, 28));
		binaryStream_0.smethod_4(this.vector_0.Length);
		foreach (GClass575 gclass in this.vector_0)
		{
			gclass.imethod_2(binaryStream_0);
		}
		binaryStream_0.smethod_4(this.vector_1.Length);
		foreach (GClass569 gclass2 in this.vector_1)
		{
			gclass2.imethod_2(binaryStream_0);
		}
		this.gclass498_0.imethod_2(binaryStream_0);
		binaryStream_0.smethod_3(this.string_1);
		binaryStream_0.smethod_4(this.vector_2.Length);
		foreach (GClass694 gclass3 in this.vector_2)
		{
			gclass3.imethod_2(binaryStream_0);
		}
	}

	public string string_0;

	public int Id;

	public Vector<GClass575> vector_0;

	public Vector<GClass569> vector_1;

	public GClass498 gclass498_0;

	public string string_1;

	public Vector<GClass694> vector_2;
}
