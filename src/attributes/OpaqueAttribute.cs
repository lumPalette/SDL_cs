﻿using System;
using System.ComponentModel;

namespace SDL3;

/// <summary>
/// Indicates that a <see langword="struct"/> is opaque by design.
/// </summary>
[AttributeUsage(AttributeTargets.Struct)]
[EditorBrowsable(EditorBrowsableState.Never)]
public sealed class OpaqueAttribute : Attribute;