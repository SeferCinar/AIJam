using UnityEngine;

public class ObstacleCollision : MonoBehaviour
{
    public Animator animator; // Animator component
    private bool isShaking = false;
    public float shakeDuration = 2f; // Titreme s�resi

    void Start()
    {
        // Animator bile�eninin atan�p atanmad���n� kontrol edin
        if (animator == null)
        {
            animator = GetComponent<Animator>();
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �arp��man�n sadece engel ile olup olmad���n� kontrol edin
        if (collision.gameObject.CompareTag("Player"))
        {
            isShaking = true;
            animator.SetTrigger("Shake");
            Invoke("Disappear", shakeDuration); // shakeDuration s�resi kadar sonra Disappear fonksiyonunu �a��r
        }
    }

    void Disappear()
    {
        Destroy(gameObject);
    }
}
