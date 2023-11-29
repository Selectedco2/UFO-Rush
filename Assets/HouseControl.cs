using UnityEngine;

public class HouseControl : MonoBehaviour

{
    public GameObject HousePrefab;
    
    [SerializeField]
    public float TimeBetween = 2f;
    
    [SerializeField]
    public float Speed = 5f;
   
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void SpawnHouse()
    {
        
        GameObject newHouse = Instantiate(HousePrefab, transform.position, Quaternion.identity);

        Rigidbody2D houseRb = newHouse.GetComponent<Rigidbody2D>();
        houseRb.velocity = new Vector2(-Speed, 0f);

    
        Destroy(newHouse, 10f);
    }
}
