using UnityEngine;

public class ElevatorPlatform : MonoBehaviour
{
    public Transform targetPosition; // Asansörün ulaşmak istediği hedef pozisyon
    public float speed = 5f; // Asansörün hareket hızı

    private Vector3 initialPosition; // Asansörün başlangıç pozisyonu
    private bool moving = false; // Asansörün hareket edip etmediğini takip eder
    private Transform playerTransform; // Oyuncunun transformu

    void Start()
    {
        initialPosition = transform.position; // Başlangıç pozisyonunu kaydet
    }

    void Update()
    {
        if (moving && playerTransform != null)
        {
            // Asansör hedef pozisyona doğru hareket eder
            Vector3 oldPosition = transform.position;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
            Vector3 movementDelta = transform.position - oldPosition;

            // Oyuncunun pozisyonunu da asansörle birlikte güncelle
            playerTransform.position += movementDelta;

            Debug.Log("Elevator is moving towards the target position. Current position: " + transform.position);

            // Hedef pozisyona ulaşıp ulaşmadığını kontrol et
            if (Vector3.Distance(transform.position, targetPosition.position) < 0.01f)
            {
                moving = false;
                Debug.Log("Elevator has reached the target position and stopped.");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Eğer asansörün üzerine oyuncu çarparsa, asansör hareket etmeye başlar
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTransform = collision.transform;
            moving = true;

            // Konsola bir mesaj yazdır
            Debug.Log("Player has entered the elevator. Elevator is now moving.");
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        // Oyuncu asansörden ayrıldığında, onun transformunu sıfırlar
        if (collision.gameObject.CompareTag("Player"))
        {
            playerTransform = null;

            // Konsola bir mesaj yazdır
            Debug.Log("Player has exited the elevator.");
        }
    }
}
