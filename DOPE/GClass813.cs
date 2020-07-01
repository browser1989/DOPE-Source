﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass813 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 275;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass813(int int_2 = 0, int int_3 = 0, Vector<int> vector_1 = null)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		if (vector_1 == null)
		{
			this.vector_0 = new Vector<int>();
			return;
		}
		this.vector_0 = vector_1;
	}

	public virtual int vmethod_0()
	{
		return 275;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 11) | this.int_1 << 21);
		while (this.vector_0.Length > 0)
		{
			this.vector_0.method_1();
		}
		int i = 0;
		int num = binaryStream_0.ReadByte();
		while (i < num)
		{
			int num2 = binaryStream_0.smethod_0();
			num2 = (num2 << 1 | U.smethod_0(num2, 31));
			this.vector_0.method_0(num2);
			i++;
		}
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(275);
		binaryStream_0.smethod_4(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.smethod_4(this.int_1 << 11 | U.smethod_0(this.int_1, 21));
		binaryStream_0.WriteByte(this.vector_0.Length);
		foreach (int num in this.vector_0)
		{
			binaryStream_0.smethod_4(U.smethod_0(num, 1) | num << 31);
		}
	}

	public int int_0;

	public int int_1;

	public Vector<int> vector_0;
}
