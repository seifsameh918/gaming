using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercont : MonoBehaviour
{ public float movespeed;
         public float jumpHeight;
          public KeyCode Spacebar;
           public KeyCode L;
            public KeyCode K; 
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKeyDown(Spacebar))&&grounded
        jump();
       }
       
    
    if (Input.Getkey(L))
    {
    Getcomponent<Rigidbody2d>().velocity=new vector2(-movespeed,Getcomponent<rigidbody2d>().velocity.y);

     if(Getcomponent<SpriteRenderer>()!=null)
    Getcomponent<SpriteRenderer>().flipX=True;
    }

if (Input.KeyCode(R)){
    Getcomponent<rigidbody2d().velocity=new vector2(movespeed,Getcomponent<Rigidbody2D>().velocity.y);
    if(Getcomponent<SpriteRenderer>()!=null)
    Getcomponent<SpriteRenderer>().flipX=false;
}
 }
 void jump(){
        Getcomponent<Rigidbody2d>().velocity=new vector2(Getcomponent<rigidbody2d>().velocity.x,jumpHeight);
    }


    }

