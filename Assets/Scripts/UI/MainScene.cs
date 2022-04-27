using UnityEngine;
using UnityEngine.SceneManagement;

public class MainScene : MonoBehaviour
{
    #region -ButtonControll-
    public void ExitMenu() => SceneManager.LoadScene(0);
    #endregion
}
