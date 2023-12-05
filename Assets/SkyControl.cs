using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyControl : MonoBehaviour
{
    [SerializeField]
   float speed = 5f;

    [SerializeField] 
    UfoControl ufo;
    // Update is called once per frame
    void Update()
    {
        if  (UfoControl.canControl == true)
        {
        Vector2 movement = new Vector2(-1, 0);
        transform.Translate(movement*speed * Time.deltaTime);
        if (transform.position.x < -18.028)
        {
            Vector2 pos = new Vector2(17.99f, 0);
            transform.position = pos;
        }
    }
        }
        
}
