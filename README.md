# HangedMan_Test

## 📏 Adaptive Perception Measurer (Technical Detail)

知覚情報科学の知見に基づき、視覚環境の反転（180度回転）に対する人間の適応プロセスを定量化するための実験ツールです。
単なる正誤判定ではなく、Unityを用いた「1問ごとの反応速度」の精密なロギングにより、脳の再学習プロセスを時系列データとして可視化することを目的としています。

## 🧠 Application Concept

| Feature | Description |
| :--- | :--- |
| **視覚適応の測定** | 正常な向きと180度反転した計算課題の解答時間を比較し、脳の適応度を特定 |
| **時系列ロギング** | スペースキー入力により、1問ごとの解答時間をミリ秒単位で記録し適応曲線を抽出可能  |
| **干渉効果の分析** | 反転環境への適応が、その後の正常な視覚認識に与える影響（混乱）を測定  |

## 🛠 Tech Stack Details

| Component | Technology |
| :--- | :--- |
| **Engine** | Unity  |
| **UI Control** | UnityEngine.UI による視覚刺激（計算問題・読解文章）の提示  |
| **Data Handling** | System.IO (StreamWriter) による解答時間のCSVエクスポート  |

### Key Mechanics

| Mechanism | Description |
| :--- | :--- |
| **Stopwatch System** | Time.time を利用し、開始時からの経過時間をリストに保持する高精度計測 |
| **Slide Management** | SlideManager により、計算問題のセット（スライド）をキー操作でシームレスに切り替え |
| **Manual Logging** | Input.GetKeyDown(KeyCode.Space) をトリガーとした、被験者の発話に合わせた手動計測 |

## 🚀 Measurement Protocols

実験は以下の5つのフェーズで構成され、各ステップのデータを蓄積します。

| Phase | Description | Environment |
| :--- | :--- | :--- |
| **Phase 1** | 事前基準測定（セットA） | 正常な向きの計算問題 |
| **Phase 2** | 反転環境プレテスト（セットB） | 180度回転させた計算問題 |
| **Phase 3** | 適応介入（トレーニング） | 180度回転させた文章の継続読解 |
| **Phase 4** | 反転環境ポストテスト（セットC） | 180度回転させた計算問題 |
| **Phase 5** | 事後基準測定（セットD） | 再び正常な向きの計算問題 |

## 📊 Data Schema

出力されるCSV（StopwatchLog.csv）は、以下の構造で保存されます。

| Column | Type | Description |
| :--- | :--- | :--- |
| **Index** | int | 問題の試行番号 |
| **Time(sec)** | float | 問題を目視してから解答し終えるまでの秒数（F3フォーマット） |

## ⚡ 使用方法

| Step | Action |
| :--- | :--- |
| **1** | Application フォルダから該当のexeファイルを起動 |
| **2** | スライドが表示されたら、被験者の解答に合わせて「スペースキー」でタイムを記録 |
| **3** | 実験終了後、「Sキー」を押してCSVデータを保存 |
| **4** | 「Backspace」でスライドの戻り、「スペースキー」で次スライドへの送り操作が可能 |

---
「脳がいかに世界を補正しているか」を数値で解き明かす。このツールは、知覚の柔軟性と学習能力を解析するための実験基盤です。
