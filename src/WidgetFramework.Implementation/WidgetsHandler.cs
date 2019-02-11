using System.Collections.Generic;
using WidgetFramework.Contracts;
using WidgetFramework.Implementation.Configuration;

namespace WidgetFramework.Implementation
{
    public class WidgetsHandler
    {
        private readonly IEnumerable<IWidget> m_widget;

        //Injecting all available widgets
        public WidgetsHandler(IEnumerable<IWidget> widgets)
        {
            m_widget = widgets;
        }

        private async void Initialize()
        {
            //Read widgets setup
            foreach (var widget in m_widget)
            {
                var widgetConfiguration = new Configuration.Configuration();
                widget.ConfigureWidget(widgetConfiguration);
                await widget.InitializeWidget();
            }

            //Initialize widgets
            foreach (var widget in m_widget)
            {
                await widget.InitializeWidget();
            }
        }
    }
}
