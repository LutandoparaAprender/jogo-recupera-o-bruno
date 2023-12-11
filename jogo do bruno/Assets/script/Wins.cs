using UnityEngine;
using UnityEngine.UI;

public class Wins : MonoBehaviour
{
    public Canvas canvas;
    public Text textoCanva;
    public GameObject objetoParaDestruir; // Variável para armazenar o GameObject a ser destruído

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("canva"))
        {
            AtivarCanva();
        }
    }

    void AtivarCanva()
    {
        canvas.gameObject.SetActive(true);
        textoCanva.text = "parabens vc coletou as linguagens de programacao que vc havia perdido.";
    }

    public void DesativarCanvas()
    {
        Destroy(objetoParaDestruir); // Destruir o GameObject especificado
    }
}
