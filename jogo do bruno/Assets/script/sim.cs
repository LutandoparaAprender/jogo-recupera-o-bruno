using UnityEngine;

public class sim: MonoBehaviour
{
    public float amplitude = 30.0f;  // Amplitude do movimento de balanço
    public float velocidade = 2.0f;  // Velocidade do balanço

    private void Update()
    {
        // Calcula a posição de balanço usando a função seno
        float balanco = amplitude * Mathf.Sin(Time.time * velocidade);

        // Atualiza a posição da marreta
        transform.rotation = Quaternion.Euler(0, 0, balanco);
    }
}
