﻿using System;
using DarkorbitAPI;
using DarkorbitAPI.Structures;

public class GClass97 : GInterface4
{
	public GroupManager Group
	{
		get
		{
			return ConnectionManager.Instance.Value.Game.Hero.Group;
		}
	}

	public void method_0(GClass195 gclass195_0)
	{
		this.Group.method_3(gclass195_0);
	}

	public void method_1(GClass213 gclass213_0)
	{
		this.Group.method_4(gclass213_0);
	}

	public void method_2(GClass192 gclass192_0)
	{
		this.Group.method_8(gclass192_0);
	}

	public void method_3(GClass214 gclass214_0)
	{
		this.Group.method_9(gclass214_0);
	}

	public void method_4(GClass193 gclass193_0)
	{
		this.Group.method_6(gclass193_0);
	}

	public void method_5(GClass194 gclass194_0)
	{
		this.Group.method_5(gclass194_0);
	}

	public void method_6(GClass211 gclass211_0)
	{
		this.Group.method_7(gclass211_0);
	}

	public void method_7(GClass212 gclass212_0)
	{
		this.Group.method_10(gclass212_0);
	}

	public GClass97()
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor();
	}
}
