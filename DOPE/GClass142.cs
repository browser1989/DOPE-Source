﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass142 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 4059;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass142(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.plZSWFPzBWWEZ();
		base..ctor();
		this.Id = int_2;
		this.int_1 = int_3;
		this.int_0 = int_4;
	}

	public virtual int vmethod_0()
	{
		return 4059;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 9) | this.int_0 << 23);
		this.Id = binaryStream_0.smethod_0();
		this.Id = (this.Id << 10 | U.smethod_0(this.Id, 22));
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		binaryStream_0.smethod_1();
		binaryStream_0.smethod_1();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(4059);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_4(this.int_0 << 9 | U.smethod_0(this.int_0, 23));
		binaryStream_0.smethod_4(U.smethod_0(this.Id, 10) | this.Id << 22);
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_7(-19683);
		binaryStream_0.smethod_7(-16174);
	}

	public int int_0;

	public int Id;

	public int int_1;
}
