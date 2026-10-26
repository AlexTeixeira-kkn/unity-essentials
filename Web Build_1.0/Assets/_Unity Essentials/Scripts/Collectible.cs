using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    private BoxCollider bc;
    public GameObject onCollectEffect; //Creates the variable to define the CollectEffect after the collectible is collected by the player, playing out the given partible effect 

    public float rotationSpeed;//Global variable must be independent of any inicialization method

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bc = GetComponent <BoxCollider>(); //Obtains the Box Collider component 
        if (bc == null) Debug.LogWarning("Collectible neededs a BoxCollider");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotationSpeed,0); //Transforms the Y exis rotation into the rotationSpeed (can be edited via the inspect Unity's pannel)
    }

    private void OnTriggerEnter(Collider other) //Gets the Rigidbody(Collider) from other object entities that interact with it
    {
        if (other.CompareTag("Player")) //Using "if" with the CompareTag ("Tag" in Unity is similar to an ID, so the trigger is exclusive to when the player object interacts with the collectible)

        {
            //Destroy the collectible
            Destroy(gameObject); //Destroys himself when being interacted by said object (player gets the collectible)

            //Instantiate the particle effect, creating a new instance of the prefab in the scene, while the application is running
            //Instantiate(object to instantiate, *position, *rotation - *of said object)
            Instantiate(onCollectEffect, transform.position, transform.rotation);
        }
        
    }
}