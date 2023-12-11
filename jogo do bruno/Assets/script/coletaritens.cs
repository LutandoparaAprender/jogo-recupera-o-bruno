using UnityEngine;
using UnityEngine.UI;

public class coletaritens : MonoBehaviour
{
    public Canvas canvas;
    public Text mensagemText;

    // Nomes dos itens específicos
    public string nomeItem1 = "Csharp";
    public string nomeItem2 = "Javascript";
    public string nomeItem3 = "HTML";

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("itens"))
        {
            ColetarItem(other.gameObject);
        }
    }

    void ColetarItem(GameObject item)
    {
        string nomeItemColetado = item.name; // Obtém o nome do item coletado
        Debug.Log("Item coletado: " + nomeItemColetado);
        item.SetActive(false);

        AtivarCanvas(); // Ativar o Canvas ao coletar um item
        AtualizarTextoMoedas(nomeItemColetado);
        ExibirMensagem(nomeItemColetado + " coletado!");
    }

    void AtualizarTextoMoedas(string nomeItem)
    {
        mensagemText.text = "Item coletado: " + nomeItem;
    }

    void AtivarCanvas()
    {
        if (!canvas.gameObject.activeSelf)
        {
            canvas.gameObject.SetActive(true); // Ativar o Canvas apenas se estiver desativado
        }
    }

    void ExibirMensagem(string mensagem)
    {
        mensagemText.text = mensagem;
        CancelInvoke("LimparMensagem");
        Invoke("LimparMensagem", 3f);
    }

    void LimparMensagem()
    {
        mensagemText.text = "";
        DesativarCanvas(); // Desativar o Canvas após limpar a mensagem
    }

    void DesativarCanvas()
    {
        if (canvas.gameObject.activeSelf)
        {
            canvas.gameObject.SetActive(false); // Desativar o Canvas apenas se estiver ativado
        }
    }
}
