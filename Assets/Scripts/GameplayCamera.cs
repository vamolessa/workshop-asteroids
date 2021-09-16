using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayCamera : MonoBehaviour
{
    public static GameplayCamera instancia;

    public Camera minhaCamera;

    void Awake()
    {
        instancia = this;
    }
}
