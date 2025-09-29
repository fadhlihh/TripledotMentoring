using UnityEngine;

namespace TrainingTripledot
{

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
}
