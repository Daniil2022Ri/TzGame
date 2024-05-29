
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void StartignGame()
    {
        SceneManager.LoadScene(1);
    }

    public void NextSceneForOne()
    {
        SceneManager.LoadScene(2);
    }

    public void ReturnMineMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}
