﻿using System;
using System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Delegate)]
public sealed class GAttribute4 : Attribute
{
	public GAttribute4([GAttribute1] string formatParameterName)
	{
		Class8.xDph7tozmh5WD();
		base..ctor();
		this.String_0 = formatParameterName;
	}

	[GAttribute1]
	public string String_0 { get; private set; }

	[CompilerGenerated]
	private string string_0;
}