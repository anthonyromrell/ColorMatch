using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent Event;

    void OnTriggerEnter()
    {
        Event.Invoke();
    }
}