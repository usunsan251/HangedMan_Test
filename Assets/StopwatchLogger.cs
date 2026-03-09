using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class StopwatchLogger : MonoBehaviour
{
    private float startTime;
    private bool isRunning = false;
    private List<float> logTimes = new List<float>();

    void Start()
    {
        // ストップウォッチ開始
        startTime = Time.time;
        isRunning = true;
    }

    void Update()
    {
        if (!isRunning) return;

        // Space キーが押されたら記録
        if (Input.GetKeyDown(KeyCode.Space))
        {
            float currentTime = Time.time - startTime;
            logTimes.Add(currentTime);
            Debug.Log("記録: " + currentTime.ToString("F3") + " 秒");
        }

        // S キーで CSV 保存
        if (Input.GetKeyDown(KeyCode.S))
        {
            SaveToCSV();
        }
    }

    void SaveToCSV()
    {
        string path = Application.dataPath + "/StopwatchLog.csv";

        using (StreamWriter writer = new StreamWriter(path))
        {
            writer.WriteLine("Index,Time(sec)");

            for (int i = 0; i < logTimes.Count; i++)
            {
                writer.WriteLine($"{i + 1},{logTimes[i]:F3}");
            }
        }

        Debug.Log("CSV 保存完了: " + path);
    }
}