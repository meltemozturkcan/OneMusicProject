# OneMusicProject-Üyelik Sistemi ve JWT Kullanarak Yetkilendirme
Bu proje, **Json Web Token (JWT)** kullanılarak kullanıcıların kimlik doğrulamasını ve üyelik tipine göre yetkilendirilmesini sağlayan bir müzik akış sistemini içerir. Uygulamada, kullanıcılar farklı üyelik tiplerine göre müzik listelerine erişim sağlamakta ve yetkileri doğrultusunda müzik dinleyebilmektedir. Proje, kullanıcıların sistemde güvenli bir şekilde oturum açmalarını ve token süreleri dolana kadar müzik dinleyebilmelerini amaçlamaktadır.

#### 🚀 Özellikler:

-   **JWT ile Kimlik Doğrulama:** Kullanıcılar sisteme giriş yaptıktan sonra bir token alır ve bu token geçerlilik süresi boyunca müzik dinleyebilir.
-   **Üyelik Tipleri:** Sistemde dört farklı üyelik tipi bulunmaktadır: Basic, Flex, Gold, ve Premium. Kullanıcı, sadece kendi üyelik tipine uygun müzik listelerine erişim sağlayabilir.
-   **Müzik Dinleme Yetkilendirmesi:** Kullanıcılar müzik dinlemek istediklerinde, sistem müziğin kullanıcı üyelik tipine uygun olup olmadığını kontrol eder ve yetkilendirme doğrulaması yapar.
-   **Token Süresi:** Token geçerlilik süresi dolduğunda kullanıcı tekrar sisteme giriş yaparak yeni bir token almalıdır. Aksi takdirde müzik dinleme erişimi kesilir.
-   **Gizli Müzik Listeleri:** Sistemdeki tüm müzik listelerine sadece kayıtlı üyeler erişebilir. Üyelik seviyesine göre farklı listelere erişim sağlanır.

#### 🔧 Teknolojiler:

-   **Asp. Net Core 8**
-   **Json Web Token**
-   **MSSQL**
-   **SweetAlert** - Kullanıcı dostu bildirimler ve uyarılar için.
-   **Onion Architecture** - Katmanlı mimari yaklaşımıyla esnek ve ölçeklenebilir yapı.
-   **Web API** - RESTful API ile sistemin dış uygulamalarla entegrasyonu.

Bu proje, üyelik tabanlı müzik akış sistemlerinde güvenli ve yetkilendirilmiş erişim sağlama üzerine inşa edilmiştir. Kullanıcı deneyimini artırmak ve güvenli bir müzik dinleme platformu sunmak amacıyla geliştirilmiştir.
