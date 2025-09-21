using UnityEngine;

[System.AttributeUsage(System.AttributeTargets.Field, AllowMultiple = true)]
public class TitleAttribute : PropertyAttribute
{
    public string Title { get; private set; }

    public TitleAttribute(string title)
    {
        this.Title = title;
    }
}
