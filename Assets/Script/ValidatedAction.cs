using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidatedAction : MonoBehaviour {

    public void Validated(int dataIn)
    {
        int actionID = dataIn;
        Debug.Log(actionID);
        if(actionID>0 && actionID<=4)
        {
            changeDifficulty(actionID);
        }
    }

    private void changeDifficulty(int desiredDifficulty)
    {
        //TODO
    }
}
