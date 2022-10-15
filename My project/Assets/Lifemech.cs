using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lifemech : MonoBehaviour
{  
    private void Update(){
        if(transform.position.y<-2f){
            die();
    }}
    private void OnCollisionEnter(Collision collision){
        if(collision.gameObject.CompareTag("Enemy")){
            die();
        }
    }
    void die(){
        GetComponent<MeshRenderer>().enabled=false;
        GetComponent<Rigidbody>().isKinematic=true;
        GetComponent<PlayerMovement>().enabled=false;
        Invoke(nameof(SceneReload),1.5f);
    }
    void SceneReload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
