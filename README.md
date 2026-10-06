# 🎮 Game 1

**Game 1** adalah prototype game yang dibuat menggunakan **Unity** sebagai project eksperimen untuk mempelajari dasar-dasar pengembangan game.

Game ini memiliki sistem pertarungan sederhana antara **Player** dan **Enemy**, lengkap dengan movement, attack, animasi, health system, serta beberapa scene seperti Main Menu, About, Game, dan Game Over.

## 🎥 Demo

Berikut video demo dari **Game 1**:

[![Watch the video](https://img.youtube.com/vi/s28bKAdWcrk/maxresdefault.jpg)](https://youtu.be/s28bKAdWcrk)

## 📌 Tentang Game

Game 1 merupakan game prototype dengan fokus pada eksplorasi mekanik dasar game.

Pemain dapat bergerak di dalam map, menghadapi enemy, dan melakukan pertarungan. Baik Player maupun Enemy memiliki animasi untuk movement dan attack sehingga pertarungan terasa lebih hidup.

## 🛠️ Dibuat Dengan

- **Unity**
- C#
- Tilemap
- Unity Animator
- 2D Game Development

## 🕹️ Fitur Saat Ini

- 🏠 Main Menu
- 📖 About Scene
- 🗺️ Tilemap sebagai environment
- 🧍 Player
- 👾 Enemy
- 🚶 Player movement animation
- 🚶 Enemy movement animation
- ⚔️ Player attack animation
- ⚔️ Enemy attack animation
- ❤️ Health / HP system
- 💥 Sistem pertarungan Player vs Enemy
- 💀 Game Over
- 🔄 Perpindahan antar scene

## ⚔️ Sistem Pertarungan

Player dan Enemy memiliki HP dan dapat saling menyerang.

```text
              ┌──────────────┐
              │   Battle     │
              │ Player vs    │
              │    Enemy     │
              └──────┬───────┘
                     │
          ┌──────────┴──────────┐
          │                     │
     Enemy HP = 0          Player HP = 0
          │                     │
          ▼                     ▼
    Enemy Kalah             Player Kalah
                                │
                                ▼
                           Game Over
```

- Jika **HP Enemy habis terlebih dahulu**, Enemy kalah.
- Jika **HP Player habis terlebih dahulu**, Player kalah dan masuk ke **Game Over**.

## 🎬 Scene

Game saat ini memiliki beberapa scene:

| Scene         | Fungsi                                  |
| ------------- | --------------------------------------- |
| **Main Menu** | Menu utama untuk memulai game           |
| **About**     | Menampilkan informasi mengenai game     |
| **Game**      | Scene utama untuk bermain dan bertarung |
| **Game Over** | Ditampilkan ketika Player kalah         |

### Alur Game

```text
Main Menu
   │
   ├── About
   │
   └── Game
        │
        ├── Enemy HP = 0
        │      └── Enemy Kalah
        │
        └── Player HP = 0
               └── Game Over
```

## 🎞️ Animation

Player dan Enemy sudah memiliki beberapa animasi dasar, seperti:

- Idle
- Movement / Walk
- Attack
- Animasi saat melakukan aksi dalam pertarungan

Animasi digunakan melalui **Unity Animator** untuk mengatur perubahan state berdasarkan kondisi karakter.

## 🗺️ Map

Game menggunakan **Tilemap** untuk membangun environment tempat Player dan Enemy bertarung.

Tilemap digunakan agar pembuatan map lebih mudah dikembangkan dan memungkinkan environment disusun menggunakan tile secara modular.

## 🚧 Status Project

**Prototype / In Development**

Project ini masih dalam tahap eksperimen dan pembelajaran. Beberapa fitur masih sederhana dan kemungkinan akan dikembangkan atau diperbaiki di kemudian hari.

## 🔮 Rencana Pengembangan

- [ ] UI Health Bar yang lebih baik
- [ ] Enemy AI yang lebih kompleks
- [ ] Animasi tambahan
- [ ] Sound Effect
- [ ] Background Music
- [ ] Sistem damage yang lebih baik
- [ ] Victory / Win Screen
- [ ] Pause Menu
- [ ] Level tambahan
- [ ] Lebih banyak jenis Enemy
- [ ] Peningkatan visual dan gameplay

## 🎯 Tujuan Project

Project ini dibuat sebagai sarana untuk belajar dan mencoba berbagai konsep dalam **Unity Game Development**, terutama:

- Scene Management
- Tilemap
- Player Movement
- Enemy System
- Animation
- Animator
- Combat System
- Health System
- Game State
- Basic Game Logic

---

> 🎮 **Game 1 — A simple Unity game prototype made for learning and experimentation.**
