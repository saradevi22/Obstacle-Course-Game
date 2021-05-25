
using UnityEngine;

public class Player_Collision : MonoBehaviour
{

    public Player_Movement movement; 
    

    void OnCollisionEnter (Collision collisionInfo) {

        Debug.Log(collisionInfo.collider.tag);

        if (collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false; 
            FindObjectOfType<Game_Manager>().EndGame(); 
            
        } 
        if (collisionInfo.collider.tag == "Capsule")
        {
            movement.enabled = false; 
            FindObjectOfType<Game_Manager>().EndGame(); 
        }
        if(collisionInfo.collider.tag == "Wall")
        {
            movement.enabled = false; 
            FindObjectOfType<Game_Manager>().EndGame(); 
        }
    }
}
