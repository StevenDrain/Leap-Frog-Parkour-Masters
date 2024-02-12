using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointManager : MonoBehaviour
{
    public int p1Points = 0;
    public int p2Points = 0;
   
    public void AddPointP1(){
        p1Points += 1;
        Debug.Log("Player 1 has " + p1Points + " points");

    }
    public void AddPointP2(){
        p2Points += 1;
        Debug.Log("Player 2 has " + p2Points + " points");
    }
}
    
