using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NoiseSettings
{
    public enum FilterType { Simple, Rigid, Sen, Cos, Cuadrado, Sierra };

    [System.Serializable]
    public class SimpleNoiseSettings
    {
        public float strength = 1;
        [Range(1, 8)]
        public int numLayers = 1;
        public float baseRoughness = 1;
        public float roughness = 1;
        public float persistance = 1;
        public Vector3 center;
        public float minValue = 0;
    }

    [System.Serializable]
    public class RigidNoiseSettings: SimpleNoiseSettings
    {
        public float weightMultiplier = .0f;
    }


    [System.Serializable]
    public class DeltaTimeNoiseSettings: RigidNoiseSettings
    {
        public float deltaTime =  0.1f ;
    }

    public FilterType filterType;
    public SimpleNoiseSettings simpleNoiseSettings;
    public RigidNoiseSettings rigidNoiseSettings;

    public  DeltaTimeNoiseSettings deltatimenoisesettings;
}
