using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceFever : Upgrade
{
    public override void ActivateAbility()
    {
        base.ActivateAbility();
        player = FindObjectOfType<PlayerControl>();
        player.canJump = true;
    }
}
