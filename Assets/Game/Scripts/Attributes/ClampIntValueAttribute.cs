using UnityEngine;

public class ClampIntValueAttribute : PropertyAttribute
{
    public int MinValue { get; private set; }
    public int MaxValue { get; private set; }

    public ClampIntValueAttribute(int minValue, int maxValue)
    {
        this.MinValue = minValue;
        this.MaxValue = maxValue;
    }
}
