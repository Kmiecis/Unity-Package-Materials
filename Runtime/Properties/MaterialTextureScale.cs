using UnityEngine;

namespace Common.Materializer
{
    public class MaterialTextureScale : AMaterialValue<Vector2>
    {
        protected override void ApplyPropertyValue(Material material, int id, Vector2 value)
        {
            material.SetTextureScale(id, value);
        }

        protected override Vector2 ReadPropertyValue(Material material, int id)
        {
            return material.GetTextureScale(id);
        }

#if UNITY_EDITOR
        protected override void Reset()
        {
            base.Reset();

            PropertyValue = Vector2.one;
        }
#endif
    }
}