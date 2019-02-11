using System.Threading.Tasks;
using WidgetFramework.Contracts;
using WidgetFramework.Contracts.Configuration;
using WidgetFramework.Contracts.Container;

namespace WidgetFramework.Consumer
{
    public class MyWidget : IWidget
    {
        public string WidgetName => "My Widget";

        public Task InitializeWidget()
        {
            throw new System.NotImplementedException();
        }

        public void ConfigureWidget(IConfiguration configuration)
        {
            configuration.AddDependency<IAnotherWidget>();
        }
    }

    public interface IAnotherWidget : IWidgetDependency
    {
    }
}