﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerCode : MonoBehaviour
{
    public int PuntosTotales {get {return puntosTotales;}}
    private int puntosTotales;
    
    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales += puntosASumar + 10;
        Debug.Log(puntosTotales);
    }
}
