using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuadradaFilter: INoiseFilter
{
    Noise noise = new Noise();
    NoiseSettings.RigidNoiseSettings noiseSettings;

    public CuadradaFilter(NoiseSettings.RigidNoiseSettings noiseSettings)
    {
        this.noiseSettings = noiseSettings;
    }

    public float Evaluate (Vector3 point)
    {
        float noiseValue = 0;
        float frequency = noiseSettings.baseRoughness;
        float amplitude = 1;
        float weight = 1;

        for (int i = 0; i < noiseSettings.numLayers; i++)
        {
            float v = Mathf.Pow(noise.Evaluate(point * frequency + noiseSettings.center),2);
            // float v = Mathf.Sign(Mathf.Sin(noise.Evaluate(point * frequency + noiseSettings.center)));
            v *= v;
            v *= weight;
            weight = Mathf.Clamp01(v * noiseSettings.weightMultiplier);

            noiseValue += (v + 1) * 0.5f * amplitude;
            frequency *= noiseSettings.roughness;
            amplitude *= noiseSettings.persistance;
        }

        // noiseValue = Mathf.Max(0, noiseValue - noiseSettings.minValue);
        return noiseValue * noiseSettings.strength;
    }
}
