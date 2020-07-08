# Task1
This is a test task part 1.1 from "SkyOri"
Практическое задание №1 - Серверная разработка (C#, .NET, ASP.NET)

Для реализации потребуется:

Microsoft Visual Studio 2015
Git for Windows

Задание. Часть 1.

Требуется реализовать 2 алгоритма генерации уникального цифро-буквенного кода для QR-кода объекта теплопотребления, исходя из следующих входных данных:

наименование объекта,
дата регистрации (валидная дата),
лицевой счет потребителя (только целые числа).
Алгоритмы формирования данного кода нужно придумать самостоятельно. Тип алгоритма должен содержаться в этом самом коде. Длина цифро-буквенного кода не должна превышать 18 символов. Код должен быть построен таким образом, что по нему должна быть реализована потенциальная возможность вычислить конкретный объект теплопотребления (из известного списка), не храня соответствия между объектом и кодом. Примеры цифро-буквенного кода: 2017-01-01-ШШШШПВ; А665Б44В121212. К алгоритму следует в комментарии приложить описание выбранного варианта работы алгоритма, т.к. допустимы различные варианты формирования данного цифро-буквенного кода.

Реализацию следует сделать в виде .net-библиотеки и подготовить модульные тесты для неё, продемонстрировать процент покрытия кода модульными тестами (чем больше, тем лучше).
