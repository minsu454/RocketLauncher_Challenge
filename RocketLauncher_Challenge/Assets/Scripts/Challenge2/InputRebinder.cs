using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputRebinder : MonoBehaviour
{
    public InputActionAsset actionAsset;
    private InputAction spaceAction;

    [SerializeField] private AudioClip clip;

    void Start()
    {
        // [구현사항 1] actionAsset에서 Space 액션을 찾고 활성화합니다.
        spaceAction = actionAsset.FindActionMap("Challenge").FindAction("Scace");
        spaceAction.Enable();

        spaceAction.started += OnSpace;
    }

    // [구현사항 2] ContextMenu 어트리뷰트를 활용해서 인스펙터창에서 적용할 수 있도록 함
    [ContextMenu("RebindSpaceToEscape")]
    public void RebindSpaceToEscape()
    {
        if (spaceAction == null)
            return;

        // [구현사항 3] 기존 바인딩을 비활성화하고 새 키로 재바인딩
        actionAsset.FindActionMap("Challenge").ChangeBinding(0).WithPath("<Keyboard>/escape");

        Debug.Log("Done!");
    }

    private void OnSpace(InputAction.CallbackContext callback)
    {
        AudioManager.Instance.Play(clip);
    }

    void OnDestroy()
    {
        // 액션을 비활성화합니다.
        spaceAction?.Disable();
    }
}
