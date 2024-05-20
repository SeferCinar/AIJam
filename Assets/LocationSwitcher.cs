using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class LocationSwitcher : MonoBehaviour
{   
    public GameObject player;
    public GameObject obj1;
    public GameObject obj2;
    public GameObject obj3;

    public Button button1;
    public Button button2;
    public Button button3;

   
    void Start()
    {
        // Butonlara tıklama olaylarını ekliyoruz
        button1.onClick.AddListener(() => switchLocation(1));
        button2.onClick.AddListener(() => switchLocation(2));
        button3.onClick.AddListener(() => switchLocation(3));
    }

    void switchLocation(int x)
    {
        Vector3 tempPosition;


       switch(x)
        {
            case 1:
                player.transform.position = obj1.transform.position;
                break;
            case 2:
                player.transform.position = obj2.transform.position;
                break;
            case 3:
                player.transform.position = obj3.transform.position;
                break;
            default:
                Debug.LogError("Invalid location index: ");
                break;
        }
        /*switch (x)
        {
            case 1:
                switch (playerLocate)
                {
                    case 1:
                        // Do nothing
                        break;
                    case 2:
                        tempPosition = obj1.transform.position;
                        obj1.transform.position = obj2.transform.position;
                        obj2.transform.position = tempPosition;
                        playerLocate = 1; // Ana karakter obj1'e geçti
                        break;
                    case 3:
                        tempPosition = obj1.transform.position;
                        obj1.transform.position = obj3.transform.position;
                        obj3.transform.position = tempPosition;
                        playerLocate = 1; // Ana karakter obj1'e geçti
                        break;
                    default:
                        // Varsayılan kod bloğu
                        break;
                }
                break;
            case 2:
                switch (playerLocate)
                {
                    case 1:
                        tempPosition = obj2.transform.position;
                        obj2.transform.position = obj1.transform.position;
                        obj1.transform.position = tempPosition;
                        playerLocate = 2; // Ana karakter obj2'ye geçti
                        break;
                    case 2:
                        // Do nothing
                        break;
                    case 3:
                        tempPosition = obj2.transform.position;
                        obj2.transform.position = obj3.transform.position;
                        obj3.transform.position = tempPosition;
                        playerLocate = 2; // Ana karakter obj2'ye geçti
                        break;
                    default:
                        // Varsayılan kod bloğu
                        break;
                }
                break;
            case 3:
                switch (playerLocate)
                {
                    case 1:
                        tempPosition = obj3.transform.position;
                        obj3.transform.position = obj1.transform.position;
                        obj1.transform.position = tempPosition;
                        playerLocate = 3; // Ana karakter obj3'e geçti
                        break;
                    case 2:
                        tempPosition = obj3.transform.position;
                        obj3.transform.position = obj2.transform.position;
                        obj2.transform.position = tempPosition;
                        playerLocate = 3; // Ana karakter obj3'e geçti
                        break;
                    case 3:
                        // Do nothing
                        break;
                    default:
                        // Varsayılan kod bloğu
                        break;
                }
                break;
            default:
                // Varsayılan kod bloğu
                break;
        }*/
    }
}