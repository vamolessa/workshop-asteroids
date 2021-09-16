using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicaoToroidal : MonoBehaviour
{
    const float MARGEM = 0.5f;

    public Rigidbody2D meuRigidbody;

    void Update()
    {
        Camera camera = GameplayCamera.instancia.minhaCamera;

        var maxX = camera.orthographicSize * camera.aspect;
        var maxY = camera.orthographicSize;

        float limiteEsquerda = -maxX;
        float limiteDireita = maxX;
        float limiteBaixo = -maxY;
        float limiteCima = maxY;

        Vector2 pos = meuRigidbody.position;
        if (pos.x < limiteEsquerda - MARGEM)
        {
            pos.x = limiteDireita + MARGEM;
        }
        else if (pos.x > limiteDireita + MARGEM)
        {
            pos.x = limiteEsquerda - MARGEM;
        }

        if (pos.y < limiteBaixo - MARGEM)
        {
            pos.y = limiteCima + MARGEM;
        }
        else if (pos.y > limiteCima + MARGEM)
        {
            pos.y = limiteBaixo - MARGEM;
        }
        meuRigidbody.position = pos;
    }
}
