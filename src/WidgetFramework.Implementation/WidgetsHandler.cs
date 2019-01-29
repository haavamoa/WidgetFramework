using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WidgetFramework.Contracts;

namespace WidgetFramework.Implementation
{
    public class WidgetsHandler
    {
        private IEnumerable<IWidget> m_widget;

        public WidgetsHandler(IEnumerable<IWidget> widgets)
        {
            m_widget = widgets;
        }
    }
}
