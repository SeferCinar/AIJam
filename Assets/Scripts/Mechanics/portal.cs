using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform destination; // Iþýnlanma hedefi

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Karakter bu porta temas ettiðinde iþlem yap
        if (other.CompareTag("Player"))
        {
            other.transform.position = destination.position; // Karakterin pozisyonunu hedefe ayarla
        }
    }
}
