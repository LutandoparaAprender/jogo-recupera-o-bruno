using UnityEngine;

public class botaosaida : MonoBehaviour
{
    public void SairDoCanvas()
    {
        FindObjectOfType<Wins>().DesativarCanvas();
    }

}