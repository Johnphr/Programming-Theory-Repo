using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalProjectile : Projectile
{
    // INHERITANCE
    // POLYMORPHISM
    // Deal 3 damage for this projectile
    protected override int DealDamage()
    {
        int damage = 3;
        return damage;
    }
}
