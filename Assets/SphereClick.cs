using UnityEngine;
using UnityEngine.Events;

public class SphereClick : MonoBehaviour
{
    public UnityEvent onClick;


    void Start()
    {
        // Log a simple message
        Debug.Log("Hello, Unity!");

        // Log the value of a variable
        int score = 100;
        Debug.Log("Score: " + score);

    }

    private void OnMouseDown()
    {

        Debug.Log("Test click outside if");
        // Check if the VR interaction button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Trigger onClick event
            onClick.Invoke();
            Debug.Log("Test click");
        }
    }
}
