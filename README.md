# Архитектура ПО (семинары)

------

## Урок 11. Сервис-ориентированные архитектуры
### Постарайтесь поработать с разработанным трехзвенным приложением (десктопный клиент/консольный клиент -> web-сервис -> БД)
### Конечно, желательно, повторить всю работу, проделанную на семинаре, постараться самостоятельно создать клиент, библиотеку классов, сгенерировать клиент и поработать с нашим Web-сервисом (например, на основе консольного клиента, добавить методы удаления/редактирования/добавления данных).
### Если вам тяжело работать в рамках языка C#, вы можете поработать с вашим сервисом в рамках языка Java, постараться протестировать работу вашего сервиса (вызвать несколько методов), создав ЛЮБОЙ клиент (можно обычный, консольный).

----------

### Я реализовала десктопного клиента **ClinicDesktop** с помощью WindowsForms (С#). Веб-сервис  [**ClinicService**](https://github.com/KuzminaElizavetaV/ClinicService "Ссылка на проект") реализован на Python (FastAPI + SQLAlchemy)

### Загрузка данных

![ClinicDesktop](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClient.png)

______

### Редактирование данных

![ClinicDesktopEdit](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientEdit.png)

![ClinicDesktopEdit2](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientEdit2.png)

![ClinicDesktopEdit3](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientEdit3.png)
_____

### Добавление данных

![ClinicDesktopAdd](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientAdd.png)

![ClinicDesktopAdd2](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientAdd2.png)

----

### Удаление данных

![ClinicDesktopDelete](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientDelete.png)

![ClinicDesktopDelete2](https://github.com/KuzminaElizavetaV/ClinicDesktop/blob/main/img/clinicClientDelete2.png)









