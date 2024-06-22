using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{

    //NPC Health
    int health = 5;

    //NPC Level
    int level = 1;

    //NPC Speed
    float speed = 1.3f;

    // Start is called before the first frame update
    void Start()
    {
        // Add level to health
        health += level;

        // Print the health into the console
        print("Health:" + health);
    }

    // Update is called once per frame
    void Update()
    {
        // Define newPosition as the current position
        Vector3 newPosition = transform.position;

        // Change newPosition
        newPosition.z += speed * Time.deltaTime;

        // Set the current position to newPosition
        transform.position = newPosition;
    }
}
