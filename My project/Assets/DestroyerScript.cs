using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DestroyerScript : MonoBehaviour
{   Rigidbody rb;
    int enemieskilled=0;
    [SerializeField] Text enemies;
    [SerializeField]GameObject Playa;
    [SerializeField]float maxjumpspeed;
    void Start(){
        rb=GetComponent<Rigidbody>();
    }
    void jump(){
        rb.velocity=new Vector3(rb.velocity.x,maxjumpspeed,rb.velocity.z);
    }
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy Head")){
            Destroy(collision.transform.gameObject);
            Destroy(collision.transform.parent.gameObject);
            jump();
            enemieskilled++;
            enemies.text="Enemies:"+enemieskilled;
        }
    }
}

