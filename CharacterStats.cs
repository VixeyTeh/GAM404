using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Character name generator picks a first name and a last name from the list to make 15 unique dancer names

public class WhileLoop : MonoBehaviour
{
    int DancersOnTheStage = 15

    void Start ()
    {
        while (DancersOnTheStage > 0)
        {
            Debug.Log("A New Dancer Joins the Stage!");
            DancersOnTheStage --;

            public class DancerName : MonoBehaviour

            public string currentName = "Dancer";
            private void PickRandomFromList (FirstNameSyllables + LastNameSyllables)
    
            string[] FirstNameSyllables = new string [] {"Andy","Bertie","Cameron","Danny","Erik","Freddy","Gin","Henri","Iva","Jackie","Kerry","Lee","Maxie","Newton","Ollie"};
            string[] LastNameSyllables = new string[] {"Anders","Benson","Carlson","Dallas","Erskin","Ford","Gordon","Handers","Indego","Justin", "Kingston", "Langford","Millions","Nebula","Orson"};

            public TextField DancerNameText;
            string FirstName = "";
            string LastName = "";
            string RandomName = Dancers[Random.Range(0, dancers.legnth)];
            largeText.text = RandomName
        }
    }
}
            //Character Stats
            public class Dancer
{           string get.RandomName;
            int Health
            int Stamina
            int Dexterity
            int Stregnth
            int Acuity

            public void Dancer(string RandomName, int Stamina, int Dexterity, int Stregnth, int Acuity)
    {
            Name = RandomName;
    }
}          //Random modifiers for Character Stats           
 {

          int numberOfPointsToDistribute = 20;
          int numberOfAttributes = 4;
          int pointsLeft = numberOfPointsToDistribute;
          for(int i = 0; i < numberOfAttributes; i++)


         int randomPoints = Random.Range(0, pointsLeft);
         attributes[i] = randomPoints;
         pointsLeft -= randomPoints;

         Dexterity = Mathf.Clamp(0, 10, average + Random.Range(-average, average))
         Stamina = Mathf.Clamp(0, 10, average + Random.Range(-average, average))
         Stregnth = Mathf.Clamp(0, 10, average + Random.Range(-average, average))
         Acuity = Mathf.Clamp(0, 10, average + Random.Range(-average, average))

 }
            //Character Health
            public class CharacterStats : MonoBehaviour 
{
            public int maxHealth = 100;
            public int currentHealth { get; private set; }

            //Character damage modifiers
            public Stat damage;
            public Stat dodge;
            public stat critdmg;
 
   void Awake ()
{
    currentHealth = maxHealth;
}

//Character Dexterity
{

    [SerializeField] public Stat Dexterity;
    public float CalculateDodge()
    {

    [System.Serializable]
    public class Stat
    {
        public Stat(int sBase, int actual, int min, int max, int perLevel)
        {
            Base = sBase;
            Actual = actual;
            Min = min;
            Max = max;
            IncreasePerLevel = perLevel;
        }
        [SerializeField] public float Base;
        [SerializeField] public float Actual;
        [SerializeField] public float Min;
        [SerializeField] public float Max;
        [SerializeField] public float IncreasePerLevel;
    }
}
    int Rand;
    int Lenght = 6;
    List<int> list = new List<int>();
 
    void Start ()
    {
        list = new List<int>(new int[Lenght]);
 
        for (int d = 1; d < Lenght; d++)
        {
            Rand = Random.Range(1,6);
 
            while (list.Contains(Rand))
            {
                Rand = Random.Range(1,6);
            }
 
            list[d] = Rand;
            print(list[d]);
        }   
        return = dodge
    }
}
//Character Stamina
{

    [SerializeField] public Stat Stamina;
    public float CalculateStamina()
    {

    [System.Serializable]
    public class Stat
    {
        public Stat(int sBase, int actual, int min, int max, int perLevel)
        {
            Base = sBase;
            Actual = actual;
            Min = min;
            Max = max;
            IncreasePerLevel = perLevel;
        }
        [SerializeField] public float Base;
        [SerializeField] public float Actual;
        [SerializeField] public float Min;
        [SerializeField] public float Max;
        [SerializeField] public float IncreasePerLevel;
    }
}
    int Rand;
    int Lenght = 6;
    List<int> list = new List<int>();
 
    void Start ()
    {
        list = new List<int>(new int[Lenght]);
 
        for (int s = 1; s < Lenght; s++)
        {
            Rand = Random.Range(1,6);
 
            while (list.Contains(Rand))
            {
                Rand = Random.Range(1,6);
            }
 
            list[s] = Rand;
            print(list[s]);
        }   
        return = Stamina
    }
}

//Character Stregnth
{

    [SerializeField] public Stat Stregnth;
    public float CalculateStregnth()
    {

    [System.Serializable]
    public class Stat
    {
        public Stat(int sBase, int actual, int min, int max, int perLevel)
        {
            Base = sBase;
            Actual = actual;
            Min = min;
            Max = max;
            IncreasePerLevel = perLevel;
        }
        [SerializeField] public float Base;
        [SerializeField] public float Actual;
        [SerializeField] public float Min;
        [SerializeField] public float Max;
        [SerializeField] public float IncreasePerLevel;
    }
}
    int Rand;
    int Lenght = 6;
    List<int> list = new List<int>();
 
    void Start ()
    {
        list = new List<int>(new int[Lenght]);
        //using t for stregnth because s is for stamina
        //t is associated with toughness
        for (int t = 1; t < Lenght; t++)
        {
            Rand = Random.Range(1,6);
 
            while (list.Contains(Rand))
            {
                Rand = Random.Range(1,6);
            }
 
            list[t] = Rand;
            print(list[t]);
        }   
        return = Stregnth
    }
}
//Character Acuity
{

    [SerializeField] public Stat Acuity;
    public float CalculateAcuity()
    {

    [System.Serializable]
    public class Stat
    {
        public Stat(int sBase, int actual, int min, int max, int perLevel)
        {
            Base = sBase;
            Actual = actual;
            Min = min;
            Max = max;
            IncreasePerLevel = perLevel;
        }
        [SerializeField] public float Base;
        [SerializeField] public float Actual;
        [SerializeField] public float Min;
        [SerializeField] public float Max;
        [SerializeField] public float IncreasePerLevel;
    }
}
    int Rand;
    int Lenght = 6;
    List<int> list = new List<int>();
 
    void Start ()
    {
        list = new List<int>(new int[Lenght]);
 
        for (int a = 1; a < Lenght; a++)
        {
            Rand = Random.Range(1,6);
 
            while (list.Contains(Rand))
            {
                Rand = Random.Range(1,6);
            }
 
            list[a] = Rand;
            print(list[a]);
        }   
        return = Acuity
    }
}
//testing github 

  
