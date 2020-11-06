using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 public class BattleManager : MonoBehaviour {
 
     private bool turn = true;
 
     public BattleMove Player1;
 
     public BattleMove Player2;
 
 
     // Use this for initialization
     void Start () {
         Player1.ActionComplete = true;
     }

     void Start () {
         Player2.ActionComplete = true;
     }
     // Update is called once per frame
     void Update () {
 
         if (Player1.ActionComplete == true) {
             if (turn == true) {
                 turn =! turn;
 
                     Player2.ActionComplete = false;
                     Debug.Log ("Blue Team DANCE!");
                 }
             }
         if (Player2.ActionComplete == true) {
             if (turn == false) {
                 turn =! turn;
             
                 Player1.ActionComplete = false;
                 Debug.Log ("Red Team DANCE!");
             }
         }
 
         ///Character damage taken
    public void TakeDamage (int damage)
{

    damage -= dodge.getValue();
    damage += critdmg.getValue(*2);
    damage = Mathf.Clamp(damage, 0, int.maxValue);

    currentHealth -= damage;
    Debug.Log(transform.name + "takes" + damage + "damage.");

    //Character is dazed if HP drops to 0 or less
    if (currentHealth <= 0)
    {
        Dazed ();

         void Update() 
         
         //Player health bar
         {
 if (playerHealth.fillAmount == 0) { 
     pHealth.SendMessage ("OnClick");
     YouAreDazed.SetTrigger ("You Are Dazed");
         }
     }

}
public float BaseValue 
    //Update occurs once per frame
}
    void Update()
    {
        
    }
} 
     }
 }