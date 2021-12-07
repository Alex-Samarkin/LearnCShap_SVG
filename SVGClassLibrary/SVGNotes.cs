﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVGClassLibrary
{
    public class SVGNotes
    {
        public static string Intro =
            @"SVG - файл векторной графики, элементы файла напоминают теги HTML,
сам файл является текстовым файлом и отображается, в частности, браузерами.
Мы будем использовать формат SVG как базу для создания графиков.
";

        public static string Ch1 =
            @"Первый этап - создаем контейнер для элементов графики, файл с расширением svg,
и StringBuilder для сбора строк и вывода их в файл.
";
        public static string Ch2 =
            @"Второй этап - создаем базовый класс графических элементов.

Теоретически SVG - это бесконечная плоскость для рисования, но мы задаем ее размеры 1600*900
ось x смотрит вправо, y вниз, 0 в верхнем левом углу
Базовый класс переносит 0 влево вниз, поворачивает (по умолчанию) ось y вверх, для привычных координат

Остальные элементы графики происходят от этого базового элемента.


Основной метод базы - ""формирование"" строки для файла SVG
Производные классы переопределяют этот метод, чтобы правильно отрисовывать себя

Для хранения цвета заливки и линии создан класс Brush 
Для хранения координат - Point

Элемент линия задается цветом и двумя точками (например)

В SVG документе создаем контейнер для хранения элементов 
и метод для развертывания каждого элемента контейнера в тег SVG.
_______________________________________________________________________________________
*** Если файл не открывается автоматически, переименуйте его в *.html и откройте в Edge
";

        public static string Ch3 =
            @"Третий этап - окружность (см. наследование. Почему от прямой линии? Как задан центр?), 
эллипс, прямоугольник, т.е. элементы с контуром и заливкой.";
    }
}
