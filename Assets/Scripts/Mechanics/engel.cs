using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public Animator animator; // Animator component
    private bool isShaking = false;
    public float shakeDuration = 2f; // Titreme süresi

    void Start()
    {
        // Animator bileþeninin atanýp atanmadýðýný kontrol edin
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Çarpýþmanýn sadece engel ile olup olmadýðýný kontrol edin
        if (collision.gameObject.CompareTag("Player"))
        {
            isShaking = true;
            animator.SetTrigger("Shake");
            Invoke("Disappear", shakeDuration); // shakeDuration süresi kadar sonra Disappear fonksiyonunu çaðýr
        }
    }

    void Disappear()
    {
        Destroy(gameObject);
    }
}
