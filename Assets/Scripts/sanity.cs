using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    [SerializeField] public float MaxSanity = 100f;
    [SerializeField] public float CurrentSanity = 100f;
    [SerializeField] public float NormalSanityDrain = 0.5f;
    [SerializeField] public Canvas PlayerCanvas = null;
    [SerializeField] public Image SanityBar = null;

    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(CurrentSanity > 0)
        {
            UpdateStamina(CurrentSanity);
            CurrentSanity -= NormalSanityDrain * Time.deltaTime;
           
        }
    }

    void UpdateStamina(float value)
    {
        SanityBar.fillAmount = CurrentSanity / MaxSanity;
    }
}
