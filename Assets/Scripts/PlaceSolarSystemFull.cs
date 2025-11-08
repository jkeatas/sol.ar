using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlaceSolarSystemFull : MonoBehaviour
{
    public GameObject solarSystemPrefab;      // Õœ»Îƒ„µƒ SolarSystem Prefab
    public ARRaycastManager raycastManager;   // Õœ»Î ARRaycastManager

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    private GameObject placedSystem;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (raycastManager.Raycast(touch.position, hits, TrackableType.PlaneWithinPolygon))
                {
                    Pose hitPose = hits[0].pose;
                    if (placedSystem == null)
                        placedSystem = Instantiate(solarSystemPrefab, hitPose.position, hitPose.rotation);
                }
            }
        }
    }
}
