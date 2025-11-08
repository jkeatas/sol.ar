using TMPro;
using UnityEngine;

public class DisableRaycastTarget : MonoBehaviour
{
    void Start()
    {
        TMP_Text tmp = GetComponent<TMP_Text>();
        if (tmp != null) tmp.raycastTarget = false;
    }
}
