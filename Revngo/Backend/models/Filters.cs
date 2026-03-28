namespace Revngo.Api.models;

public class FilterItem
{
    public string Key { get; set; }
    public string Label { get; set; }
    public string? Icon { get; set; }
}
public class FilterSection
{
    public string Key { get; set; }

    public string Title { get; set; }

    public string OptionsText { get; set; }

    public string Type { get; set; }

    public List<FilterItem> Items { get; set; }
}