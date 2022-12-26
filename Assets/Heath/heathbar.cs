
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heathbar : MonoBehaviour
{
    [SerializeField] private Heath playerHeath;
    [SerializeField] private Image totalheath;
    [SerializeField] private Image currentheathbar;
    private void Start()
    {
        
    }
    private void Update()
    {
        currentheathbar.fillAmount = playerHeath.currentHeath / 10;
    }
}
