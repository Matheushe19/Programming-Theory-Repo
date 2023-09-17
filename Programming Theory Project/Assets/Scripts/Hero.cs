using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

//inheritance
public class Hero : MonoBehaviour
{
     [SerializeField] private Canvas textCanvas;
     public float desactiveCanvasTime {get; private set;}
   
   
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
