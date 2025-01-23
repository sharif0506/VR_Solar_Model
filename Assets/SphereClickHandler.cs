using UnityEngine;

public class SphereClickHandler : MonoBehaviour
{
    private SceneTransitionHandler sceneTransitionHandler;

    private void Start()
    {
        // Find the SceneTransitionHandler script
        sceneTransitionHandler = FindObjectOfType<SceneTransitionHandler>();
    }

    private void OnMouseDown()
    {
        // Call the LoadScene2 method

        Debug.Log("Hello World");

        if (sceneTransitionHandler != null)
        {
            sceneTransitionHandler.LoadScene2();
        }
    }
}
