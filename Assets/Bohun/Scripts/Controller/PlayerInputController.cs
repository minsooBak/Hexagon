using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : CharacterController
{
    /// <summary>
    /// Ű���� �Է� A /D 
    /// </summary>
    /// <param name="value">�¿� ���Ͱ�</param>
    //public void OnMove(InputValue value)
    //{
    //    Vector2 dirVec = value.Get<Vector2>().normalized;
    //    Debug.Log(dirVec);
    //    Debug.Log("Move");
    //    CallMoveEvent(dirVec);
    //}
    /// <summary>
    /// ���콺 ��Ŭ��
    /// </summary>
    /// <param name="inputValue"></param>
    public void OnRightClick(InputValue inputValue)
    {
        Debug.Log(inputValue);
        Vector2 dirVec = Vector2.right;
       
        if (!inputValue.isPressed)
        {
            dirVec = Vector2.zero;
        }
        CallMoveEvent(dirVec);
    }
    /// <summary>
    /// ���콺 �� Ŭ��
    /// </summary>
    /// <param name="inputValue"></param>
    public void OnLeftClick(InputValue inputValue)
    {
        Debug.Log(inputValue);
        Vector2 dirVec = Vector2.left;
        
        if (!inputValue.isPressed)
        {
            dirVec = Vector2.zero;
        }
        CallMoveEvent(dirVec);
    }
}