using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossCollider : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D trigger) {
        SceneManager.LoadScene(0);
    }

    void OnCollisionEnter2D (Collision2D collision) {
        print ("Collision");
    }
}
