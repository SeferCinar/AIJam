using UnityEngine;

public class CharacterResize : MonoBehaviour
{
    public float resizeFactor = 0.25f; // Boyut de�i�tirme fakt�r�
    public float resizeSpeed = 5f; // Boyut de�i�tirme h�z�

    private Vector3 originalScale; // Orijinal �l�ek de�eri
    private Vector3 targetScale; // Hedef �l�ek de�eri
    private bool isResizing; // Boyut de�i�tirme durumunu takip et

    void Start()
    {
        originalScale = transform.localScale; // Ba�lang�� �l�e�ini kaydet
        targetScale = originalScale; // Hedef �l�e�i ba�lang�� �l�e�i olarak ayarla
    }

    void Update()
    {
        // X tu�una bas�ld���nda karakterin boyutunu k���lt
        if (Input.GetKeyDown(KeyCode.X) && !isResizing)
        {
            isResizing = true;
            targetScale = originalScale * resizeFactor; // Hedef �l�e�i k���lt
        }

        // Z tu�una bas�ld���nda karakterin boyutunu eski haline d�nd�r
        if (Input.GetKeyDown(KeyCode.Z) && !isResizing)
        {
            isResizing = true;
            targetScale = originalScale; // Hedef �l�e�i eski boyuta d�nd�r
        }

        // Karakterin boyutunu hedef �l�e�e do�ru yava��a de�i�tir
        if (transform.localScale != targetScale)
        {
            transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, resizeSpeed * Time.deltaTime);
        }

        // Boyut de�i�tirme i�lemi tamamland���nda durumu s�f�rla
        if (transform.localScale == targetScale)
        {
            isResizing = false;
        }
    }
}
