using UnityEngine;

public class FakePlayerMovement : MonoBehaviour
{
    public GameObject player; // Oyuncuyu tutacak GameObject'i atanır
    public GameObject obj1; // Oyuncuyu tutacak GameObject'i atanır
    public GameObject obj2; // Oyuncuyu tutacak GameObject'i atanır
    public GameObject obj3; // Oyuncuyu tutacak GameObject'i atanır

    void Update()
    {
        if(player != null)
        {
            // Oyuncunun X pozisyonunu al
            float playerX = player.transform.position.x;
            float playerY = player.transform.position.y;

            // Diğer iki GameObject'in X pozisyonunu ayarla
            obj1.transform.position = new Vector3(playerX, obj1.transform.position.y, obj1.transform.position.z);
            obj2.transform.position = new Vector3(playerX, obj2.transform.position.y, obj2.transform.position.z);
            obj3.transform.position = new Vector3(playerX, obj3.transform.position.y, obj3.transform.position.z);
        }
    }
}
