using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBehavioiur : HealthBehaviour
{
  
    private void Update()
    {
       if (Health <= 0)
        {
            Destroy(gameObject);
        }
    }

}
