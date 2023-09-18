using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Priest : Hero //Inheritance
{
  public string thisName;
    private string heroName //Encapsulation
    {
        get {return thisName;} 
        set{
            if(heroName == null)
            {
                heroSkillText.text = "This Hero not have a name";
            }
            else
            {
                return;
            }
        }
           
    }

    public override void Skill()//Polymorphism 
    {
        heroSkillText.text = $"The Priest {heroName}, Healed the whole group";
    }
}
