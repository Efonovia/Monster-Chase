using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    // private void onCollisionEnter2D(Collider2D collision) {
    //     // if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Player")) {
    //     //     Destroy(gameObject);
    //     // }

    //     if(collision.gameObject.CompareTag("Enemy")) {
    //         Destroy(collision.gameObject);
    //     }
    // }

    // private void onTriggerEnter2D(Collider2D collision) {
    //     if(collision.CompareTag("Enemy") || collision.CompareTag("Player")){
    //         Destroy(gameObject);
    //     }
    // }

    private void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Player")) {
            Destroy(collision.gameObject);
        }
    }

    // private void onTriggerEnter2D(Collider2D collision) {
    //     if(collision.CompareTag("Enemy")) Destroy(collision.gameObject);
    // }
}

