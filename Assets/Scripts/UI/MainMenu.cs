using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    #region -Variables-
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private TMP_Text errorTextField;
    private bool isAllowedToStart = false; // needed to know if user inputs int, and so its allowed to change the scene
    #endregion

    #region -InputFieldControll-
    public void GetNumberOfEntities()
    {
        int entriesCount;
        if (!int.TryParse(inputField.GetComponent<TMP_InputField>().text, out entriesCount))
        {
            isAllowedToStart = false;
#if UNITY_EDITOR
            Debug.LogWarning($"Not an integer entered in {inputField.name}");
#endif
            errorTextField.text = "Only digits is allowed";
        }
        else
        {
            MainManager.instance.entitiesCount = entriesCount;
            isAllowedToStart = true;
            errorTextField.text = $"There are {entriesCount} entities in the next scene. Click Start Game!";
        }
    }
    #endregion

    #region -ButtonControl-
    public void GameStart()
    {
        if (isAllowedToStart)
            SceneManager.LoadScene(1);
        else
            errorTextField.text = "Enter number of entities first";
    }

    public void GameQuit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
    #endregion
}