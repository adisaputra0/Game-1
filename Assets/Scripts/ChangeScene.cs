using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(int idScene)
    {
        SceneManager.LoadSceneAsync(idScene);
    }
}
