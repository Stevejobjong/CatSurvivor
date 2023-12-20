using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Season;

public class Season : MonoBehaviour
{
    //������ ���� �µ� ��ȭ�� ����
    public float LowTemperature = -5.0f; //1��
    public float HighTemperature = 30.0f; //7��

    private float[] monthlyTemperatures = new float[12]; // 12���� �µ��� ������ �迭

    public void Update()
    {
        SeasonalChanges(GameManager.Instance.month);
    }
    public void SeasonalChanges(int month) //������ȭ�� ���� �µ� ��ȭ
    {
        float temperatureDifference = HighTemperature - LowTemperature;
        float increment = temperatureDifference / 6.0f; // 6������ ���� �����Ǵ� ���� ���

        // 1������ 7�������� �µ� ����
        if (month < 8)
        {
            monthlyTemperatures[month - 1] = LowTemperature + (increment * month-1);
            GameManager.Instance.WorldTemperature = monthlyTemperatures[month - 1];
        }
        else
        {
            // 8������ 12�������� �µ� ���� (7�� �µ����� �����ϵ��� ����)
            monthlyTemperatures[month - 1] = HighTemperature - (increment * (month - 8));
            GameManager.Instance.WorldTemperature = monthlyTemperatures[month - 1];
        }
    }

    public float GetTemperatureForMonth(int month)
    {
        if (month >= 1 && month <= 12)
        {
            return monthlyTemperatures[month - 1];
        }
        else
        {
            return 0.0f;
        }
    }

}