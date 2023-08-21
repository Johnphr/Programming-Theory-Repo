using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int MaxHealth { get; private set; }
    public int CurHealth { get; set; }

    // Start is called before the first frame update
    private void Awake()
    {
        MaxHealth = 3;
        CurHealth = MaxHealth;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
