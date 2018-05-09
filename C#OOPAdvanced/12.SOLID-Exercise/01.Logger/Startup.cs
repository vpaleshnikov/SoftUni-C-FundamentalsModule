using Problem1_Logger.Core;
using Problem1_Logger.Core.Contracts;
using Problem1_Logger.Core.Factories;
using Problem1_Logger.Models.Appenders.Contracts;
using Problem1_Logger.Models.Layouts.Contracts;

namespace Problem1_Logger
{
    public class Startup
    {
        public static void Main()
        {
            IFactory<IAppender> appenderFactory = new AppenderFactory<IAppender>();
            IFactory<ILayout> layoutFactory = new LayoutFactory<ILayout>();
            IEngine engine = new Engine(appenderFactory, layoutFactory);
            engine.Run();
        }
    }
}