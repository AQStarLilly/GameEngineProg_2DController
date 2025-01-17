using UnityEngine;

public class ToggleVisibilityOnInteract : InteractableObject
{
    private Renderer objRenderer;

    protected override void Awake()
    {
        base.Awake();
        objRenderer = GetComponent<Renderer>();
    }

    protected override void OnInteractionEvent(bool isStarted)
    {
        base.OnInteractionEvent(isStarted);
        objRenderer.enabled = isStarted;
    }
}
