using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputRebinder : MonoBehaviour
{
    public InputActionAsset actionAsset;
    private InputAction spaceAction;

    void Start()
    {
        // [�������� 1] actionAsset���� Space �׼��� ã�� Ȱ��ȭ�մϴ�.
        spaceAction = actionAsset.FindActionMap("Challenge").FindAction("Scace");
        spaceAction.Enable();

        spaceAction.started += OnSpace;
    }

    // [�������� 2] ContextMenu ��Ʈ����Ʈ�� Ȱ���ؼ� �ν�����â���� ������ �� �ֵ��� ��
    [ContextMenu("RebindSpaceToEscape")]
    public void RebindSpaceToEscape()
    {
        if (spaceAction == null)
            return;

        // [�������� 3] ���� ���ε��� ��Ȱ��ȭ�ϰ� �� Ű�� ����ε�
        actionAsset.FindActionMap("Challenge").ChangeBinding(0).WithPath("<Keyboard>/escape");

        Debug.Log("Done!");
    }

    private void OnSpace(InputAction.CallbackContext callback)
    {
        Debug.Log("in");
    }

    void OnDestroy()
    {
        // �׼��� ��Ȱ��ȭ�մϴ�.
        spaceAction?.Disable();
    }
}
