using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : Hero
{

//Polymorphism 
 public override void Skill()
 {
    Debug.Log("Skill is overrided");
 }
}
