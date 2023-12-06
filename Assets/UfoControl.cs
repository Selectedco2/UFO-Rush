using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;
public class UfoControl : MonoBehaviour
{

  [SerializeField]
  float jumpForce = 100;
  bool mayJump = true;
  public static bool canControl = true;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    if (canControl == true)
    {


      if (Input.GetAxisRaw("Jump") > 0 && mayJump == true)
      {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector2 jump = Vector2.up * jumpForce;

        rb.AddForce(jump);
        mayJump = false;
      }

      if (Input.GetAxisRaw("Jump") == 0)
      {
        mayJump = true;
      }
    }
      if (canControl == false)
    {
      // switch gamescreen to start
    }
  }
  void OnTriggerEnter2D(Collider2D collision)
  {

    if (collision.gameObject.CompareTag("House") || (collision.gameObject.CompareTag("Ground")))
    {
      Debug.Log("Collision");
      canControl = false;
    }
  }

}
