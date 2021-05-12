using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerShark : MonoBehaviour {

    //Values for the shark
    [SerializeField] private float speed = 2.0f;
    public int level {get; set;}
    public int health { get; set; }
    public int fishEaten { get; set; }
    

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

        other.gameObject.SetActive(false);
        UIManager.instance.UpdateUI();
    }


    void TakeDamage() {
        Debug.Log("took damage");
        health -= 1;
        if (health <= 0) {
            Gameover();
        }
    }

    void HealDamage() {
        health += 1;
    }

    void EatFish() {
        fishEaten++;
    }

    void Gameover() {
        enabled = false;
    }

    public void Restart() {
        health = 3;
        fishEaten = 0;
        enabled = true;
        transform.position = new Vector2(0, 0);
        UIManager.instance.UpdateUI();
    }
}
