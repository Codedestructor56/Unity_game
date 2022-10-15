using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;
    Collider newf;
    [SerializeField]float maxmovespeed;
    [SerializeField]float maxjumpspeed;
    [SerializeField]Transform groundcheck;
    [SerializeField]LayerMask layer;
    bool var;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        newf=GetComponent<Collider>();
        PhysicMaterial material=new PhysicMaterial();
        material.dynamicFriction=0;
        material.staticFriction=0;
        newf.material=material;
    }

    // Update is called once per frame
    void Update()
    {{
    float horizontalinp=Input.GetAxis("Horizontal");
    float verticalinp=Input.GetAxis("Vertical");
    rb.velocity=new Vector3(verticalinp*maxmovespeed,rb.velocity.y,-1*horizontalinp*maxmovespeed);}
    if(Input.GetButtonDown("Jump") && checker()){
        jump();
    }
    void jump(){
        rb.velocity=new Vector3(rb.velocity.x,maxjumpspeed,rb.velocity.z);
    }
    bool checker(){
        return Physics.CheckSphere(groundcheck.position, .1f, layer);
        
    }
    
    }
     void SceneReload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }}
