﻿using System;
using System.Collections;
using UnityEngine;

public class AlertSystem : MonoBehaviour
{
    // fov가 45라면 45도 각도안에 있는 aesteriod를 인식할 수 있음.
    [SerializeField] private float fov = 45f;
    // radius가 10이라면 반지름 10 범위에서 aesteriod들을 인식할 수 있음.
    [SerializeField] private float radius = 10f;
    private float alertThreshold;

    private Animator animator;
    private static readonly int blinking = Animator.StringToHash("isBlinking");

    private void Start()
    {
        animator = GetComponent<Animator>();
        // FOV를 라디안으로 변환하고 코사인 값을 계산
        alertThreshold = Mathf.Cos(fov * Mathf.Deg2Rad / 2f);
    }

    private void Update()
    {
        CheckAlert();
    }

    private void CheckAlert()
    {
        // 주변 반경의 소행성들을 확인하고 이를 감지하여 Alert를 발생시킴(isBlinking -> true)
        RaycastHit2D[] hitArr = Physics2D.CircleCastAll(transform.position, radius, Vector2.up, 0f, LayerMask.GetMask("Aesteriod"));

        bool isHit = false;

        foreach (var hit in hitArr)
        {
            Vector2 dirTargetVec = (hit.transform.position - transform.position).normalized;
            Vector2 seeDir = transform.up.normalized;

            float cos = Vector2.Dot(dirTargetVec, seeDir);

            if (cos < alertThreshold)
            {
                continue;
            }

            isHit = true;
            break;
        }

        animator.SetBool(blinking, isHit);
    }
}