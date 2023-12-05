using UnityEngine;
using UnityEngine.UI;


public class player : MonoBehaviour
{
    public int moedasColetadas;
    public Rigidbody2D rb;
    public float moveSpeed;
    private float direction;

    private Vector3 facingRight;
    private Vector3 facingLeft;

    public bool taNoChao;
    public Transform detactaChao;
    public LayerMask oQueEhChao;

    public int pulosExtras = 0;

    public float superPuloForce = 15f;  // Força do super pulo

    void Update()
    {

        taNoChao = Physics2D.OverlapCircle(detactaChao.position, 0.2f, oQueEhChao);

        if (Input.GetButtonDown("Jump") && taNoChao == true)
        {
            rb.velocity = Vector2.up * 12;
        }
        else if (Input.GetButtonDown("Jump") && taNoChao == false && pulosExtras > 0)
        {
            rb.velocity = Vector2.up * 12;
            pulosExtras--;
        }
        if (taNoChao)
        {
            pulosExtras = 0;
        }

        direction = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trampolim"))
        {
            // Ao tocar no trampolim, aplicar super pulo
            rb.velocity = Vector2.up * superPuloForce;
        }
    }
}