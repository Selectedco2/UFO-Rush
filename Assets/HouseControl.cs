using UnityEngine;

public class HouseControl : MonoBehaviour

{
    public GameObject HousePrefab;
    
    [SerializeField]
    float TimeBetween = 2f;
    
    [SerializeField]
    float Speed = 5f;
   
    void Start()
    {
        InvokeRepeating("SpawnHouse", 0f, TimeBetween);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void SpawnPipe()
    {
        
        GameObject newHouse = Instantiate(HousePrefab, transform.position, Quaternion.identity);

        Rigidbody2D pipeRb = newHouse.GetComponent<Rigidbody2D>();
        pipeRb.velocity = new Vector2(-Speed, 0f);

    
        Destroy(newHouse, 10f);
    }
}
