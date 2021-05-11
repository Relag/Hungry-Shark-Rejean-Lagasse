using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShark : MonoBehaviour {

    //Values for the shark
    [SerializeField] private float speed = 3.0f;
    public int level {get; set;}
    public int health { get; set; }
    private int experience;

    private void Awake() {


    }

    // Update is called once per frame
    void Update()
    {
        
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
