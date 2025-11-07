using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesandFunctions : MonoBehaviour
{
    //Creating an interger variable
    int myInt = 2;
    // Start is called before the first frame update
    void Start()
    {
        // running my int variable 
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);

    }

    // Update is called once per frame
    void Update()
    {

    }
    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }

}
