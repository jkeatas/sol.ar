using UnityEngine;
using UnityEngine.InputSystem; // 新 Input System
using TMPro; // 如果你使用 TextMeshPro

public class PlanetClickable : MonoBehaviour
{
    public string planetName;
    [TextArea] public string description;
    public Sprite planetImage;

    private Camera mainCamera;
    private PlanetInfoUI uiManager;

    void Start()
    {
        mainCamera = Camera.main;
        uiManager = FindObjectOfType<PlanetInfoUI>();
    }

    void Update()
    {
        // ----------------------
        // 移动端触摸检测
        // ----------------------
        if (Touchscreen.current != null)
        {
            if (Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
            {
                Vector2 touchPosition = Touchscreen.current.primaryTouch.position.ReadValue();
                TryClickAt(touchPosition);
            }
        }

        // ----------------------
        // Editor 鼠标检测
        // ----------------------
#if UNITY_EDITOR
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector2 mousePosition = Mouse.current.position.ReadValue();
            TryClickAt(mousePosition);
        }
#endif
    }

    private void TryClickAt(Vector2 screenPosition)
    {
        if (mainCamera == null || uiManager == null) return;

        Ray ray = mainCamera.ScreenPointToRay(screenPosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform == transform)
            {
                uiManager.ShowInfo(planetName, description, planetImage);
            }
        }
    }
}
