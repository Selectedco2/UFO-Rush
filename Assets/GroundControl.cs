using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundControl : MonoBehaviour
{
    [SerializeField]
   float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        if (UfoControl.canControl == true)
        {
        Vector2 movement = new Vector2(-1, 0);
        transform.Translate(movement*speed * Time.deltaTime);
        if (transform.position.x < -18.028)
        {
            Vector2 pos = new Vector2(17.99f, -3.99f);
            transform.position = pos;
        }
        }
    }
}
