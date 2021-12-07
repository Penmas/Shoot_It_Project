using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    Animator anim;
    public int ShootLota;
    public int LeftShoot;
    public int RightShoot;
    private int MyLota;
    public static bool isShoot;
    public AudioClip clip;
    // Start is called before the first frame update


    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        isShoot = false;
    }


    // Update is called once per frame
    void Update()
    {

        ShootLota = 2;       
        MyLota = AttackSpawn.MyAttackLota;
        if(MyLota > 0 && MyLota < LeftShoot)
        {
            ShootLota = -1;
        }
        if (MyLota >= LeftShoot && MyLota <= RightShoot)
        {
            ShootLota = 0;
        }
        if (MyLota < 10 && MyLota > RightShoot)
        {
            ShootLota = 1;
        }

        if (ShootLota == -1)
        {
            anim.SetInteger("ShootLota", 1);
        }
        else if(ShootLota == 0)
        {           
            anim.SetInteger("ShootLota", 2);
        }
        else if (ShootLota == 1)
        {
            anim.SetInteger("ShootLota", 3);
        }
        else
        {
            anim.SetInteger("ShootLota", 0);
        }

        if (ShootLota != 2)
            isShoot = true;
        else
            isShoot = false;

        if(isShoot == true)
            AudioManager.instance.SFXPlay("Shoot", clip);

        AttackSpawn.MyAttackLota = 0;
    }
}
