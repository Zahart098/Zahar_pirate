using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heath : MonoBehaviour
{
    [SerializeField] private float startingHeath;
    public float currentHeath { get; private set; }

    private void Awake()
    {
        currentHeath = startingHeath;
    }
    public void TakeDamege(float _damage)
    {
        currentHeath = Mathf.Clamp(currentHeath - _damage, 0, startingHeath);
        if (currentHeath < 0)
        {
           //player hurt
        }
        else
        {
            //player dead
        }
    }
}
