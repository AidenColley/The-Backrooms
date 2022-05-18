using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sanity : MonoBehaviour
{
    public float MaxSanity = 100f;
    private float AlmondWaterIncreaseSanity;
    [SerializeField] public float CurrentSanity = 100f;
    [SerializeField] private float NormalSanityDrain = 0.5f;
    [SerializeField] private Canvas PlayerCanvas = null;
    [SerializeField] private Image SanityBar = null;
    [SerializeField] private Text text = null;
    
    public Transform camera;
    [SerializeField] private float interactDist = 2f;
    
    
    void Start()
    {
      
    }

    
    void Update()
    {
        
        
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
        RaycastHit hit;
        if(Physics.Raycast(camera.position, camera.forward, out hit, interactDist)){
            if (hit.collider.gameObject.tag == "Almond Water") 
            {
                
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
