using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    private float currentHP;
    public float MaxHP = 1f;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeHP(float v)
    {
        currentHP = Mathf.Clamp(currentHP + v, 0f, MaxHP);
    }

    public float GetHP()
    {
        return currentHP;
    }

    public float GetMaxHP()
    {
        return MaxHP;
    }
}
