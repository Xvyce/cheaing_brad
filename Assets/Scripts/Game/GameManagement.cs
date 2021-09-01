using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public GameObject completeLevelUI;



    public void CompleteLevel()
    {

        completeLevelUI.SetActive(true);
    }
}
