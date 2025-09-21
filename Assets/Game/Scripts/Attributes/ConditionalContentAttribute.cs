using UnityEngine;

public class ConditionalContentAttribute : PropertyAttribute
{
    public string Name { get; private set; }

    public ConditionalContentAttribute(string name)
    {
        this.Name = name;
    }
}
