using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rewards : MonoBehaviour
{   int coins=0;
    [SerializeField]Text comp;
   void OnTriggerEnter(Collider other)
   {if(other.gameObject.CompareTag("Reward")){
    Destroy(other.gameObject);
    coins++;
    comp.text="Coins"+coins;
   }}}

