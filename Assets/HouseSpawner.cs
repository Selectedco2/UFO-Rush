using UnityEngine;

public class HouseSpawner : MonoBehaviour
{
    public GameObject housePrefab;
    public float spawnInterval = 2f;
    static public float houseSpeed = 5f;



    void Start()
    {
        InvokeRepeating("SpawnHouse", 5f, spawnInterval);
    }


    private void SpawnHouse()
    {

        if (UfoControl.canControl == true)
        {
            Vector3 pos = new(transform.position.x, 3 + Random.Range(-Camera.main.orthographicSize, Camera.main.orthographicSize));
            GameObject newHouse1 = Instantiate(housePrefab, pos, Quaternion.identity);
            pos.y += 6;
            GameObject newHouse2 = Instantiate(housePrefab, pos, Quaternion.identity);

            newHouse1.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            newHouse2.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            Rigidbody2D houseRb1 = newHouse1.GetComponent<Rigidbody2D>();
            Rigidbody2D houseRb2 = newHouse1.GetComponent<Rigidbody2D>();

            houseRb1.velocity = new Vector2(-houseSpeed, 0f);
            houseRb2.velocity = new Vector2(-houseSpeed, 0f);

            Destroy(newHouse1, 5f);
            Destroy(newHouse2, 5f);
        }

        if (UfoControl.canControl == false)
        {
            houseSpeed = 0f;
        }

    }
}
