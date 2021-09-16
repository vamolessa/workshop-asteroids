using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InterfacePontuacao : MonoBehaviour
{
    public TMP_Text textoPontuacao;
    public int pontuacao;

    void Awake()
    {
        textoPontuacao.text = "";

        ComportamentoAsteroide.EventoAsteroideDestruido += AsteroideFoiDestruido;
    }

    void OnDestroy()
    {
        ComportamentoAsteroide.EventoAsteroideDestruido -= AsteroideFoiDestruido;
    }

    void AsteroideFoiDestruido()
    {
        pontuacao += 100;
        AtualizaTextoPontuacao();
    }

    void AtualizaTextoPontuacao()
    {
        textoPontuacao.text = pontuacao.ToString();
    }
}
