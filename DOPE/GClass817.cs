﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using DarkorbitAPI.Structures;
using DOPE.Common.Models;

public class GClass817 : GClass816
{
	[CompilerGenerated]
	protected Dictionary<Vector2, DateTimeOffset> method_1()
	{
		return this.dictionary_0;
	}

	private GClass827 Behavior { get; }

	public GClass817(GClass810 gclass810_1)
	{
		Class8.xDph7tozmh5WD();
		base..ctor(gclass810_1, TargetMap.X6);
		GClass817.<>c__DisplayClass7_0 CS$<>8__locals1 = new GClass817.<>c__DisplayClass7_0();
		CS$<>8__locals1.random_0 = base.C.Game.Random;
		this.dictionary_0 = GClass817.list_0.ToDictionary(new Func<Vector2, Vector2>(CS$<>8__locals1.method_0), new Func<Vector2, DateTimeOffset>(GClass817.<>c.<>c_0.method_0));
		this.Behavior = new GClass827(gclass810_1, this);
	}

	public override MapProfile UpdateProfile(BotProfile botProfile_1)
	{
		if (botProfile_1 == null)
		{
			return null;
		}
		List<MapProfile> maps = botProfile_1.Maps;
		if (maps == null)
		{
			return null;
		}
		return maps.FirstOrDefault(new Func<MapProfile, bool>(GClass817.<>c.<>c_0.method_1));
	}

	protected override void OnBind()
	{
		base.C.Game.Map.ShipDestroyed += this.method_3;
		base.OnBind();
	}

	protected override void OnUnbind()
	{
		base.C.Game.Map.ShipDestroyed -= this.method_3;
		base.OnUnbind();
	}

	public override void UpdateState()
	{
		Vector2 vector = this.method_2();
		DateTimeOffset now = DateTimeOffset.Now;
		DateTimeOffset right = this.method_1()[vector];
		if (vector != this.BestSpawn)
		{
			this.BestSpawn = vector;
		}
		else if (base.C.Hero.Position == vector && (now - right).TotalSeconds > 15.0)
		{
			this.method_1()[vector] = GClass817.smethod_0(this.method_1()[vector], now.AddSeconds(300.0));
		}
		base.UpdateState();
	}

	public Vector2 BestSpawn
	{
		[CompilerGenerated]
		get
		{
			return this.vector2_0;
		}
		[CompilerGenerated]
		private set
		{
			if (this.vector2_0 == value)
			{
				return;
			}
			this.vector2_0 = value;
			this.method_0(Class5.propertyChangedEventArgs_3);
		}
	}

	private Vector2 method_2()
	{
		return this.method_1().OrderBy(new Func<KeyValuePair<Vector2, DateTimeOffset>, DateTimeOffset>(GClass817.<>c.<>c_0.method_2)).First<KeyValuePair<Vector2, DateTimeOffset>>().Key;
	}

	private void method_3(Map map_0, Ship ship_1)
	{
		NpcShip npcShip = ship_1 as NpcShip;
		if (npcShip != null)
		{
			NpcUtils.NpcType type = npcShip.Type;
			if (((type != null) ? type.Class : null) == NpcUtils.N_Cubikon)
			{
				GClass817.<>c__DisplayClass18_0 CS$<>8__locals1 = new GClass817.<>c__DisplayClass18_0();
				CS$<>8__locals1.vector2_0 = ship_1.Position;
				Vector2 vector = this.method_1().Keys.OrderBy(new Func<Vector2, float>(CS$<>8__locals1.method_0)).First<Vector2>();
				this.method_1()[vector] = DateTimeOffset.Now.AddSeconds(300.0);
				base.Log.Info<Vector2>("Cubikon at spawn {position} destroyed", vector);
			}
		}
	}

	public override GClass820 GetBehavior()
	{
		if (MapUtils.smethod_8(6, base.C.Hero.FactionId) == base.C.Map.MapId)
		{
			return this.Behavior;
		}
		return base.GetBehavior();
	}

	public override string ToString()
	{
		return "Cubikons";
	}

	// Note: this type is marked as 'beforefieldinit'.
	static GClass817()
	{
		Class8.xDph7tozmh5WD();
		GClass817.list_0 = new List<Vector2>
		{
			new Vector2(7500f, 3900f),
			new Vector2(13400f, 3900f),
			new Vector2(13400f, 7900f),
			new Vector2(7500f, 7900f)
		};
	}

	[CompilerGenerated]
	internal static DateTimeOffset smethod_0(DateTimeOffset dateTimeOffset_2, DateTimeOffset dateTimeOffset_3)
	{
		if (!(dateTimeOffset_2 > dateTimeOffset_3))
		{
			return dateTimeOffset_3;
		}
		return dateTimeOffset_2;
	}

	public static List<Vector2> list_0;

	[CompilerGenerated]
	private readonly Dictionary<Vector2, DateTimeOffset> dictionary_0;

	[CompilerGenerated]
	private readonly GClass827 dpbigrAjiux;

	[CompilerGenerated]
	private Vector2 vector2_0;
}