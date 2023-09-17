using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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
    
        Debug.Log("Cliked Worked");
    }
    public void OnMouseDown()
    {
        Skill();
    }
        
}
