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
        
    }
}