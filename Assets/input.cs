using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScript : MonoBehaviour
{
    public GameObject MarkerPrefab;
    void Update()
    {
        int idx = 0;
        foreach (var touch in Input.touches)
        {
            ++idx;
            Debug.Log($"[{idx}] phase {touch.phase} -- position {touch.position} -- phase {touch.deltaPosition} -- raw pos {touch.rawPosition}");
            SpawnMarker(touch.position);
        }

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log($"Ckick -- pos {Input.mousePosition}");
            SpawnMarker(Input.mousePosition);
        }
    }

    private void SpawnMarker(Vector2 touchPosition)
    {
        var depth = -Camera.main.transform.position.z;
        var worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, depth));
        Debug.Log($"Spawn pos {worldPosition}");
        var m = Instantiate(MarkerPrefab, worldPosition, Quaternion.identity);
        Destroy(m, 0.1f);
    }
}
