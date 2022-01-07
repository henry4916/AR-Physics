# AR & Physics
計算攝影學HW5_AR

# 問題與處理
環境建立
https://www.youtube.com/watch?v=MtiUx_szKbI&t=250s

Unity3D---Vuforia is not enabled解决方案
https://blog.csdn.net/qq_35768238/article/details/80728931

C# 錯誤解決
https://stackoverflow.com/questions/44107248/unity-5-5-2f1-to-5-6-1f1-interpolated-strings-error

# 專案內容
工具名稱與版本編號：Unity 2017.3.0f3 (64-bit) Vuforia with Unity
## 作業功能：
### 1. 使用 6 張 marker 其中包含
	a. AR.png    -> 載入整個遊戲畫面
	b. down.png  -> 使汽車向後移動
	c. left.png  -> 使汽車向左移動
	d. up.png    -> 使汽車向前移動
	e. right.png -> 使汽車向右移動
	f. restart.png -> 使遊戲重新開始
   且可以同時三張同時使用，例如 AR.png + up.png + down.png 汽車可以在遊戲畫面往右前一堆

### 2. 添加AR特效包含：
	a. 放置大石頭為障礙物品，使汽車無法通過，如果碰觸到就增加畫面上碰觸物體的數量，且有陽光造成的陰影
	b. 放置小石頭為障礙物品，使汽車無法通過，如果碰觸到就增加畫面上碰觸物體的數量，且有陽光造成的陰影
	c. 放置大樹為障礙物品，使汽車無法通過，如果碰觸到就增加畫面上碰觸物體的數量，且有陽光造成的陰影，且有風使樹會隨著風搖擺
	d. 放置小樹為障礙物品，使汽車無法通過，如果碰觸到就增加畫面上碰觸物體的數量，且有陽光造成的陰影，且有風使樹會隨著風搖擺
	e. 放置煙火在畫面，固定時間會播放
	f. 添加車輛，且調整車輛細節使其更美觀
	g. 添加類似火光的特效，其用意為汽車必須開到那裡，遊戲則完成

### 3. 其他遊戲設定：
	a. 當碰觸到物體會增加畫面上的數字，代表的意義為碰觸的物體使車輛受損，當碰觸量達到5次會顯示loss，表示遊戲輸了，要使用restart.png來重新開始遊戲
	b. 要完成遊戲則必須將車輛開到火光的特效那裡，且完成遊戲畫面會顯示 win

![](https://github.com/henry3063/AR-Physics/blob/main/demo.mp4)
