# PingPong

A classic 2-player Pong game built in Unity for **CMS 320 - Video Game Design** class at Rollins College

---

## 👉 Overview & Requirements

Create a simple 2-player ping-pong game with the following requirements:

- Player vs. Player movement (W/S for Player 1, up/down keys for Player 2)
- A ball that bounces between paddles and top/bottom walls
- Score tracking for both players
- A win occurs at **5 points**
- Display the winning player
- One advanced feature (here the speed of the ball is increased by 10% everytime it hits paddle)

---

## 🧠 Features 

- 🎮 **Two-player control**: Independent inputs for each paddle
- ⚽️ **Ball mechanichs**:
  - Starts in a random direction
  - Bounces off paddles and walls
  - Accelerates after each paddle hit (enhancement)
- 🏆 **Score system**:
  - Players score by sending ball past oponent's paddle
  - First to reach 5 points wins
  - UI updates live
- 💬 UI Elements:
  - Start menu/button
  - Score display using TextMeshPro
  - Win message with "Player X wins!"
- 🧩 **Enhancement**:
  - Ball speed increases by 10% with every paddle collision
  - Middle dotted line (Background)
 
---

## 🛠️ How to Run

<pre>
git clone https://github.com/stellafruijtier/PingPong.git
cd PingPong
</pre>

Then in Unity:
1. Open the project via Unity Hub from the PingPong folder
2. Load SampleScene.unity
3. Click Play

---

## 🔥 Game Flow

1. Launch --> Start menu appears
2. Click **Start**
3. Play to rally the ball; first to 5 points wins
4. After a point or a new game start, paddles and ball reset automatically

---

## 📖 Acknowledgments

This project was inspired by assignments and materials from Dr. Tisha, whose examples and explanations in video game design helped guide this work for the **Video Game Design** class at Rollins College.


