using UnityEngine;

public class CharacterResize : MonoBehaviour
{
    public float resizeFactor = 0.25f; // Boyut deðiþtirme faktörü
    public float resizeSpeed = 5f; // Boyut deðiþtirme hýzý

    private Vector3 originalScale; // Orijinal ölçek deðeri
    private Vector3 targetScale; // Hedef ölçek deðeri
    private bool isResizing; // Boyut deðiþtirme durumunu takip et

    void Start()
    {
        originalScale = transform.localScale; // Baþlangýç ölçeðini kaydet
        targetScale = originalScale; // Hedef ölçeði baþlangýç ölçeði olarak ayarla
    }

    void Update()
    {
        // X tuþuna basýldýðýnda karakterin boyutunu küçült
        if (Input.GetKeyDown(KeyCode.X) && !isResizing)
        {
            isResizing = true;
            targetScale = originalScale * resizeFactor; // Hedef ölçeði küçült
        }

        // Z tuþuna basýldýðýnda karakterin boyutunu eski haline döndür
        if (Input.GetKeyDown(KeyCode.Z) && !isResizing)
        {
            isResizing = true;
            targetScale = originalScale; // Hedef ölçeði eski boyuta döndür
        }

        // Karakterin boyutunu hedef ölçeðe doðru yavaþça deðiþtir
        if (transform.localScale != targetScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, resizeSpeed * Time.deltaTime);
        }

        // Boyut deðiþtirme iþlemi tamamlandýðýnda durumu sýfýrla
        if (transform.localScale == targetScale)
        {
            isResizing = false;
        }
    }
}
