using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    //string[] Name = { "우태환 ", "제규원" };
    //int[] age = new int[3];

    //List<int> myHouse = new List<int>();

    Rigidbody myRigid;

    private void OnEnable()
    {

    }
    private void Awake()
    {
        //myHouse.Add(0);
        //int asd = myHouse.Count;
        //myHouse.RemoveAt(0);
        //myHouse.Clear();

        //for(int i = 0; i < age.Length; i++)
        //{

        //}
        //int exp = 3000;
        //int a = 3000 % 9;
        //int b = 3000 / 9;

        ////조건문
        //if(asd == 1)
        //{
        //    Debug.Log("앙 기모띠");
        //}
        //else 
        //{

        //}

        //switch(asd)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        Debug.Log("앙기모띠");
        //        break;
        //    case 4:
        //        break;
        //    default:
        //        Debug.Log("포함 안됨"); //else랑 같음
        //        break;
        //}

        //반복문

        //for(int i = 0; i < asd; i++)
        //{

        //}

        //while(true)
        //{
        //    return;
        //    continue;
        //    break;
        //}

        //foreach(int myHome in myHouse)
        //{
        //    Debug.Log(myHome);
        //}

        //Floor badack = new Floor();
        //badack.Log(); // 게임 매니저
        //badack.GetComponent<Floor>().Log(); // 게임 내의 여러개의 객체
    }
    private void Start()
    {
        myRigid = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {

    }
    private void Update()
    {
        //myRigid.AddTorque(transform.forward * 20.0f);
        //transform //자기자신
        //GetKey 누르는중 GetKeyDown 눌렀을때 GetKeyUp 떼어냈을때
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        transform.Translate(new Vector3(0, 0, Input.GetAxisRaw("Vertical")) * 10.0f * Time.deltaTime);

        float rotationVec = Input.GetAxisRaw("Horizontal");
        if (rotationVec != 0) transform.Rotate(Vector3.up * rotationVec * 180.0f * Time.deltaTime);
        //transform.eulerAngles += new Vector3(0, 180, 0) * Time.deltaTime;
    }
    private void LateUpdate()
    {

    }
    private void OnDestroy()
    {

    }
}
