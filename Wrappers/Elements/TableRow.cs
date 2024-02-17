using OpenQA.Selenium;

namespace Wrappers.Elements;

public class TableRow
{
    private UIElement _uiElement;
    private List<TableCell> _cells;
    
    public TableRow(UIElement uiElement)
    {
        _uiElement = uiElement;
        _cells = new List<TableCell>();

        foreach (var cellElement in _uiElement.FindUIElements(By.TagName("td")))
        {
            _cells.Add(new TableCell(cellElement));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="columnIndex"></param>
    public TableCell GetCell(int columnIndex)
    {
       //Поиск ячейки
        return _cells[columnIndex];
    }
}