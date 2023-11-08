using System.Collections;
using System.Collections.Generic;
using Unity.Android.Gradle.Manifest;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Receiver mdmn;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Receive.sendMesages)
        {
            if(Random.value > 0.5f){
                Receive.messageReceived = true;
            }
            else {
                Receive.messageReceived = false;
            }
        }

    }
}
