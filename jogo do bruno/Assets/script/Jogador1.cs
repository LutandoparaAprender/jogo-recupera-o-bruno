using UnityEngine;

public class Jogador1 : MonoBehaviour
{
    public Rigidbody2D rb;
    public float velocidadedeMovimento;
    public float forcaPulo;
    public float forcaPuloTrampolim;  // Força adicional quando em cima do trampolim
    bool isGround;

    public Transform foot;
    public LayerMask ground;
    public bool IsGround
    {
        get { return isGround; }
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Vector2 velocidade = this.rb.velocity;
        velocidade.x = horizontal * this.velocidadedeMovimento;
        this.rb.velocity = velocidade;

        isGround = Physics2D.OverlapCircle(foot.position, 0.2f, ground);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            float forcaDePulo = isGround ? forcaPulo : 0f;

            if (isTrampolimBelow())
            {
                forcaDePulo += forcaPuloTrampolim;
            }

            Vector2 forca = new Vector2(0, forcaDePulo);
            this.rb.AddForce(forca, ForceMode2D.Impulse);
        }
    }

    bool isTrampolimBelow()
    {
        // Verifica se há um objeto com a tag "Trampolim" abaixo do jogador
        Collider2D trampolimCollider2D = Physics2D.OverlapCircle(foot.position, 0.2f, LayerMask.GetMask("Trampolim"));

        return trampolimCollider2D != null;
    }
}
