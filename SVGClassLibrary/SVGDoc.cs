// LearnCShap_SVG
// SVGClassLibrary
// SVGDoc.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 0:30 05 12 2021

using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace SVGClassLibrary
{
    /// <summary>
    /// файл svg
    /// </summary>
    public class SVGDoc
    {
        #region Базовые определения

        /// <summary>
        /// имя файла без расширения
        /// </summary>
        public string FileName { get; set; } = "graphic";
        /// <summary>
        /// расширение - svg
        /// </summary>
        public string Ext { get; set; } = "svg";
        /// <summary>
        /// полное имя файла конструируется по имени и расширению
        /// </summary>
        public string FullFileName => $"{FileName}.{Ext}";
        /// <summary>
        /// конструктор строк
        /// генерируется заголовок файла, его окончание и содержание
        /// далее оно записывается в текстовый файл
        /// </summary>
        public StringBuilder SB { get; } = new StringBuilder();

        /// <summary>
        /// запись содержимого SB в файл
        /// </summary>
        public void WriteToFile()
        {
            File.WriteAllText(FullFileName,SB.ToString(),Encoding.UTF8);
        }
        /// <summary>
        /// показать ранее созданный файл в приложении по умолчанию
        /// если файл отсутствует, то ничего не произойдет
        /// </summary>
        public void ShowFile()
        {
            if (File.Exists(FullFileName))
            {
                Process.Start(FullFileName);
            }
        }

        #endregion

        #region Базовые теги

        /// <summary>
        /// начало файла, далее следует описание и размеры
        /// </summary>
        public string StartTag =>
            @"<?xml version=""1.0"" standalone=""no""?>";

        /// <summary>
        /// ширина, используем пиксели
        /// </summary>
        public int Width { get; set; } = 1600;
        /// <summary>
        /// высота в пикселях
        /// </summary>
        public int Height { get; set; } = 900;

        /// <summary>
        /// строка в документ с размерами документа
        /// </summary>
        public string SizeTag => $"<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\"" +
                              $" width=\"{Width}px\" height=\"{Height}px\">";
        /// <summary>
        /// заголовок
        /// </summary>
        public string Title { get; set; } = "SVG Title";
        /// <summary>
        /// описание как свойство
        /// </summary>
        public string Description { get; set; } = "SVG Description";

        /// <summary>
        /// строка с заголовком и описанием в документе
        /// g - группирует теги
        /// </summary>
        public String DescriptionTag => $"<g>\r\n" + 
                                        $"<title>{Title}</title>\r\n" +
                                        $"<desc>\r\n{Description}\r\n</desc>\r\n" +
                                        $"<!-- Это комментарий внутри SVG -->\r\n" +
                                        $"</g>";

        /// <summary>
        /// генерация шапки
        /// </summary>
        /// <returns>строка с содержимым</returns>
        public string GenerateStart()
        {
            SB.AppendLine(StartTag);
            SB.AppendLine(SizeTag);
            SB.AppendLine(DescriptionTag);
            // для отладки
            return SB.ToString();
        }
        /// <summary>
        /// завершающий тег документа
        /// </summary>
        public string EndTag => "</svg>\r\n"+ "<!-- SVG создан -->\r\n";
        /// <summary>
        /// добавление закрывающего элемент тега
        /// </summary>
        /// <returns>строка завершающего тега</returns>
        public string GenerateEnd()
        {
            SB.AppendLine(EndTag);
            // для отладки
            return SB.ToString();
        }

        #endregion
    }
}