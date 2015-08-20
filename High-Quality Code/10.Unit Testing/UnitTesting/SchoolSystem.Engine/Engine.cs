namespace SchoolSystem.Engine
{
    using log4net;
    using log4net.Config;
    using SchoolSystem;
    using System;

    public class Engine
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Engine));

        public static void Main()
        {
            XmlConfigurator.Configure();
            Course course = null;

            try
            {
                course = new Course(null);
            }
            catch (ArgumentException e)
            {
                log.Error(e.Message);
            }

            if (course != null)
            {
                log.Info("Course created");
            }
        }
    }
}