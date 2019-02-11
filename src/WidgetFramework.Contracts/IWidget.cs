using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using WidgetFramework.Contracts.Configuration;

namespace WidgetFramework.Contracts
{
    public interface IWidget
    {
        string WidgetName { get; }
        Task InitializeWidget();
        void ConfigureWidget(IConfiguration configuration);
    }
}