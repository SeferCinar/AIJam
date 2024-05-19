using UnityEngine;

public class Portal : MonoBehaviour
{
    public Transform destination; // I��nlanma hedefi

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Karakter bu porta temas etti�inde i�lem yap
        if (other.CompareTag("Player"))
        {
            other.transform.position = destination.position; // Karakterin pozisyonunu hedefe ayarla
        }
    }
}
