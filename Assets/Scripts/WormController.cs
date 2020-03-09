using System.Security.Cryptography;
using System.Runtime.ConstrainedExecution;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormController : MonoBehaviour
{
  public float thrust = 1.0f;
  public float negativeThrust = 1.0f;
  public Rigidbody rb;
  public Rigidbody b;
  public Transform prefab;
  public Transform spawnPosition;
  public Rigidbody clone;

  private void Update() {
      if (Input.GetKeyDown(KeyCode.W)) {
          rb.AddForce(0, thrust, 0, ForceMode.Impulse);
      }

     if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Wird aufgerufen");
            rb.AddForce(thrust, 0, 0, ForceMode.Impulse);
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Wird aufgerufen");
            rb.AddForce(negativeThrust, 0, 0, ForceMode.Impulse);
        }
         if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Wird aufgerufen");
            rb.AddForce(0, negativeThrust, 0, ForceMode.Impulse);
        }
          if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Wird aufgerufen");
            clone = Instantiate(b, spawnPosition.position, transform.rotation);
            clone.velocity = transform.TransformDirection(Vector3.left * -7);
        }
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public int health = 10;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
           health = health -4;
           Debug.Log ("Kollision mit Bullet findet statt"); 
        }
        

        else {
            Debug.Log ("Kollision mit etwas anderem findet statt");
        }

        if (collision.gameObject.tag == "Health")
        {
           health = health +2;
           Debug.Log ("Kollision mit HealthBox findet statt"); 
        }
        

        else {
            Debug.Log ("Kollision mit etwas anderem findet statt");
        }
    }

}
