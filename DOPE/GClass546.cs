﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass546 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 14547;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass546(int int_2 = 0, string string_1 = "", string string_2 = "", int int_3 = 0)
	{
		Class13.NP5bWyNzLwONS();
		this.Name = "";
		this.string_0 = "";
		base..ctor();
		this.int_1 = int_2;
		this.Name = string_1;
		this.string_0 = string_2;
		this.int_0 = int_3;
	}

	public virtual int vmethod_0()
	{
		return 14547;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void HrqIugnatr8(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 7 | U.smethod_0(this.int_0, 25));
		binaryStream_0.smethod_1();
		this.Name = binaryStream_0.smethod_2();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 2 | U.smethod_0(this.int_1, 30));
		this.string_0 = binaryStream_0.smethod_2();
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(14547);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 7) | this.int_0 << 25);
		binaryStream_0.smethod_7(23230);
		binaryStream_0.smethod_3(this.Name);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 2) | this.int_1 << 30);
		binaryStream_0.smethod_3(this.string_0);
	}

	public int int_0;

	public string Name;

	public int int_1;

	public string string_0;
}
