using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

//inheritance
public class Hero : MonoBehaviour
{
     [SerializeField] private Canvas textCanvas;
     
     protected Text heroSkillText {get; set;}

     public float timeToDesactive = 8.0f;
     private float desactiveCanvasTime //Encapsulation
     {
        get {return timeToDesactive;}
        set 
        {
            if (desactiveCanvasTime < 0.01f)
            {
                Debug.LogError("not long enough to show the message");
            }
            else 
            {
               return;
            }
        }
     }

    void Start()
    {
        heroSkillText = textCanvas.GetComponentInChildren<Text>();
        
    }
    public void OnMouseDown()//ABSTRACTION
    {
        textCanvas.gameObject.SetActive(true);
        Skill();
        StartCoroutine(DesactiveCanvas());
    }

    public virtual void Skill()
    {
        Debug.Log("Cliked Worked");
    } 

    IEnumerator DesactiveCanvas()
    {
        yield return new WaitForSeconds(desactiveCanvasTime);
        textCanvas.gameObject.SetActive(false);
        
    }
}
