// LearnCShap_SVG
// SVGClassLibrary
// ISVG_Tag.cs
// ---------------------------------------------
// Alex Samarkin
// Alex
// 
// 0:46 06 12 2021

namespace SVGClassLibrary
{
    /// <summary>
    /// интерфейс любого элемента SVG
    /// </summary>
    public interface ISVG_Tag
    {
        /// <summary>
        /// начальный элемент тега
        /// </summary>
        /// <returns>строка с начальным элементом тега, например <g></returns>
        string GenerateStart();
        /// <summary>
        /// содержание тега, включая другие теги
        /// </summary>
        /// <returns>строка содержания</returns>
        string GenerateText();
        /// <summary>
        /// завершающий элемент тега
        /// </summary>
        /// <returns>завершающий элемент, например </g></returns>
        string GenerateEnd();

        /// <summary>
        /// полная строка тега, как правило Start Text End
        /// </summary>
        /// <returns>Строка тега</returns>
        string GenerateTag();
    }
}