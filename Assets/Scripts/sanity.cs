using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sanity : MonoBehaviour
{
    [SerializeField] private float MaxSanity = 100f;
    [SerializeField] private float CurrentSanity = 100f;
    [SerializeField] private float NormalSanityDrain = 0.5f;
    [SerializeField] private Canvas PlayerCanvas = null;
    [SerializeField] private Image SanityBar = null;

    
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
