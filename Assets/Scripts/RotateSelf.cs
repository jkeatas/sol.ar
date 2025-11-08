using UnityEngine;

public class RotateSelf : MonoBehaviour
{
    public float rotationSpeed = 10f; // ∂»/√Î

    void Update()
    {
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
