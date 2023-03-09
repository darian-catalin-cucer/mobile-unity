using UnityEngine;

public class TapDetector : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Player tapped the screen!");
        }
    }
}
