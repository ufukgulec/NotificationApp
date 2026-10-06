# NotificationApp

Gerçek zamanlı bildirimlerin **ASP.NET Core SignalR** üzerinden istemcilere iletilmesini ve **Blazor** tabanlı bir arayüzde görüntülenmesini amaçlayan örnek bir .NET uygulamasıdır.

Proje, istemci ile sunucu arasındaki gerçek zamanlı iletişimin SignalR ile nasıl gerçekleştirilebileceğini göstermek amacıyla hazırlanmıştır.

![signal r](https://github.com/ufukgulec/NotificationApp/assets/51711890/8516edb0-793b-4203-8261-a47922e865c2)

## 🚀 Özellikler

* Gerçek zamanlı bildirim iletimi
* ASP.NET Core SignalR kullanımı
* Blazor tabanlı istemci uygulaması
* API ve Client katmanlarının ayrıştırılması
* SignalR Hub üzerinden client-server iletişimi
* .NET tabanlı modern uygulama yapısı

## 🏗️ Proje Yapısı

```text
NotificationApp/
│
├── Notification.API/
│   └── ASP.NET Core API
│
├── Notification.Client/
│   └── Blazor Client
│
├── NotificationApp.sln
└── README.md
```

### Notification.API

Bildirim sisteminin backend katmanıdır.

API tarafında:

* ASP.NET Core
* SignalR
* SignalR Hub
* Gerçek zamanlı client iletişimi

kullanılarak bildirimlerin istemcilere aktarılması sağlanır.

### Notification.Client

Kullanıcı arayüzünü ve SignalR bağlantısını içeren Blazor uygulamasıdır.

Client, SignalR Hub'a bağlanarak sunucu tarafından gönderilen bildirimleri gerçek zamanlı olarak alır ve kullanıcıya gösterir.

## 🔄 Çalışma Mantığı

Uygulamanın temel iletişim akışı:

```text
┌─────────────────────┐
│   Notification API  │
│    ASP.NET Core     │
└──────────┬──────────┘
           │
           │ SignalR
           ▼
┌─────────────────────┐
│    SignalR Hub      │
└──────────┬──────────┘
           │
           │ Real-Time
           ▼
┌─────────────────────┐
│ Notification Client │
│       Blazor        │
└─────────────────────┘
```

Sunucu tarafında oluşturulan bildirim SignalR üzerinden bağlı istemcilere iletilir. Client tarafı ise Hub bağlantısı üzerinden mesajı alarak kullanıcı arayüzünü günceller.

## 🛠️ Teknolojiler

| Teknoloji    | Kullanım                |
| ------------ | ----------------------- |
| C#           | Uygulama geliştirme     |
| .NET         | Uygulama altyapısı      |
| ASP.NET Core | Backend / API           |
| SignalR      | Gerçek zamanlı iletişim |
| Blazor       | Client uygulaması       |
| Git          | Versiyon kontrolü       |

## ⚙️ Gereksinimler

Projeyi çalıştırmadan önce aşağıdaki araçların sisteminizde kurulu olması gerekir:

* .NET SDK
* Visual Studio / JetBrains Rider / VS Code
* Git

## ▶️ Çalıştırma

Repository'yi klonlayın:

```bash
git clone https://github.com/ufukgulec/NotificationApp.git

cd NotificationApp
```

Solution'ı IDE üzerinden açarak projeleri çalıştırabilirsiniz:

```text
NotificationApp.sln
```

Backend ve Client projelerini ayrı ayrı çalıştırabilir veya IDE üzerinden birden fazla startup project tanımlayabilirsiniz.

## 📡 SignalR

Projenin temel amacı SignalR kullanarak **persistent connection** üzerinden gerçek zamanlı veri iletişimini göstermektir.

Klasik HTTP request/response yaklaşımından farklı olarak, bağlantı kurulduktan sonra sunucu istemciye ihtiyaç duyulduğu anda veri gönderebilir.

Örnek iletişim:

```text
Client
   │
   │ Connect
   ▼
SignalR Hub
   │
   │ Notification
   ▼
Client
```

Bu yaklaşım;

* Bildirim sistemleri
* Chat uygulamaları
* Canlı dashboard'lar
* Gerçek zamanlı durum güncellemeleri
* İşlem/proses bildirimleri

gibi senaryolarda kullanılabilir.

## 🎯 Projenin Amacı

Bu repository, özellikle aşağıdaki konularda pratik bir örnek oluşturmayı amaçlamaktadır:

* ASP.NET Core ile backend geliştirme
* Blazor ile web client geliştirme
* SignalR Hub oluşturma
* Real-time communication
* Client-server iletişimi
* .NET solution/project organizasyonu

## 📌 Geliştirme Alanları

Proje temel bir gerçek zamanlı bildirim altyapısı olarak genişletilebilir.

Planlanabilecek geliştirmeler:

* Kullanıcı bazlı bildirimler
* Grup bazlı bildirimler
* Okundu / okunmadı durumu
* Bildirim geçmişi
* Kalıcı bildirim kayıtları
* Bildirim türleri
* Öncelik seviyeleri
* Authentication / Authorization
* SQL Server entegrasyonu
* Background notification service
* Docker desteği

## 📄 License

Bu proje eğitim, geliştirme ve teknik araştırma amacıyla oluşturulmuştur.

---

**GitHub Repository:**
https://github.com/ufukgulec/NotificationApp
