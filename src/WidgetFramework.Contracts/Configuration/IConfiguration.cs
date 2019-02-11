namespace WidgetFramework.Contracts.Configuration
{
    public interface IConfiguration
    {
        /// <summary>
        /// Default is <see cref="WidgetUsage.DefaultPartOfTheClient"/>
        /// </summary>
        WidgetUsage Usage { get; set; }

        void AddDependency<T>();
    }
}