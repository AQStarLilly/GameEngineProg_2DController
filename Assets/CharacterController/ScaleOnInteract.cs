using UnityEngine;

public class ScaleOnInteract : InteractableObject
{
    protected override void OnInteractionEvent(bool isStarted)
    {
        base.OnInteractionEvent(isStarted);
        transform.localScale = isStarted ? Vector3.one * 1.5f : Vector3.one;
    }
}
