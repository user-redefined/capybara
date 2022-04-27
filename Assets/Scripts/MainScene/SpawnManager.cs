using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject player;

    void Start()
    {
        int count = MainManager.instance.entitiesCount;
        float posX = -17, posZ = 17;

        GameObject spawnedPlayer;

        for (int i = 0; i < count; i++)
        {
            spawnedPlayer = Instantiate(player, new Vector3(posX, 1, posZ), player.transform.rotation);
            if (i < (count / 2))
                spawnedPlayer.GetComponent<MeshRenderer>().material.color = Color.blue;
            else
                spawnedPlayer.GetComponent<MeshRenderer>().material.color = Color.red;

            if (posX != 17)
                posX += 3.4f;
            else
            {
                posX = -17;
                posZ -= 3.4f;
            }
        }
    }
}
