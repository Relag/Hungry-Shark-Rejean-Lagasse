using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShark : MonoBehaviour {

    //Values for the shark
    [SerializeField] private float speed = 3.0f;
    public int level {get; set;}
    public int health { get; set; }
    private int experience;

    private Vector2 movePosition;

    private void Awake() {


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

    private void OnCollisionEnter(Collision collision) {
        
    }

    void TakeDamage() {

    }

    void HealDamage() {

    }

    void LevelUp() {

    }
}
