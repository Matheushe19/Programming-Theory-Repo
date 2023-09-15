using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

//inheritance
public class Hero : MonoBehaviour
{
    //polymorphism
    public string Hero_Name 
    { get { return Hero_Name; }
        private set {Hero_Name = value; }
          
    }

    //Abstraction
    public virtual void Skill()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            
        }

            
    }
}
