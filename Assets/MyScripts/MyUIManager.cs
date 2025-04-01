using UnityEngine;
using UnityEngine.SceneManagement;

public class MyUIManager : MonoBehaviour
{
//public GameObjectUI pauseUI;
public void OnRestartPress()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}

}
