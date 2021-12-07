using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyBush : MonoBehaviour
{
    public int EnemyStatus; //0 = ¼öÇ®, 1 = ³ª¿Ã ¿¹Á¤, 2 = ¸äµÅÁö ³ª¿È, 3 = ÇÔÁ¤ ³ª¿È, 4 = ÀâÈû, 5 = µé¾î°¨
    private bool Catch;

    public float SpawnTimeMax;
    public float SpawnTimeMin;
    public float SpawnTimeSet;
    public float SpawncurTime;

    public float EnemyIdleTime;
    private float IdlecurTime;

    private int SpawnEnemyKind; //½ºÆù ¸÷ Á¾·ù »Ì±â
    public int TrapNum; // ÇÔÁ¤ ³Ö±â È®·ü


    SpriteRenderer spriteRenderer;
    Animator anim;


    void Start()
    {
        EnemyStatus = 0;
        spriteRenderer = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        if (GameManager.GameState == 0)
        {
            SpawncurTime += Time.deltaTime;
            if(EnemyStatus == 0)
            {
                SpawnTimeSet = Random.Range(SpawnTimeMin, SpawnTimeMax);
                EnemyStatus = 1;
            }

            if(EnemyStatus == 1)
            {
                if(SpawncurTime >= SpawnTimeSet)
                {
                    SpawnEnemyKind = Random.Range(0, 10);
                    if(SpawnEnemyKind >= TrapNum)
                    {
                        EnemyStatus = 2;
                        anim.SetInteger("BoarStatus", 2);
                    }
                    else
                    {
                        EnemyStatus = 3;
                        anim.SetInteger("BoarStatus", 3);
                    }    
                }
            }

            if (EnemyStatus == 2)
            {
                IdlecurTime += Time.deltaTime;
                if(IdlecurTime >= EnemyIdleTime)
                {
                    anim.SetInteger("BoarStatus", 5);
                    EnemyStatus = 0;
                    IdlecurTime = 0;
                    SpawncurTime = 0;
                }

                if (Catch == true)
                {
                    anim.SetInteger("BoarStatus", 4);
                    GameManager.MyScore++;
                    Catch = false;
                    IdlecurTime = 0;
                    SpawncurTime = 0;
                    EnemyStatus = 0;
                }
                
            }

            if (EnemyStatus == 3)
            {
                IdlecurTime += Time.deltaTime;
                if (IdlecurTime >= EnemyIdleTime)
                {
                    anim.SetInteger("BoarStatus", 5);                    
                    EnemyStatus = 0;
                    IdlecurTime = 0;
                    SpawncurTime = 0;
                }
                if (Catch == true)
                {
                    anim.SetInteger("BoarStatus", 4);
                    GameManager.MyScore--;
                    Catch = false;
                    IdlecurTime = 0;
                    SpawncurTime = 0;
                    EnemyStatus = 0;
                }
            }
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    { 
        if(EnemyStatus == 2 || EnemyStatus == 3)
        {
            if (collision.gameObject.tag == "MyAttack")
            {
                Catch = true;
            }
        }
    }

}
