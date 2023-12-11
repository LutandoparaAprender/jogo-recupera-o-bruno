using UnityEngine;
using UnityEngine.UI;

public class canva : MonoBehaviour
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
        textoCanva.text = "Seja bem-vindo à Corrida Maluca! Você e um programador e perdeu tres linguagens de programacao" +
        " encontre as e vença o desafio.";
    }

    public void DesativarCanvas()
    {
        Destroy(objetoParaDestruir); // Destruir o GameObject especificado
    }
}
