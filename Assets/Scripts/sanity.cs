using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class sanity : MonoBehaviour
{
    public float MaxSanity = 100f;
    private float AlmondWaterIncreaseSanity;
    [SerializeField] private float CurrentSanity = 100f;
    [SerializeField] private float NormalSanityDrain = 0.5f;
    [SerializeField] private Canvas PlayerCanvas = null;
    [SerializeField] private Image SanityBar = null;
    [SerializeField] private Text text = null;
    [SerializeField] private Text interactText = null;
    [SerializeField] private Volume volume;
    
    
    public Transform camera;
    [SerializeField] private float interactDist = 4f;
    
    
    void Start()
    {
      
    }

    
    void Update()
    {
        if (volume != null)
        {
            
        }

        Interact();
        if (CurrentSanity > 0)
        {
            UpdateStamina(CurrentSanity);
            CurrentSanity -= NormalSanityDrain * Time.deltaTime;
           
           
        }
    }

    void UpdateStamina(float value)
    {
        value = Mathf.Round(value);
        text.text = value.ToString() + '%';
        //SanityBar.fillAmount = value / MaxSanity;
    }


    void Interact()
    {
        interactText.text = "";
        RaycastHit hit;
        if(Physics.Raycast(camera.position, camera.forward, out hit, interactDist)){
            
            if (hit.collider.gameObject.tag == "Almond Water") 
            {
                interactText.text = "Press E to interact";
                if (Input.GetKeyDown(KeyCode.E))
                {
                    AlmondWaterPickup();
                    Destroy(hit.transform.gameObject);
                }

            } 
          
        }
    }

    void AlmondWaterPickup()
    {
        AlmondWaterIncreaseSanity =  Mathf.Clamp(MaxSanity - CurrentSanity,0,50);
        CurrentSanity += AlmondWaterIncreaseSanity;
        
    }
}
