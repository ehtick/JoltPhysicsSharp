// Copyright © Amer Koleci and Contributors.
// Licensed under the MIT License (MIT). See LICENSE in the repository root for more information.

using static JoltPhysicsSharp.JoltApi;

namespace JoltPhysicsSharp;

public sealed class CylinderShapeSettings : ConvexShapeSettings
{
    public unsafe CylinderShapeSettings(float halfHeight, float radius, float convexRadius = Foundation.DefaultConvexRadius)
        : base(JPH_CylinderShapeSettings_Create(halfHeight, radius, convexRadius))
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="CylinderShapeSettings" /> class.
    /// </summary>
    ~CylinderShapeSettings() => Dispose(isDisposing: false);
}


public sealed class CylinderShape : ConvexShape
{
    public CylinderShape(float halfHeight, float radius)
        : base(JPH_CylinderShape_Create(halfHeight, radius))
    {
    }

    /// <summary>
    /// Finalizes an instance of the <see cref="CylinderShape" /> class.
    /// </summary>
    ~CylinderShape() => Dispose(isDisposing: false);

    public float Radius => JPH_CylinderShape_GetRadius(Handle);
    public float HalfHeight => JPH_CylinderShape_GetHalfHeight(Handle);
}
