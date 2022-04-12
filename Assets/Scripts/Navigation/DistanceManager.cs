using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceManager : MonoBehaviour 
{

    public GameObject player;
    public GameObject enemy;
    public float Distance_;

    private Sanity sanity;
    


    void Start()
    {
        sanity = player.GetComponent<Sanity>();
        sanity.CurrentSanity -= 100; 

        if(sanity.CurrentSanity >= Distance_)
        {
            
        } 
    }

    
    void Update()
    {
        Distance_ = Vector3.Distance(player.transform.position, enemy.transform.position);
        
    
    }
}
