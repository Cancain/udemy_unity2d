using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    void Start()
    {
        string message = "I'm a string!";
        textComponent.text = message;
    }

    void Update()
    {
        
    }
}
