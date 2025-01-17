using UnityEngine;

public class ChangeColorOnInteract : InteractableObject
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
        objRenderer.material.color = isStarted ? Color.green : Color.red;
    }
}
