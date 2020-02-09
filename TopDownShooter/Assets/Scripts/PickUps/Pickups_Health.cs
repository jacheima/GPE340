using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickups_Health : PickUps
{
    [SerializeField] private float healAmount = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnPickUp(Player player)
    {
        if (player.GetComponent<Health>())
        {
            player.GetComponent<Health>().Heal(healAmount);
        }
        Destroy(gameObject);
        base.OnPickUp(player);
    }
}
