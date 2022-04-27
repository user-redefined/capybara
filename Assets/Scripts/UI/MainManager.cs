using UnityEngine;

/// <summary>
/// Singleton class for data persistence between scenes.
/// </summary>
public class MainManager : MonoBehaviour
{
    public static MainManager instance;
    public int entitiesCount;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
