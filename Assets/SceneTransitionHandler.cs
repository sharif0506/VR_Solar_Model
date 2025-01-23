using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitionHandler : MonoBehaviour
{
    public void LoadScene2()
    {
        // Load Scene 2
        SceneManager.LoadScene(1);
    }
}
