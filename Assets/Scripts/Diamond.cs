using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            player.GetComponent<PlayerDiamondCounter>().DiamondPickup();

            Destroy(gameObject);
        }
    }
}
