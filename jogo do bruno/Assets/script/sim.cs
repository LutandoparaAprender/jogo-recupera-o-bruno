using UnityEngine;

public class sim: MonoBehaviour
{
    public float amplitude = 30.0f;  // Amplitude do movimento de balan�o
    public float velocidade = 2.0f;  // Velocidade do balan�o

    private void Update()
    {
        // Calcula a posi��o de balan�o usando a fun��o seno
        float balanco = amplitude * Mathf.Sin(Time.time * velocidade);

        // Atualiza a posi��o da marreta
        transform.rotation = Quaternion.Euler(0, 0, balanco);
    }
}
