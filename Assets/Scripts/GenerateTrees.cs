using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateTrees : MonoBehaviour
{

	public GameObject tree;	

    // Start is called before the first frame update
    void Start()
    {
    	GameObject.Instantiate(tree);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
