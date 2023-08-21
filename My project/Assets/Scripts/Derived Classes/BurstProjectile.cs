using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurstProjectile : Projectile
{
    // INHERITANCE
    // POLYMORPHISM
    // Deal 3 damage for this projectile
    protected override int DealDamage()
    {
        int damage = 2;
        return damage;
    }
}
