using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    
    public pointManager pointsManager;
    public TextMeshProUGUI p1PointsText;
    public TextMeshProUGUI p2PointsText;

    public void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player2"))
        {
            pointsManager.AddPointP1();
            p2PointsText.text = "P2 Score: " + pointsManager.p1Points.ToString();
           
        }
        if (other.CompareTag("Player"))
        {
            pointsManager.AddPointP2();
            p1PointsText.text = "P1 Score: " + pointsManager.p2Points.ToString();
           
        }
    }
    
}
