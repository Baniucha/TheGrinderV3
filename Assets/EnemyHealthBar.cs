﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthBar : MonoBehaviour
{
    Vector3 localScale;
    public Enemy enemyHealthRef;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = enemyHealthRef.health/50;
        transform.localScale = localScale;
    }
}
