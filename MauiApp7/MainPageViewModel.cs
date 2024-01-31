using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiApp7;

public class MainPageViewModel
{
    public ObservableCollection<Item> Items { get; set; }

    public MainPageViewModel()
    {
        Items = new ObservableCollection<Item>();
        LoadDataCommand = new Command(() =>
        {
            Items.Clear();
            var random = new Random();
            var template = random.Next(1, 3);
            for (var i = 0; i < 15; ++i)
            {
                var size = random.Next(200, 400);
                var text = "https://picsum.photos/" + size;
                Items.Add(new Item
                {
                    Text = text,
                    Template = template,
                    Size = size
                });
            }
        });
    }

    public ICommand LoadDataCommand { get; }
}