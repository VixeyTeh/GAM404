using System.Collections;
using System.Collections.Generic;
using UnityEngine;


{
    // Start is called before the first frame update
    void Start()
    {
        
    //Generate list 15 characters to be the dancers on the stage
    List<Dancers> DancersOnStage = new List<Dancers>();

    //Select the characters from List

     public static List<T> GetRandomDancersOnStage<T> (List<T> list, int number)
 {
     // this is the list we're going to remove picked items from
     List<T> tmpList = new List<T>(list);
     // this is the list we're going to move items to
     List<T> newList = new List<T>();
 
     // make sure tmpList isn't already empty
     while (newList.Count < number && tmpList.Count > 0)
     {
         int index = Random.Range(0, tmpList.Count);
         newList.Add(tmpList[index]);
         tmpList.RemoveAt(index);
     }
 
     return newList;

      List<Item> randomItems = GetRandomItemsFromList<Item> (allItems, 5);
 }


//Spawn 5 randomly selected dancers from the DancersOnStage list
public class Team1Container : MonoBehaviour
 {
     private List<GameObject> DancersOnStage;
     private int selectionIndex = 0;
     public Transform DancerR1SpawnPoint;
     public Transform DancerR2SpawnPoint;
     public Transform DancerR3SpawnPoint;
     public Transform DancerR4SpawnPoint;
     public Transform DancerR5SpawnPoint;
     public bool platformActive;
 
     private void Start()
     {
         characters = new List<GameObject>();
         foreach(Transform t in transform)
         {
             characters.Add(t.gameObject);
             t.gameObject.SetActive(false);
         }
 
         characters[selectionIndex].SetActive(true);
 
     }
 
     public void Select(int index)
     {
         if(index == selectionIndex)
             return;
 
         if(index < 0 || index >= characters.Count)
             return;
 
         characters[selectionIndex].SetActive(false);
         selectionIndex = index;
         characters[selectionIndex].SetActive(true);
     }
      //////Transform the position on selected platform
      if (platformActive)
 {
 characters[selectionIndex].transform.Translate(DancerR1SpawnPoint.position, DancerR1SpawnPoint.rotation;)
 }
 }

  class Team1Container : MonoBehaviour
 {
     private List<GameObject> DancersOnStage;
     private int selectionIndex = 0;
     public Transform DancerB1SpawnPoint;
     public Transform DancerB2SpawnPoint;
     public Transform DancerB3SpawnPoint;
     public Transform DancerB4SpawnPoint;
     public Transform DancerB5SpawnPoint;
     public bool platformActive;
 
     private void Start()
     {
         characters = new List<GameObject>();
         foreach(Transform t in transform)
         {
             characters.Add(t.gameObject);
             t.gameObject.SetActive(false);
         }
 
         characters[selectionIndex].SetActive(true);
 
     }
 
     public void Select(int index)
     {
         if(index == selectionIndex)
             return;
 
         if(index < 0 || index >= characters.Count)
             return;
 
         characters[selectionIndex].SetActive(false);
         selectionIndex = index;
         characters[selectionIndex].SetActive(true);
     }
      //////Transform the position on selected platform
      if (platformActive)
 {
 characters[selectionIndex].transform.Translate(DancerB1SpawnPoint.position, DancerB1SpawnPoint.rotation;)
 }
 }


//List the 15 characters to choose from

{
    public void

}

//Dancer Spawns
public class SpawnDancer : MonoBehaviour
{

    public Transform Spawnpoint;
    public GameObject Prefab;

    void OnTriggerClick
    
    {

     private void PickRandomName ()

    }
   
}

//Limit of 5 characters selected


{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
