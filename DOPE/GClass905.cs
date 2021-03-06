﻿using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;

public class GClass905 : GClass904
{
	public GClass905(GClass890 gclass890_1)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(gclass890_1);
	}

	public override bool UntCgkpMdca(Ship ship_0, out Ship ship_1)
	{
		GClass905.<>c__DisplayClass1_0 CS$<>8__locals1;
		CS$<>8__locals1.gclass905_0 = this;
		ship_1 = null;
		if (base.UntCgkpMdca(ship_0, out ship_1))
		{
			return true;
		}
		CS$<>8__locals1.ship_0 = ship_0;
		if (CS$<>8__locals1.ship_0 == null)
		{
			return false;
		}
		Vector2 position = CS$<>8__locals1.ship_0.Position;
		Vector2 heroPosition = base.C.HeroPosition;
		NpcShip npcShip = CS$<>8__locals1.ship_0 as NpcShip;
		if (npcShip == null)
		{
			this.method_23(1.0, ref CS$<>8__locals1);
			return true;
		}
		if ((!base.C.IsAttacking || base.C.AttackingId != CS$<>8__locals1.ship_0.Id) && CS$<>8__locals1.ship_0 == base.C.Map.SelectedShip && !this.vmethod_5(npcShip))
		{
			bool flag = base.Hero.Pet.IsEnabled && base.Hero.Pet.TargetId == npcShip.Id;
			if ((npcShip.ShieldPercentage < 99f && !flag) || !this.vmethod_6(npcShip))
			{
				this.method_23(2.0, ref CS$<>8__locals1);
				return true;
			}
		}
		if (CS$<>8__locals1.ship_0.ShieldPercentage >= 98f && Vector2.Distance(position, heroPosition) > 3500f && CS$<>8__locals1.ship_0.HpMax - CS$<>8__locals1.ship_0.Hp <= 150000)
		{
			this.method_23(1.0, ref CS$<>8__locals1);
			return true;
		}
		return false;
	}

	[CompilerGenerated]
	private void method_23(double double_0, ref GClass905.<>c__DisplayClass1_0 <>c__DisplayClass1_0_0)
	{
		base.C.NpcLockout.method_1(<>c__DisplayClass1_0_0.ship_0.Id, double_0 * 10000.0);
	}
}
