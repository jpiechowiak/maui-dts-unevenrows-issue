namespace MauiApp7;

public class ListSelector : DataTemplateSelector
{
    public DataTemplate EvenTemplate { get; set; }
    public DataTemplate OddTemplate { get; set; }

    protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
    {
        return ((Item)item).Template % 2 == 0 ? EvenTemplate : OddTemplate;
    }
}