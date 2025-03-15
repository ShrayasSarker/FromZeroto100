using UnityEngine;

public class Playermovement : MonoBehaviour

{
    public Rigidbody Rb;
    public float forwordforce = 2000f;
    public float sidewayForce =500f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rb.AddForce(0,0,forwordforce*Time.deltaTime);
        if(Input.GetKey("d")){
            Rb.AddForce(sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        Rb.AddForce(0,0,forwordforce*Time.deltaTime);
        if(Input.GetKey("a")){
            Rb.AddForce(-sidewayForce*Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        if(Rb.position.y <2.28f){
            FindAnyObjectByType<GameManager>().EndGame();
        }
        
    }
}
