﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AbilityMenu : MonoBehaviour
{

    public Spell[] spells;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activateAbility(int abilityNum)
    {
        spells[abilityNum].Cast();
    }
}