public static class NoiseFactory
{
    public static INoiseFilter CreateNoiseFilter(NoiseSettings noiseSettings)
    {
        switch(noiseSettings.filterType)
        {
            case NoiseSettings.FilterType.Simple:
                return new SimpleNoiseFilter(noiseSettings.simpleNoiseSettings);
            case NoiseSettings.FilterType.Rigid:
                return new RigidNoiseFilter(noiseSettings.rigidNoiseSettings);
            case NoiseSettings.FilterType.Sen:
                return new SenFilter(noiseSettings.rigidNoiseSettings);
            case NoiseSettings.FilterType.Cos:
                return new CosenoFilter(noiseSettings.rigidNoiseSettings);
            case NoiseSettings.FilterType.Cuadrado:
                return new CuadradaFilter(noiseSettings.rigidNoiseSettings);
            case NoiseSettings.FilterType.Sierra:
                return new DientesSierraFilter(noiseSettings.rigidNoiseSettings);
        }
        return null;
    }
}
