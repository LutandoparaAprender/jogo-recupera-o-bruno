using UnityEngine;

public class saircanva : MonoBehaviour
{
    public void SairDoCanvas()
    {
        FindObjectOfType<canva>().DesativarCanvas();
    }

}