﻿using System;
using DarkorbitAPI.CommonStructures;
using Syroot.BinaryData;

public class GClass249 : GInterface0
{
	short GInterface0.Id
	{
		get
		{
			return 27996;
		}
	}

	int GInterface0.SizeBytes
	{
		get
		{
			return 55;
		}
	}

	public GClass249(bool bool_23 = false, bool bool_24 = false, bool bool_25 = false, bool bool_26 = false, bool bool_27 = false, bool bool_28 = false, bool bool_29 = false, bool bool_30 = false, bool bool_31 = false, bool bool_32 = false, bool bool_33 = false, bool bool_34 = false, bool bool_35 = false, bool bool_36 = false, bool bool_37 = false, bool bool_38 = false, bool bool_39 = false, bool bool_40 = false, int int_8 = 0, int int_9 = 0, int int_10 = 0, int int_11 = 0, int int_12 = 0, int int_13 = 0, int int_14 = 0, int int_15 = 0, bool bool_41 = false, bool bool_42 = false, bool bool_43 = false, bool bool_44 = false, bool bool_45 = false)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.bool_19 = bool_23;
		this.bool_13 = bool_24;
		this.bool_10 = bool_25;
		this.bool_3 = bool_26;
		this.bool_2 = bool_27;
		this.bool_15 = bool_28;
		this.bool_4 = bool_29;
		this.bool_16 = bool_30;
		this.bool_5 = bool_31;
		this.bool_9 = bool_32;
		this.bool_11 = bool_33;
		this.bool_7 = bool_34;
		this.bool_0 = bool_35;
		this.bool_17 = bool_36;
		this.bool_14 = bool_37;
		this.bool_21 = bool_38;
		this.bool_20 = bool_39;
		this.bool_12 = bool_40;
		this.int_3 = int_8;
		this.int_0 = int_9;
		this.int_2 = int_10;
		this.int_4 = int_11;
		this.int_7 = int_12;
		this.int_6 = int_13;
		this.int_5 = int_14;
		this.int_1 = int_15;
		this.bool_6 = bool_41;
		this.bool_1 = bool_42;
		this.bool_22 = bool_43;
		this.bool_18 = bool_44;
		this.bool_8 = bool_45;
	}

	public virtual int vmethod_0()
	{
		return 27996;
	}

	public virtual int vmethod_1()
	{
		return 55;
	}

	public virtual void imethod_1(BinaryStream binaryStream_0)
	{
		this.bool_0 = binaryStream_0.ReadBoolean();
		this.int_0 = binaryStream_0.smethod_0();
		this.int_0 = (this.int_0 << 3 | U.smethod_0(this.int_0, 29));
		this.bool_1 = binaryStream_0.ReadBoolean();
		this.bool_2 = binaryStream_0.ReadBoolean();
		this.bool_3 = binaryStream_0.ReadBoolean();
		this.int_1 = binaryStream_0.smethod_0();
		this.int_1 = (U.smethod_0(this.int_1, 14) | this.int_1 << 18);
		this.bool_4 = binaryStream_0.ReadBoolean();
		this.bool_5 = binaryStream_0.ReadBoolean();
		this.bool_6 = binaryStream_0.ReadBoolean();
		this.int_2 = binaryStream_0.smethod_0();
		this.int_2 = (U.smethod_0(this.int_2, 9) | this.int_2 << 23);
		this.bool_7 = binaryStream_0.ReadBoolean();
		this.bool_8 = binaryStream_0.ReadBoolean();
		this.int_3 = binaryStream_0.smethod_0();
		this.int_3 = (this.int_3 << 4 | U.smethod_0(this.int_3, 28));
		this.bool_9 = binaryStream_0.ReadBoolean();
		this.bool_10 = binaryStream_0.ReadBoolean();
		this.bool_11 = binaryStream_0.ReadBoolean();
		this.bool_12 = binaryStream_0.ReadBoolean();
		this.bool_13 = binaryStream_0.ReadBoolean();
		this.bool_14 = binaryStream_0.ReadBoolean();
		this.bool_15 = binaryStream_0.ReadBoolean();
		this.bool_16 = binaryStream_0.ReadBoolean();
		this.bool_17 = binaryStream_0.ReadBoolean();
		this.int_4 = binaryStream_0.smethod_0();
		this.int_4 = (U.smethod_0(this.int_4, 15) | this.int_4 << 17);
		this.int_5 = binaryStream_0.smethod_0();
		this.int_5 = (this.int_5 << 13 | U.smethod_0(this.int_5, 19));
		this.bool_18 = binaryStream_0.ReadBoolean();
		this.bool_19 = binaryStream_0.ReadBoolean();
		this.bool_20 = binaryStream_0.ReadBoolean();
		this.int_6 = binaryStream_0.smethod_0();
		this.int_6 = (this.int_6 << 9 | U.smethod_0(this.int_6, 23));
		this.int_7 = binaryStream_0.smethod_0();
		this.int_7 = (U.smethod_0(this.int_7, 7) | this.int_7 << 25);
		this.bool_21 = binaryStream_0.ReadBoolean();
		this.bool_22 = binaryStream_0.ReadBoolean();
	}

	public virtual void imethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.smethod_5(27996);
		this.vmethod_2(binaryStream_0);
	}

	protected virtual void vmethod_2(BinaryStream binaryStream_0)
	{
		binaryStream_0.WriteBoolean(this.bool_0);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_0, 3) | this.int_0 << 29);
		binaryStream_0.WriteBoolean(this.bool_1);
		binaryStream_0.WriteBoolean(this.bool_2);
		binaryStream_0.WriteBoolean(this.bool_3);
		binaryStream_0.fUeiimuocMk(this.int_1 << 14 | U.smethod_0(this.int_1, 18));
		binaryStream_0.WriteBoolean(this.bool_4);
		binaryStream_0.WriteBoolean(this.bool_5);
		binaryStream_0.WriteBoolean(this.bool_6);
		binaryStream_0.fUeiimuocMk(this.int_2 << 9 | U.smethod_0(this.int_2, 23));
		binaryStream_0.WriteBoolean(this.bool_7);
		binaryStream_0.WriteBoolean(this.bool_8);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_3, 4) | this.int_3 << 28);
		binaryStream_0.WriteBoolean(this.bool_9);
		binaryStream_0.WriteBoolean(this.bool_10);
		binaryStream_0.WriteBoolean(this.bool_11);
		binaryStream_0.WriteBoolean(this.bool_12);
		binaryStream_0.WriteBoolean(this.bool_13);
		binaryStream_0.WriteBoolean(this.bool_14);
		binaryStream_0.WriteBoolean(this.bool_15);
		binaryStream_0.WriteBoolean(this.bool_16);
		binaryStream_0.WriteBoolean(this.bool_17);
		binaryStream_0.fUeiimuocMk(this.int_4 << 15 | U.smethod_0(this.int_4, 17));
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_5, 13) | this.int_5 << 19);
		binaryStream_0.WriteBoolean(this.bool_18);
		binaryStream_0.WriteBoolean(this.bool_19);
		binaryStream_0.WriteBoolean(this.bool_20);
		binaryStream_0.fUeiimuocMk(U.smethod_0(this.int_6, 9) | this.int_6 << 23);
		binaryStream_0.fUeiimuocMk(this.int_7 << 7 | U.smethod_0(this.int_7, 25));
		binaryStream_0.WriteBoolean(this.bool_21);
		binaryStream_0.WriteBoolean(this.bool_22);
	}

	public bool bool_0;

	public int int_0;

	public bool bool_1;

	public bool bool_2;

	public bool bool_3;

	public int int_1;

	public bool bool_4;

	public bool bool_5;

	public bool bool_6;

	public int int_2;

	public bool bool_7;

	public bool bool_8;

	public int int_3;

	public bool bool_9;

	public bool bool_10;

	public bool bool_11;

	public bool bool_12;

	public bool bool_13;

	public bool bool_14;

	public bool bool_15;

	public bool bool_16;

	public bool bool_17;

	public int int_4;

	public int int_5;

	public bool bool_18;

	public bool bool_19;

	public bool bool_20;

	public int int_6;

	public int int_7;

	public bool bool_21;

	public bool bool_22;
}