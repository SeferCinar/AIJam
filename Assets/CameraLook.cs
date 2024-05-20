using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Cinemachine;

public class ButtonCameraSwitcher2 : MonoBehaviour
{
    public CinemachineVirtualCamera VCam1;
    public CinemachineVirtualCamera VCam2;
    public CinemachineVirtualCamera VCam3;

    public Button button1;
    public Button button2;
    public Button button3;
    public float hoverOpacity = 0.90f;
    private Color originalColor;

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
        entryEnter.callback.AddListener((eventData) => { SwitchCamera(cameraIndex); 
        SetOpacity(button, hoverOpacity);
        });

        EventTrigger.Entry entryExit = new EventTrigger.Entry();
        entryExit.eventID = EventTriggerType.PointerExit;
        entryExit.callback.AddListener((eventData) => { ResetOpacity(button); });

        EventTrigger.Entry entryClick = new EventTrigger.Entry();
        entryClick.eventID = EventTriggerType.PointerClick;
        entryClick.callback.AddListener((eventData) => {VCam1.Priority = 10;
        VCam2.Priority =0;
         VCam3.Priority =0;
         });

        trigger.triggers.Add(entryEnter);
        trigger.triggers.Add(entryExit);
        trigger.triggers.Add(entryClick);
    }

    private void SwitchCamera(int cameraIndex)
    {
        VCam1.Priority = (cameraIndex == 1) ? 10 : 0;
        VCam2.Priority = (cameraIndex == 2) ? 10 : 0;
        VCam3.Priority = (cameraIndex == 3) ? 10 : 0;
    }
     private void SetOpacity(Button button, float opacity)
    {
        Image image = button.GetComponent<Image>();
        if (image != null)
        {
            originalColor = image.color;
            Color color = image.color;
            color.a = opacity;
            image.color = color;
        }
    }

    private void ResetOpacity(Button button)
    {
        Image image = button.GetComponent<Image>();
        if (image != null)
        {
            image.color = originalColor;
        }
    }
}
