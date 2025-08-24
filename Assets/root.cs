using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class root : MonoBehaviour
{
    public float horizontalSpeed = 20.0f;
    public bool UnLockScreen = false;
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            UnLockScreen = !UnLockScreen; /*�������� �� �����/������� �������*/
        }

        if (UnLockScreen == false)
        {
            Cursor.lockState = CursorLockMode.Confined; /*������ ����� ��������� � �������� ����*/
            Cursor.lockState = CursorLockMode.Locked; /*��������� ������ � ������ ������*/
            Cursor.visible = false; /*������������� ������������ ������� �� "���"*/
   }
        else
        {
            Cursor.lockState = CursorLockMode.None; /*������������� �������*/
            Cursor.visible = true; /*������������ ������� �� "��"*/
        }
        if (UnLockScreen == false)
        {
            float v = horizontalSpeed * Input.GetAxis("Mouse X");
            gameObject.transform.Rotate(0f, v, 0f); /*������� ������ �����/������*/
        }
    }
}
