
using UnityEngine;

namespace ShapesXR.Import.Presets.Object
{
    public class ResourcePreset : BasePreset
    {
        [SerializeField] private ResourceType _resourceType;
        public ResourceType ResourceType => _resourceType;
    }
}