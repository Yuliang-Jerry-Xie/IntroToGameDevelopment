using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets: MonoBehaviour
{
    public GameObject redObj;
    [SerializeField] private GameObject blueObj;
 
 
    // Start is called before the first frame update
   
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            Instantiate(redObj, new Vector3(2, 0, 0), Quaternion.identity);
        }
      
        
        for (var i = 0; i < 10; i++)
           {
             Instantiate(blueObj, new Vector3(-2, 0, 0), Quaternion.identity);
           }

        Application.targetFrameRate = 60;

    }
    
      

    

    // Update is called once per frame
    void Update()
    {
        

        
    }
}
