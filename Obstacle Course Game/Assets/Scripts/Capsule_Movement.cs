using UnityEngine;

public class Capsule_Movement : MonoBehaviour
{
   public Rigidbody rb; 
    
   public float SideForce = 2f; 
   bool movecondition = false; 
   public float limit1 = 6.1f; 
   public float limit2 = -5.8f; 
    

    void Start()
    {
        Debug.Log("I'm a capsule!!"); 
        
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.x > limit1)
        {
            movecondition = false; 
        }
        
        if(transform.position.x < limit2)
        {
            movecondition = true; 
        }

        if(movecondition == true)
        {
            rb.AddForce(SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(movecondition == false)
        {
            rb.AddForce(- SideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
            
                
    }
}
