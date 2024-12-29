﻿// <auto-generated />
#pragma warning disable

#if !NET7_0_OR_GREATER

namespace System.Runtime.Versioning;

using Diagnostics;
using Diagnostics.CodeAnalysis;

/// <summary>
/// Base type for all platform-specific API attributes.
/// </summary>
[ExcludeFromCodeCoverage]
[DebuggerNonUserCode]
#if PolyPublic
public
#endif
abstract class OSPlatformAttribute(string platformName) :
    Attribute
{
    public string PlatformName { get; } = platformName;
}

#endif