using UnityEngine;

public class InteractableObject : MonoBehaviour
{
   protected virtual void Awake()
    {
        Actions.InteractionEvent += OnInteractionEvent;
    }

    protected virtual void OnInteractionEvent(bool isStarted)
    {
        Debug.Log($"{gameObject.name} recieved interaction event: {isStarted}");
    }

    protected virtual void OnDisable()
    {
        Actions.InteractionEvent -= OnInteractionEvent;
    }
}
