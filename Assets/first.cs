using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first : MonoBehaviour
{
    //string[] Name = { "����ȯ ", "���Կ�" };
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

        ////���ǹ�
        //if(asd == 1)
        //{
        //    Debug.Log("�� ����");
        //}
        //else 
        //{

        //}

        //switch(asd)
        //{
        //    case 1:
        //    case 2:
        //    case 3:
        //        Debug.Log("�ӱ���");
        //        break;
        //    case 4:
        //        break;
        //    default:
        //        Debug.Log("���� �ȵ�"); //else�� ����
        //        break;
        //}

        //�ݺ���

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
        //badack.Log(); // ���� �Ŵ���
        //badack.GetComponent<Floor>().Log(); // ���� ���� �������� ��ü
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
        //transform //�ڱ��ڽ�
        //GetKey �������� GetKeyDown �������� GetKeyUp ���������
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
