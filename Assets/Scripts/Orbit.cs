using UnityEngine;

public class Orbit : MonoBehaviour
{
    public Transform center;       // 公转中心
    public float orbitSpeed = 10f; // 度/秒

    void Update()
    {
        if (center != null)
        {
            transform.RotateAround(center.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }

    public float orbitRadius = 10f; // 轨道半径

    void Start()
    {
        if (center != null)
            transform.position = center.position + Vector3.right * orbitRadius;
    }
}