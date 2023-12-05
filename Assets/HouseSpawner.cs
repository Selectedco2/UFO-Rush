using UnityEngine;

public class HouseSpawner : MonoBehaviour
{
    public GameObject housePrefab;
    public float spawnInterval = 2f;
    public float houseSpeed = 5f;



    void Start()
    {
        InvokeRepeating("SpawnHouse", 5f, spawnInterval);
    }


    private void SpawnHouse()
    {
        if (UfoControl.canControl == true)
        {
            GameObject newHouse = Instantiate(housePrefab, transform.position, Quaternion.identity);

            newHouse.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            Rigidbody2D houseRb = newHouse.GetComponent<Rigidbody2D>();

            houseRb.velocity = new Vector2(-houseSpeed, 0f);

            Destroy(newHouse, 5f);
        }

        if (UfoControl.canControl == false)
        {
            houseSpeed = 0f;
        }

    }
}
