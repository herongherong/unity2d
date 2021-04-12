using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newAnimatorScript : MonoBehaviour
{
    protected Animator animator;
    int a = 0;
    private float x_pos = 0.0f;
    private float y_pos = 0.0f;
    private float moving_speed = 10.0f;
    private bool isJump = false; 

    private void Player_moving_control()
    {

        float keyHorizontal = Input.GetAxis("Horizontal");
        //float KeyVertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * this.moving_speed * Time.smoothDeltaTime * keyHorizontal, Space.World);
        //transform.Translate(Vector3.up * this.moving_speed * Time.smoothDeltaTime * KeyVertical, Space.World);
        //Ÿ�ӵ�ŸŸ�Ӱ��ϴ� ���� = ��� �Ŀ��� ����� �ӵ��� �����̰� �ϱ� ���ؼ�.
        //������ ��ŸŸ�� ���� �ĺ���?
        if(Input.GetKeyDown(KeyCode.Right)
        {
            animator.SetBool("moveLeft", false);
            animator.SetBool("moveRIght", true);

        }
        else if(Input.GetKeyDown(KeyCode.Left))
        {
            animator.SetBool("moveLeft", true);
            animator.SetBool("moveRIght", false);
        }
    }

    private void Player_jump_control()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isJump == false)
            {
                
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("fJump", false);
        animator.SetBool("moveRight", true);

        animator.SetBool("moveLeft", false);

    }

    // Update is called once per frame
    void Update()
    {
        Player_moving_control();
        a += 1;
        if (a > 500)
        {

            animator.SetBool("fJump", true);

        }




    }
}
