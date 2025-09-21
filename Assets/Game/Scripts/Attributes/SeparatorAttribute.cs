using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true)]
public class SeparatorAttribute : PropertyAttribute
{
    public float Thickness { get; private set; }
    public float Spacing { get; private set; }

    public SeparatorAttribute(float thickness, float spacing)
    {
        this.Thickness = thickness;
        this.Spacing = spacing;
    }
}
