using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class root1 : MonoBehaviour
{
    public float horizontalSpeed = 20.0f;
    public bool UnLockScreen = false;
    [SerializeField]
    private Camera root;
    void Update()
    {
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
            float v = horizontalSpeed * Input.GetAxis("Mouse Y");
            root.transform.Rotate(v, 0f, 0f); /*������� ������ �����/������*/
        }
    }
}
