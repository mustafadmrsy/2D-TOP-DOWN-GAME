# 2D Top Down Game

Unity ile geliştirilmiş, üstten görünümlü (top-down) 2D oyun projesi.

## Proje Özeti

Bu repo; 2D sahne, karakter hareketi ve oyun akışını temel alan bir **top-down** oyun altyapısı içerir. Proje yapısı Unity standartlarına uygundur ve doğrudan Unity Editor üzerinden açılıp çalıştırılabilir.

## Gereksinimler

- Unity **2019.3.3f1**
- Windows / macOS / Linux (Unity Editor hangi platformda kuruluysa)

> Unity sürümü bilgisi: `ProjectSettings/ProjectVersion.txt`

## Kurulum

- Bu repoyu klonla:

```bash
git clone https://github.com/mustafadmrsy/2D-TOP-DOWN-GAME.git
```

- Unity Hub üzerinden:
  - **Open** -> proje klasörünü seç
  - Proje açıldıktan sonra Unity, paketleri otomatik olarak resolve edecektir.

## Çalıştırma

- Unity Editor içinde ilgili sahneyi aç
- `Play` tuşuna bas

> Sahne adı/proje akışı repodaki mevcut sahne düzenine göre değişebilir.

## Kontroller

Kontrol şeması proje içinde değişebilir. Yaygın varsayılan kullanım:

- **Hareket**: `W/A/S/D` veya yön tuşları
- **Etkileşim / Aksiyon**: `E` / `Space`

Eğer input’lar farklıysa, şu dosyalardan kontrol edebilirsin:

- `ProjectSettings/InputManager.asset`
- İlgili oyuncu scriptleri (`Assets/Scripts/...`)

## Klasör Yapısı (Kısa)

- `Assets/`
  - Oyun içeriği (sahneler, sprite’lar, animasyonlar, scriptler)
- `Packages/manifest.json`
  - Unity package bağımlılıkları
- `ProjectSettings/`
  - Proje ayarları

## Kullanılan Paketler / Notlar

Projede Unity’nin 2D paketleri (Sprite, Tilemap vb.) bulunur.

Ayrıca repoda **A* Pathfinding Project** dosyaları yer alıyor (ör. `Assets/Scripts/AstarPathfindingProject/...`).

## Build Alma (Opsiyonel)

- `File -> Build Settings`
- Platform seç (Windows/Mac/Linux)
- `Build` veya `Build And Run`

## Katkı / Geliştirme

- PR’lar ve issue’lar kabul edilir.
- Büyük değişiklikler için önce issue açman önerilir.

## Lisans

Bu proje için lisans bilgisi repoda belirtilmemiş olabilir. Gerekirse `LICENSE` dosyası ekleyebilirsin.
