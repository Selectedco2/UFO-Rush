using UnityEngine;

public class PipeControl : MonoBehaviour

{
    public GameObject pipePrefab;
    
    [SerializeField]
    float TimeBetween = 2f;
    
    [SerializeField]
    float Speed = 5f;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void SpawnPipe()
    {
        
        GameObject newPipe = Instantiate(pipePrefab, transform.position, Quaternion.identity);

        Rigidbody2D pipeRb = newPipe.GetComponent<Rigidbody2D>();
        pipeRb.velocity = new Vector2(-Speed, 0f);

    
        Destroy(newPipe, 10f);
    }
}
