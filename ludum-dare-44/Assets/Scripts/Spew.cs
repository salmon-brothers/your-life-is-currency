using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Water2D;

public class Spew : MonoBehaviour
{
    public KeyCode SpaceKey = KeyCode.Space;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(SpaceKey))
        {
            transform.localScale -= new Vector3(0.01F, 0.01F, 0);
            Water2D_Spawner.instance.Dynamic = true;
            Water2D_Spawner.instance.Spawn(1, new Vector3(10F, 0, 0));
            Water2D_Spawner.instance.LifeTime = -1;
        }
    }
}
