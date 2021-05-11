using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShark : MonoBehaviour {

    //Values for the shark
    [SerializeField] private float speed = 3.0f;
    public int level {get; set;}
    public int health { get; set; }
    private int fishEaten;

    private Vector2 movePosition;

    private void Awake() {
        health = 3;

    }

    // Update is called once per frame
    void Update()
    {
        //If mouse is clicked set move position to new location
        if (Input.GetMouseButtonDown(0)) {
            movePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Debug.Log(movePosition);
        }
        //Move the shark
        transform.position = Vector2.MoveTowards(transform.position, movePosition, speed * Time.deltaTime);
    }

    /* private void OnTriggerEnter(Collider collision) {
         if (collision.collider.tag == "PoisonFish") {
             health -= 1;
             if (health <= 0) {
                 Gameover();
             }
         }
         else if (collision.collider.tag == "Fish") {
             EatFish();
         }
         else if (collision.collider.tag == "health") {
             HealDamage();
         }
         Debug.Log("Collide");
     }*/

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Fish")) {
            EatFish();
        }
        else if (other.CompareTag("PoisonFish")) {
            TakeDamage();
        }
        else if (other.CompareTag("Health")) {
            HealDamage();
        }
    }


    void TakeDamage() {
        Debug.Log("took damage");
        health -= 1;
        if (health <= 0) {
            Gameover();
        }
    }

    void HealDamage() {
        Debug.Log("healed damage");
    }

    void EatFish() {
        Debug.Log("ate fish");
    }

    void Gameover() {
        Debug.Log("Gameover");
    }
}
