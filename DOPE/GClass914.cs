﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.CommonStructures;
using DarkorbitAPI.Packets.Static;
using DarkorbitAPI.Structures;
using DarkorbitAPI.Structures.Pathing;
using DOPE.Common.Models;
using DOPE.Common.Models.Bot;
using DOPE.UI.Models;

public class GClass914 : GClass904
{
	public GClass914(GClass890 gclass890_1)
	{
		Class13.lOBHd9Nzn7x2T();
		base..ctor(gclass890_1);
	}

	public override bool vmethod_25()
	{
		return base.vmethod_25() && !base.Map.Gates.Any<KeyValuePair<int, Gate>>();
	}

	public override bool vmethod_2(NpcShip npcShip_0)
	{
		return false;
	}

	public virtual bool vmethod_48(NpcShip npcShip_0)
	{
		if (base.Map.GG != (GEnum5)300)
		{
			SelectedNpcModel selectedNpcModel = this.vmethod_4(npcShip_0);
			return selectedNpcModel == null || !selectedNpcModel.GG_ChaseFleeing;
		}
		return false;
	}

	public virtual int vmethod_49()
	{
		if (base.Map.GG != (GEnum5)300)
		{
			return 100;
		}
		return 150;
	}

	public override bool vmethod_11(NpcShip npcShip_0)
	{
		bool flag;
		return npcShip_0 != null && (npcShip_0.HpPercentage <= 24.75f || base.Map.method_8(npcShip_0, out flag));
	}

	protected virtual bool vmethod_50(Ship ship_0, Ship ship_1)
	{
		int num = this.vmethod_49();
		bool flag = ship_1 != null && this.vmethod_11(ship_0 as NpcShip) && !this.vmethod_11(ship_1 as NpcShip);
		double num2 = (this.method_29() || flag) ? 0.0 : Math.Abs(GClass873.smethod_4(ship_0.Position - base.Context.HeroPosition, ship_1.Position - base.Context.HeroPosition));
		return (flag || Vector2.Distance(ship_1.Position, ship_0.Position) > (float)num) && num2 < 1.0;
	}

	public override bool UntCgkpMdca(Ship ship_0, out Ship ship_1)
	{
		ship_1 = null;
		if (ship_0 == null)
		{
			return false;
		}
		if (base.vmethod_0(ship_0, out ship_1, false))
		{
			return true;
		}
		if (ship_0 != null)
		{
			NpcShip npcShip = base.Context.method_73(200);
			CooldownTracker<BotAction> cooldowns = base.Context.Cooldowns;
			if (npcShip != null && cooldowns.method_0(BotAction.SelectShip) && cooldowns.method_0(BotAction.TargetQuickSwitch) && npcShip != ship_0 && this.vmethod_50(ship_0, npcShip))
			{
				cooldowns.method_1(BotAction.TargetQuickSwitch, 625.0);
				ship_1 = npcShip;
				return true;
			}
		}
		if (base.C.AttackingId == ship_0.Id && this.vmethod_48(ship_0 as NpcShip) && ship_0.HpPercentage < 24.75f && base.C.float_0 >= 24.75f && base.C.method_75().Any(new Func<NpcShip, bool>(this.method_39)))
		{
			base.C.NpcLockout.method_1(ship_0.Id, 1428.0);
			return true;
		}
		return false;
	}

	public bool method_23()
	{
		return base.C.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(this.method_40)) && !this.vmethod_3(true, false);
	}

	public override bool vmethod_12(Collectible collectible_0)
	{
		return base.vmethod_12(collectible_0) && !this.method_23();
	}

	public override bool vmethod_14()
	{
		return !base.C.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(GClass914.<>c.<>c_0.method_0)) && base.C.Map.Gates.Any<KeyValuePair<int, Gate>>() && !base.C.method_77() && base.C.DormantTargets.Count == 0 && base.C.Game.Web.GgInfo != null;
	}

	public override bool vmethod_23(out Vector2? nullable_0)
	{
		if (!base.Map.Ships.Any(new Func<KeyValuePair<int, Ship>, bool>(GClass914.<>c.<>c_0.method_1)) && !base.Map.Collectibles.Any<KeyValuePair<string, Collectible>>() && !base.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			nullable_0 = null;
			return true;
		}
		return base.vmethod_23(out nullable_0);
	}

	public override bool vmethod_15()
	{
		return false;
	}

	public override bool vmethod_3(bool bool_8 = false, bool bool_9 = false)
	{
		Vector2 heroPosition = base.C.HeroPosition;
		if (!bool_8)
		{
			return true;
		}
		if (base.Context.Map.method_2(heroPosition, 100) && !base.Map.Collectibles.Any(new Func<KeyValuePair<string, Collectible>, bool>(this.method_41)))
		{
			return false;
		}
		Ship ship = base.C.Map.method_5<Ship>(heroPosition, new Func<Ship, bool>(GClass914.<>c.<>c_0.method_2), null, 0);
		return ship == null || Vector2.Distance(heroPosition, ship.Position) >= 2000f;
	}

	public override bool vmethod_18(GClass892 gclass892_0)
	{
		if (!base.Context.Map.Gates.Any<KeyValuePair<int, Gate>>())
		{
			GClass900 gclass = gclass892_0 as GClass900;
			return gclass != null && gclass.GalaxyGateType == MapUtils.smethod_10(base.C.Map.MapId);
		}
		return true;
	}

	public override Vector2? vmethod_19(Vector2 vector2_1, out Gate gate_0, bool bool_8 = false, bool bool_9 = true)
	{
		GClass914.<>c__DisplayClass16_0 CS$<>8__locals1 = new GClass914.<>c__DisplayClass16_0();
		Map map = base.C.Map;
		CS$<>8__locals1.int_0 = MapUtils.smethod_13(MapUtils.smethod_10(map.MapId));
		gate_0 = map.Gates.FirstOrDefault(new Func<KeyValuePair<int, Gate>, bool>(CS$<>8__locals1.method_0)).Value;
		Gate gate = gate_0;
		if (gate == null)
		{
			return null;
		}
		return new Vector2?(gate.Position);
	}

	public override Vector2? vmethod_20(bool bool_8)
	{
		GClass914.<>c__DisplayClass17_0 CS$<>8__locals1 = new GClass914.<>c__DisplayClass17_0();
		CS$<>8__locals1.gclass914_0 = this;
		Vector2? vector = null;
		CS$<>8__locals1.vector2_0 = base.C.HeroPosition;
		if (base.C.Map.method_5<Ship>(CS$<>8__locals1.vector2_0, new Func<Ship, bool>(GClass914.<>c.<>c_0.method_3), null, 0) == null)
		{
			vector = new Vector2?(base.C.Map.Center);
		}
		else if (this.method_29())
		{
			vector = this.iOgCgYpyBdo(CS$<>8__locals1.vector2_0, base.C.Map.Center, (float)base.C.Map.MapSize.Height * 0.4f, null, this.method_31() ? -0.5f : 0.5f);
		}
		else
		{
			CS$<>8__locals1.vector2_1 = (this.vmethod_39(CS$<>8__locals1.vector2_0, 2250) ?? base.C.Map.Center);
			CS$<>8__locals1.float_0 = Math.Min(Vector2.Distance(base.Hero.Position, CS$<>8__locals1.vector2_1) + 500f, 2500f);
			CS$<>8__locals1.pathSequence_0 = null;
			Map.Navigators.method_4(new Action<MapNavigator>(CS$<>8__locals1.method_0), 0);
			if (CS$<>8__locals1.pathSequence_0 != null)
			{
				base.Map.Grid.method_14(CS$<>8__locals1.pathSequence_0);
			}
			PathSequence pathSequence_ = CS$<>8__locals1.pathSequence_0;
			vector = ((pathSequence_ != null) ? new Vector2?(pathSequence_.Destination) : null);
		}
		return new Vector2?(vector ?? base.C.Game.Security.method_5(base.Map, this.vmethod_16()));
	}

	public override bool vmethod_5(NpcShip npcShip_0)
	{
		return true;
	}

	public override bool vmethod_9(NpcShip npcShip_0)
	{
		GClass187 gclass;
		return !npcShip_0.HasModifier(EntityModifierType.INVINCIBILITY, out gclass);
	}

	public override int vmethod_8(NpcShip npcShip_0)
	{
		int num = base.vmethod_8(npcShip_0);
		bool flag;
		if (num > -100 && base.Map.method_8(npcShip_0, out flag))
		{
			return -100;
		}
		if (base.method_10() == KamikazeState.PullingEnemies)
		{
			return Math.Min(0, num);
		}
		NpcUtils.NpcClass @class = npcShip_0.Type.Class;
		int num2;
		if (@class != null && GClass914.dictionary_0.TryGetValue(@class, out num2))
		{
			num = num2;
		}
		if (this.vmethod_51(npcShip_0))
		{
			num++;
		}
		return num;
	}

	public virtual bool vmethod_51(NpcShip npcShip_0)
	{
		if (this.vmethod_11(npcShip_0))
		{
			SelectedNpcModel selectedNpcModel = this.vmethod_4(npcShip_0);
			return selectedNpcModel != null && selectedNpcModel.GG_ChaseFleeing;
		}
		return false;
	}

	public override bool vmethod_7(NpcShip npcShip_0)
	{
		return this.vmethod_9(npcShip_0) && base.C.NpcLockout.method_0(npcShip_0.Id);
	}

	public override bool vmethod_1(NpcShip npcShip_0)
	{
		return true;
	}

	public override void vmethod_10(NpcShip npcShip_0)
	{
		int range;
		if (npcShip_0.Type.Class != null && GClass914.dictionary_1.TryGetValue(npcShip_0.Type.Class, out range))
		{
			npcShip_0.Range = range;
			return;
		}
		base.vmethod_10(npcShip_0);
	}

	public override SelectedNpcModel vmethod_4(Ship ship_0)
	{
		GClass900 gclass = base.C.Module as GClass900;
		if (gclass == null)
		{
			return null;
		}
		return gclass.vmethod_2(ship_0);
	}

	private bool method_24(NpcShip npcShip_0, Vector2 vector2_1)
	{
		return !this.vmethod_11(npcShip_0) && Vector2.Distance(npcShip_0.method_1(50), vector2_1) < Vector2.Distance(npcShip_0.MovementSource, vector2_1);
	}

	public override bool vmethod_29()
	{
		GClass914.<>c__DisplayClass29_0 CS$<>8__locals1 = new GClass914.<>c__DisplayClass29_0();
		CS$<>8__locals1.gclass914_0 = this;
		Ship enemyTarget = base.C.EnemyTarget;
		CS$<>8__locals1.vector2_0 = base.Hero.Position;
		bool flag = false;
		SelectedNpcModel selectedNpcModel = this.vmethod_4(enemyTarget);
		if (selectedNpcModel != null && selectedNpcModel.UseKamikaze)
		{
			flag = true;
		}
		else if (base.C.MapProfile.GG_UseKamikazeCorner)
		{
			int attackingId = base.C.AttackingId;
			int? num = (enemyTarget != null) ? new int?(enemyTarget.Id) : null;
			bool flag2;
			if ((attackingId == num.GetValueOrDefault() & num != null) && base.Map.method_8(enemyTarget, out flag2))
			{
				flag = true;
			}
		}
		return flag & (this.method_35() || base.Map.All<NpcShip>(CS$<>8__locals1.vector2_0, new Func<NpcShip, bool>(CS$<>8__locals1.method_0), null, 0).Any<NpcShip>());
	}

	[CompilerGenerated]
	protected DateTimeOffset method_25()
	{
		return this.dateTimeOffset_0;
	}

	[CompilerGenerated]
	protected void method_26(DateTimeOffset dateTimeOffset_2)
	{
		this.dateTimeOffset_0 = dateTimeOffset_2;
	}

	protected virtual bool vmethod_52()
	{
		GClass914.<>c__DisplayClass34_0 CS$<>8__locals1 = new GClass914.<>c__DisplayClass34_0();
		CS$<>8__locals1.gclass914_0 = this;
		if ((double)base.C.method_14() * 2.6 > (double)(base.Hero.Hp + base.Hero.Shield))
		{
			return false;
		}
		CS$<>8__locals1.vector2_0 = base.Hero.Position;
		Func<NpcShip, bool> selector = this.method_37() ? new Func<NpcShip, bool>(CS$<>8__locals1.method_1) : new Func<NpcShip, bool>(CS$<>8__locals1.method_0);
		return base.Map.All<NpcShip>(CS$<>8__locals1.vector2_0, selector, null, 0).Count<NpcShip>() > 2;
	}

	protected override KamikazeState vmethod_28()
	{
		KamikazeState kamikazeState = base.vmethod_28();
		if (kamikazeState == KamikazeState.Activating)
		{
			if (base.method_10() != KamikazeState.PullingEnemies && this.method_25().Cooldown(25000))
			{
				this.method_26(DateTimeOffset.Now);
			}
			int int_ = this.method_37() ? 45000 : 10000;
			if (this.method_35() && this.method_25().smethod_0(int_))
			{
				kamikazeState = KamikazeState.PullingEnemies;
			}
		}
		return kamikazeState;
	}

	public override bool vmethod_30(out int int_1)
	{
		int_1 = 0;
		return false;
	}

	public override Vector2? vmethod_43(Vector2 vector2_1, NpcShip npcShip_0, Vector2? nullable_0 = null, float float_0 = 0.5f)
	{
		if (!this.method_27())
		{
			return base.vmethod_43(vector2_1, npcShip_0, nullable_0, float_0);
		}
		Vector2? vector = this.vmethod_39(vector2_1, 1100);
		Vector2 vector2;
		int num = this.vmethod_41(vector2_1, npcShip_0, out vector2);
		Vector2 center = base.Map.Center;
		if (vector != null && this.method_33().Cooldown(10000))
		{
			Vector2 value = vector.Value;
			bool flag = this.method_31();
			this.method_32(GClass873.smethod_2(vector2_1.Y - center.Y, vector2_1.X - center.X, value.Y - center.Y, value.X - center.X));
			if (flag != this.method_31())
			{
				this.method_34(DateTimeOffset.Now);
			}
		}
		float_0 = 0f;
		float num2 = (float)base.Map.MapSize.Height * 0.42f;
		PointF pointF;
		PointF pointF2;
		int num3 = GClass878.smethod_0(center.X, center.Y, num2, vector2.X, vector2.Y, (float)num, out pointF, out pointF2);
		double num4;
		if (num3 == 2)
		{
			num4 = GClass873.smethod_3(pointF.Y - center.Y, pointF.X - center.X, pointF2.Y - center.Y, pointF2.X - center.X, false);
		}
		else
		{
			num4 = Math.Atan2((double)(vector2.X - center.X), (double)(vector2.Y - center.Y)) + (double)(this.method_31() ? -0.5f : 0.5f);
		}
		Vector2 value2 = GClass873.smethod_8(center, num2, (float)num4);
		if (num3 != 0)
		{
			this.method_30(true);
			return new Vector2?(value2);
		}
		this.method_30(false);
		if (npcShip_0.TemporarySpeed > 0f)
		{
			return base.vmethod_43(vector2_1, npcShip_0, new Vector2?(value2), 0.5f);
		}
		return base.vmethod_43(vector2_1, npcShip_0, null, 0.5f);
	}

	[CompilerGenerated]
	public bool method_27()
	{
		return this.bool_3;
	}

	[CompilerGenerated]
	protected void method_28(bool bool_8)
	{
		this.bool_3 = bool_8;
	}

	protected virtual bool vmethod_53()
	{
		if (base.Map.Collidables.Count <= 0 && base.Map.GG != (GEnum5)300 && base.C.MapProfile.GG_DragNpcs)
		{
			bool flag = false;
			foreach (KeyValuePair<int, Ship> keyValuePair in base.Map.Ships)
			{
				if (keyValuePair.Value.IsNpc)
				{
					flag |= (keyValuePair.Value.TemporarySpeed > 0f);
					GClass187 gclass;
					if (keyValuePair.Value.HasModifier(EntityModifierType.INVINCIBILITY, out gclass))
					{
						return false;
					}
				}
			}
			return flag;
		}
		return false;
	}

	[CompilerGenerated]
	public bool method_29()
	{
		return this.bool_4;
	}

	[CompilerGenerated]
	protected void method_30(bool bool_8)
	{
		this.bool_4 = bool_8;
	}

	[CompilerGenerated]
	public bool method_31()
	{
		return this.bool_5;
	}

	[CompilerGenerated]
	protected void method_32(bool bool_8)
	{
		this.bool_5 = bool_8;
	}

	[CompilerGenerated]
	public DateTimeOffset method_33()
	{
		return this.dateTimeOffset_1;
	}

	[CompilerGenerated]
	protected void method_34(DateTimeOffset dateTimeOffset_2)
	{
		this.dateTimeOffset_1 = dateTimeOffset_2;
	}

	[CompilerGenerated]
	public bool method_35()
	{
		return this.bool_6;
	}

	[CompilerGenerated]
	protected void method_36(bool bool_8)
	{
		this.bool_6 = bool_8;
	}

	public bool method_37()
	{
		return this.bool_7;
	}

	internal void method_38(bool bool_8)
	{
		this.bool_7 = bool_8;
	}

	public override void Update()
	{
		this.method_36(this.vmethod_52());
		base.Update();
		this.method_28(this.vmethod_53());
		this.method_30(this.method_29() & this.method_27());
		if (!base.Map.Gates.Any<KeyValuePair<int, Gate>>() && base.C.State == BotState.Roam && base.C.StateIters > 6000)
		{
			base.C.method_71("GG-Behavior").Warn("Resetting connection because stuck in 'Roam' for >5 mins.");
			base.C.method_67(BotState.Default);
			base.Context.Game.Connection.Socket.Disconnect(ErrorReason.ConnectionOverridden, null, false);
		}
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass914()
	{
		Class13.lOBHd9Nzn7x2T();
		GClass914.dictionary_0 = new Dictionary<NpcUtils.NpcClass, int>
		{
			{
				NpcUtils.N_StreunerSpecialist,
				900
			},
			{
				NpcUtils.N_StreunerRocketeer,
				1000
			}
		};
		GClass914.dictionary_1 = new Dictionary<NpcUtils.NpcClass, int>
		{
			{
				NpcUtils.N_StreunerTurret,
				595
			}
		};
	}

	[CompilerGenerated]
	private bool method_39(NpcShip npcShip_0)
	{
		bool flag;
		return npcShip_0.HpPercentage > 24.75f && !base.C.Map.method_8(npcShip_0, out flag) && Vector2.Distance(base.C.HeroPosition, npcShip_0.Position) < 1200f;
	}

	[CompilerGenerated]
	private bool method_40(KeyValuePair<int, Ship> keyValuePair_0)
	{
		bool flag;
		return keyValuePair_0.Value.IsNpc && keyValuePair_0.Value.HpPercentage > 24.75f && !base.C.Map.method_8(keyValuePair_0.Value, out flag);
	}

	[CompilerGenerated]
	private bool method_41(KeyValuePair<string, Collectible> keyValuePair_0)
	{
		return Vector2.Distance(keyValuePair_0.Value.Position, base.Hero.Position) < 500f;
	}

	public static Dictionary<NpcUtils.NpcClass, int> dictionary_0;

	public static Dictionary<NpcUtils.NpcClass, int> dictionary_1;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_0;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private DateTimeOffset dateTimeOffset_1;

	[CompilerGenerated]
	private bool bool_6;

	private bool bool_7;
}
