﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass451 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 198;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 12;
		}
	}

	public GClass451(int int_2 = 0, int int_3 = 0, int int_4 = 0)
	{
		Class13.F93tSdiz1aNIA();
		base..ctor();
		this.int_0 = int_2;
		this.int_1 = int_3;
		this.OmgstPsxXp = int_4;
	}

	public virtual int vmethod_0()
	{
		return 198;
	}

	public virtual int vmethod_1()
	{
		return 12;
	}

	public virtual void imethod_0(BinaryStream binaryStream_0)
	{
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (U.smethod_0(this.int_0, 8) | this.int_0 << 24);
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (this.int_1 << 9 | U.smethod_0(this.int_1, 23));
		this.OmgstPsxXp = binaryStream_0.smethod_0();
		this.OmgstPsxXp = (U.smethod_0(this.OmgstPsxXp, 12) | this.OmgstPsxXp << 20);
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_7(198);
		binaryStream_0.smethod_4(this.int_0 << 8 | U.smethod_0(this.int_0, 24));
		binaryStream_0.smethod_4(U.smethod_0(this.int_1, 9) | this.int_1 << 23);
		binaryStream_0.smethod_4(this.OmgstPsxXp << 12 | U.smethod_0(this.OmgstPsxXp, 20));
	}

	public int int_0;

	public int int_1;

	public int OmgstPsxXp;
}
