# Технологии использованные во время выполнения тестового задания

Для выполнения тестового задания был выбран язык программирования C#, СУБД - Postgresql,ORM - EntityFramework.  
Для запуска приложения необоходимо скачать и разархивировать программу с данного репозитория (или склонировать его), затем перейти в директорию ./TestTaskConsole/bin/Release/net7.0 и запустить приложение с помощью команды   
<h4 align="center">myApp {параметр от 1 до 5 или connect} {Вариативный параметр}</h4>


## Описание методов приложения 

* ### myApp connect {строка подключения к базе данных}
Для того чтобы подключить приложение к своей базе данных необходимо поменять строку подключения.  
Для этого используйте команду описаную выше, где строка подключения будет иметь вид:  
<h4 align=center > Host={ваш хост};Database={ваша база данных};Username={имя вашего пользователя};Password={ваш пароль};</h4>

* ### myApp 1  
Создание таблицы с полями ID, ФИО, дата рождения, пол.

* ### myApp connect 2 {Фамилия} {Имя} {Отчество} {Дата рождения} {Пол}
Добавление записи в базу даннных с соотвествующими параметрами.    
Важно! Добавление таких параметров, как фамилия, имя и отчество, происходит через **пробел**. Если добавлять параметры как-то иначе, то возможна некорректная работа приложения.  
Также важно учитывать формат вводимой даты рождения, он должен быть в формете **гггг.мм.дд**

* ### myApp 3
Вывод всех строк с уникальными значениеми по полям ФИО и дата

* ### myApp 4
Автоматическое заполнение 1000000 строк и заполнение 100 строк начинающихся на "F"

* ### myApp 5
Замер получения выборки по полу(мужской) и первой букве ФИО