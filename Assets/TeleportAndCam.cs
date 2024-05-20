using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Cinemachine;

public class TeleportAndCam : MonoBehaviour
{
    public CinemachineVirtualCamera VCam1;
    public CinemachineVirtualCamera VCam2;
    public CinemachineVirtualCamera VCam3;

    public Button button1;
    public Button button2;
    public Button button3;

    public GameObject player; // Ana karakter objesi
    public GameObject obj1; // Hedef GameObject 1
    public GameObject obj2; // Hedef GameObject 2
    public GameObject obj3; // Hedef GameObject 3

    private void Start()
    {
        AddEventTrigger(button1, 1);
        AddEventTrigger(button2, 2);
        AddEventTrigger(button3, 3);
    }

    private void AddEventTrigger(Button button, int cameraIndex)
    {
        EventTrigger trigger = button.gameObject.AddComponent<EventTrigger>();

        EventTrigger.Entry entryEnter = new EventTrigger.Entry();
        entryEnter.eventID = EventTriggerType.PointerEnter;
        entryEnter.callback.AddListener((eventData) => { SwitchCamera(cameraIndex); });

        EventTrigger.Entry entryClick = new EventTrigger.Entry();
        entryClick.eventID = EventTriggerType.PointerClick;
        entryClick.callback.AddListener((eventData) => { TeleportPlayer(cameraIndex); });

        trigger.triggers.Add(entryEnter);
        trigger.triggers.Add(entryClick);
    }

    private void SwitchCamera(int cameraIndex)
    {
        VCam1.Priority = (cameraIndex == 1) ? 10 : 0;
        VCam2.Priority = (cameraIndex == 2) ? 10 : 0;
        VCam3.Priority = (cameraIndex == 3) ? 10 : 0;
    }

    private void TeleportPlayer(int locationIndex)
    {
        switch (locationIndex)
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
                break;
        }
    }
}
