using UnityEngine;
using UnityEngine.Tilemaps;

public class Tuzak : MonoBehaviour
{
    public Tilemap tilemap; // Yok edilecek Tilemap

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Oyuncu ile çarpýþma durumunu kontrol edin (bu kodu isteðinize göre ayarlayabilirsiniz)
        if (collision.gameObject.CompareTag("Player"))
        {
            // Tilemap'i yok et
            Destroy(tilemap.gameObject);
        }
    }
}
