﻿
using UnityEngine;

namespace ShapesXR.Import.Presets.Brush
{
    public sealed class MeshBrushPreset : BaseBrushPreset
    {
        [SerializeField] private Color _color = Color.white;

        [SerializeField] private bool _hardNormals;
        
        public Color Color => _color;
        public bool HardNormals => _hardNormals;

        public override IStrokeParameters GetParameters() => new ConvexHullParameters() { HardNormals = HardNormals };
    }
}