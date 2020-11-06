using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreationScript : MonoBehaviour {

    // Dancer Info
    public Canvas classInfo;

    // Dancer Buttons
    public Button DancerR1;
    public Button DancerR2;
    public Button DancerR3;
    public Button DancerR4;
    public Button DancerR5;

    public Button DancerB1;
    public Button DancerB2;
    public Button DancerB3;
    public Button DancerB4;
    public Button DancerB5;
   



    // Buttons
    public Button GetCharacterStats;
    public Button goBack;

    // Use this for initialization
    void Start ()
    {
        classInfo = classInfo.GetComponent<Canvas>();
        classInfo.enabled = false;

        // Dancers
        DancerR1 = DancerR1.GetComponent<Button>();
        DancerR2 = DancerR2.GetComponent<Button>();
        DancerR3 = DancerR3.GetComponent<Button>();
        DancerR4 = DancerR4.GetComponent<Button>();
        DancerR5 = DancerR5.GetComponent<Button>();
        
        DancerB1 = DancerB1.GetComponent<Button>();
        DancerB2 = DancerB2.GetComponent<Button>();
        DancerB3 = DancerB3.GetComponent<Button>();
        DancerB4 = DancerB4.GetComponent<Button>();
        DancerB5 = DancerB5.GetComponent<Button>();
        
        // Buttons
        createCharacter = createCharacter.GetComponent<Button>();
        goBack = goBack.GetComponent<Button>();
    }
    // Dancers
    public void Dancer()
