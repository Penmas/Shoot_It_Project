using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttackSpawn : MonoBehaviour
{
    public GameObject MyAttack;
    public Transform[] AttackPoints;
    public static int MyAttackLota;
    public static float ShootTime;
    public int MyShoot;

    // Start is called before the first frame update
    void Start()
    {
        MyAttackLota = 0;
        ShootTime = 0f;
        MyShoot = 0;
    }

    // Update is called once per frame
    void Update()
    {
        MyShoot = 0;
        ShootTime += Time.deltaTime;
        if(GameManager.GameState == 0 && ShootTime >0.7f)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                MyShoot = 1;
                Instantiate(MyAttack, AttackPoints[0]);
                MyAttackLota = 1;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                MyShoot = 2;
                Instantiate(MyAttack, AttackPoints[1]);
                MyAttackLota = 2;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                MyShoot = 3;
                Instantiate(MyAttack, AttackPoints[2]);
                MyAttackLota = 3;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                MyShoot = 4;
                Instantiate(MyAttack, AttackPoints[3]);
                MyAttackLota = 4;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                MyShoot = 5;
                Instantiate(MyAttack, AttackPoints[4]);
                MyAttackLota = 5;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad6))
            {
                MyShoot = 6;
                Instantiate(MyAttack, AttackPoints[5]);
                MyAttackLota = 6;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad7))
            {
                MyShoot = 7;
                Instantiate(MyAttack, AttackPoints[6]);
                MyAttackLota = 7;
                ShootTime = 0f;
            }
            /*if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                Instantiate(MyAttack, AttackPoints[7]);
                MyAttackLota = 8;
                ShootTime = 0f;
            }
            if (Input.GetKeyDown(KeyCode.Keypad9))
            {
                Instantiate(MyAttack, AttackPoints[8]);
                MyAttackLota = 9;
                ShootTime = 0f;
            }*/
            
        }
    }
}
