using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportUıController : MonoBehaviour
{
    public GameObject buttonPanel; // Butonları içeren panel

    void Start()
    {
        // Başlangıçta paneli gizli hale getirir
        buttonPanel.SetActive(false);
    }

    void Update()
    {
        // Belirli bir tuşa basıldığında paneli açar/kapatır
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Panelin aktifliğini değiştirir (açıkken kapatır, kapalıyken açar)
            buttonPanel.SetActive(!buttonPanel.activeSelf);
        }
    }
}
