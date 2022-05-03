using UnityEngine;

/// <summary>
/// Entity spawn control class.
/// </summary>
public class SpawnManager : MonoBehaviour
{
    #region -Variables-
    [SerializeField] private GameObject playerPrefab;
    #endregion

    #region -Public Methods-
    /// <summary>
    /// Spawn user-defined number of entities in 2 teams.
    /// </summary>
    public void SpawnEntities()
    {
        int count = MainManager.instance.entitiesCount;
        float posX = -17, posZ = 17;

        GameObject spawnedEntity;
        Entity entity;

        Color color;

        for (int entityID = 0; entityID < count; entityID++)
        {
            spawnedEntity = Instantiate(playerPrefab, new Vector3(posX, 1, posZ), playerPrefab.transform.rotation);
            entity = spawnedEntity.GetComponent<Entity>();

            color = (entityID < (count / 2)) ? Color.blue : Color.red;
            spawnedEntity.GetComponent<MeshRenderer>().material.color = color;

            entity.OnCreate(entityID + 1, color);

            if (posX != 17)
                posX += 3.4f;
            else
            {
                posX = -17;
                posZ -= 3.4f;
            }
        }
    }
    #endregion

    void Start() => SpawnEntities();
}