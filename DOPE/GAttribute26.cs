﻿using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = true)]
public sealed class GAttribute26 : Attribute
{
	public GAttribute26([GAttribute1] string format)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.String_0 = format;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;
}