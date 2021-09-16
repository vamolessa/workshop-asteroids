using UnityEngine;

public class ComportamentoAsteroide : MonoBehaviour
{
    public static System.Action EventoAsteroideDestruido = null;

    public Rigidbody2D meuRigidbody;
    public EfeitoAsteroideDestruido prefabEfeitos;
    public ComportamentoAsteroide prefabAsteroideMenor;

    public float velocidadeMaxima = 1.0f;
    public int quantidadeFragmentos = 3;

    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidbody.velocity = direcao;
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        for (int i = 0; i < quantidadeFragmentos; i++)
        {
            Instantiate(
                prefabAsteroideMenor,
                meuRigidbody.position,
                Quaternion.identity
            );
        }

        if (EventoAsteroideDestruido != null)
        {
            EventoAsteroideDestruido();
        }

		Instantiate(prefabEfeitos, meuRigidbody.position, Quaternion.identity);

        Destroy(gameObject);
        Destroy(outro.gameObject);
    }
}
