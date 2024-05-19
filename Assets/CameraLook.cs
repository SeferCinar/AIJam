using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Cinemachine;

public class ButtonCameraSwitcher : MonoBehaviour
{
    public CinemachineVirtualCamera VCam1;
    public CinemachineVirtualCamera VCam2;
    public CinemachineVirtualCamera VCam3;

    public Button button1;
    public Button button2;
    public Button button3;

    void Start()
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

        trigger.triggers.Add(entryEnter);
    }

    private void SwitchCamera(int cameraIndex)
    {
        VCam1.Priority = (cameraIndex == 1) ? 10 : 0;
        VCam2.Priority = (cameraIndex == 2) ? 10 : 0;
        VCam3.Priority = (cameraIndex == 3) ? 10 : 0;
    }
}
