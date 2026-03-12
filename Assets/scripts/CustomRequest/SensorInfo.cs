


using System.Collections.Generic;

[System.Serializable]
public class SensorInfo 
{
    public float temperatura = 0.0f;
    public float humedad = 0.0f;
    public List<SensorNombres> sensores;
    
}

[System.Serializable]
public class SensorNombres
{
    public string nombre = "";
}
