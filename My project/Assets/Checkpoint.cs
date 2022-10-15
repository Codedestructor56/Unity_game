using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
   void OnTriggerEnter(Collider other){
    if(other.gameObject.name=="Player"){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
   }
}
