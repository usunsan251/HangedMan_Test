# HangedMan_Test

## 📏 Adaptive Perception Measurer (Technical Detail)

[cite_start]知覚情報科学の知見に基づき、視覚環境の反転（180度回転）に対する人間の適応プロセスを定量化するための実験ツールです [cite: 26, 29]。
[cite_start]単なる正誤判定ではなく、Unityを用いた「1問ごとの反応速度」の精密なロギングにより、脳の再学習プロセスを時系列データとして可視化することを目的としています [cite: 33, 34]。

## 🧠 Application Concept

| Feature | Description |
| :--- | :--- |
| **視覚適応の測定** | [cite_start]正常な向きと180度反転した計算課題の解答時間を比較し、脳の適応度を特定 [cite: 29, 33] |
| **時系列ロギング** | [cite_start]スペースキー入力により、1問ごとの解答時間をミリ秒単位で記録し適応曲線を抽出可能 [cite: 34, 37] |
| **干渉効果の分析** | [cite_start]反転環境への適応が、その後の正常な視覚認識に与える影響（混乱）を測定 [cite: 29, 54] |

## 🛠 Tech Stack Details

| Component | Technology |
| :--- | :--- |
| **Engine** | [cite_start]Unity [cite: 31] |
| **UI Control** | [cite_start]UnityEngine.UI による視覚刺激（計算問題・読解文章）の提示 [cite: 39] |
| **Data Handling** | [cite_start]System.IO (StreamWriter) による解答時間のCSVエクスポート [cite: 46] |

### Key Mechanics

| Mechanism | Description |
| :--- | :--- |
| **Stopwatch System** | Time.time を利用し、開始時からの経過時間をリストに保持する高精度計測 |
| **Slide Management** | SlideManager により、計算問題のセット（スライド）をキー操作でシームレスに切り替え |
| **Manual Logging** | [cite_start]Input.GetKeyDown(KeyCode.Space) をトリガーとした、被験者の発話に合わせた手動計測 [cite: 34, 37] |

## 🚀 Measurement Protocols

[cite_start]実験は以下の5つのフェーズで構成され、各ステップのデータを蓄積します [cite: 34]。

| Phase | Description | Environment |
| :--- | :--- | :--- |
| **Phase 1** | 事前基準測定（セットA） | [cite_start]正常な向きの計算問題 [cite: 35] |
| **Phase 2** | 反転環境プレテスト（セットB） | [cite_start]180度回転させた計算問題 [cite: 35] |
| **Phase 3** | 適応介入（トレーニング） | [cite_start]180度回転させた文章の継続読解 [cite: 35] |
| **Phase 4** | 反転環境ポストテスト（セットC） | [cite_start]180度回転させた計算問題 [cite: 36] |
| **Phase 5** | 事後基準測定（セットD） | [cite_start]再び正常な向きの計算問題 [cite: 36] |

## 📊 Data Schema

出力されるCSV（StopwatchLog.csv）は、以下の構造で保存されます。

| Column | Type | Description |
| :--- | :--- | :--- |
| **Index** | int | 問題の試行番号 |
| **Time(sec)** | float | [cite_start]問題を目視してから解答し終えるまでの秒数（F3フォーマット） [cite: 37] |

## ⚡ 使用方法

| Step | Action |
| :--- | :--- |
| **1** | Application フォルダから該当のexeファイルを起動 |
| **2** | スライドが表示されたら、被験者の解答に合わせて「スペースキー」でタイムを記録 |
| **3** | 実験終了後、「Sキー」を押してCSVデータを保存 |
| **4** | 「Backspace」でスライドの戻り、「スペースキー」で次スライドへの送り操作が可能 |

---
「脳がいかに世界を補正しているか」を数値で解き明かす。このツールは、知覚の柔軟性と学習能力を解析するための実験基盤です。
