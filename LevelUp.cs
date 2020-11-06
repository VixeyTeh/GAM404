using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Apply Winner attribute to team members still awake

public class Winner : MonoBehaviour
{    
    Update WinnerExperience
    Update WinnerCharaterStatsIncrease
    Update WinnerLevelUp
}

public class Experience : MonoBehaviour 
{
 
    //current level
    public int vLevel = 1;
    //current exp amount
    public int vCurrExp = 0;
    //exp amount needed for lvl 1
    public int vExpBase = 3;
    //exp amount left to next levelup
    public int vExpLeft = 3;
    //modifier that increases needed exp each level
    public float vExpMod = 1.5f;
 
    public void GainExp(int e)
    {
        vCurrExp += e;
        if(vCurrExp >= vExpLeft)
        {
            LvlUp();
        }
    }
    void LvlUp()
    {
        vCurrExp -= vExpLeft;
        vLevel++;
        float t = Mathf.Pow(vExpMod, vLevel);
        vExpLeft = (int)Mathf.Floor(vExpBase * t);
    }
}

 public class CharacterStatsIncrease : MonoBehaviour
 {

  //Apply level up
  var currentXP = 0;
var nextLevelUp = 100;


gainExperience(int amount)
{
    currentXP += amount;
    if (currentXP >= nextLevelUp)
    {
        levelUp();
    }
}


levelUp()
{
    var nextLevelUp += 10;
    var maxHealth += 10;
    var maxDexterity += 5;
    var maxStamina += 5;
    var maxStrength += 5;
    var maxAcuity += 5;

 }