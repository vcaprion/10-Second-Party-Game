using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed = 4;

    public GameObject loseText;

    void Start () 
    {
        loseText.SetActive(false);

    }

    void Update()
    {
        float inputX = Input.GetAxisRaw ("Horizontal");
        float velocity = inputX * speed;
        transform.Translate (Vector2.right * velocity * Time.deltaTime);

        if (Input.GetKeyDown("escape"))
        {
            Application.Quit();
        }

    }
    void OnTriggerEnter2D(Collider2D triggerCollider)
    {
        if (triggerCollider.tag == "Bomb")
        {
            loseText.SetActive(true);
            Destroy (gameObject);
        }

    }
}
