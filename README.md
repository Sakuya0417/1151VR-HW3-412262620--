Unity 作業製作流程與操作說明
以下是本次 Unity 2D 輪盤作業的詳細製作流程與相關操作說明：
1. 專案截圖<img width="900" height="423" alt="image" src="https://github.com/user-attachments/assets/3cdccfad-efe1-4ccd-be00-6eaa881460f3" />

 2. GitHub 連結
https://github.com/Sakuya0417/1151VR-HW3-412262620--.git
3. YouTube 連結
https://youtu.be/F6StrvKGPjM
4. 說明製作流程和相關操作
•	2D 專案準備與圖片匯入：建立 Unity 2D 專案，匯入輪盤與指針圖片，並設定 Texture Type 為 Sprite (2D and UI) 及勾選 Alpha is Transparency 確保去背完整。
•	物件配置與層級設定：將輪盤與指針拖曳至 Scene (場景) 中，設定指針位於輪盤正上方，並透過調整 Sprite Renderer 的 Order in Layer 確保指針圖層覆蓋於輪盤之上。
•	音效元件與腳本實作：為輪盤新增 Audio Source 並匯入轉動音效。撰寫 C# 腳本實作點擊後的加速旋轉、減速停止以及音效控制，並掛載至輪盤物件上。
•	編輯器執行測試：在 Unity 編輯器中點選 Play 鍵，於 Game 視窗中點擊畫面，確認輪盤能正常觸發旋轉、發出音效並減速停止。
•	APK 輸出與模擬器測試：將專案編譯輸出為 Android APK 檔案，並將其安裝至電腦端的 Android 模擬器中。開啟模擬器內的 App 後，成功載入 Unity 畫面，點擊模擬器畫面同樣能順利觸發輪盤旋轉與停止，完成手機端環境的相容性測試。
