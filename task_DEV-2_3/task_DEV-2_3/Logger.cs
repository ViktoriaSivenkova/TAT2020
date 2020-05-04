using System.Diagnostics;
using System.Linq;
using log4net;
using log4net.Config;

namespace ContainersTAF_UI.Logger
{
    public class Logger
    {
        private static Logger Instance { get; set; }
        private static ILog _logger;
        private static StackFrame StackFrame => new StackFrame(3,true);

        private Logger()
        {
            InitLogger();
            _logger = LogManager.GetLogger("Logger");
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>The get instance.</value>
        public static Logger GetInstance
        {
            get
            {
                var logger = Instance;
                if (logger != null)
                {
                    return logger;
                }

                return Instance = new Logger();
            }
        }


        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void LogInfo(string message, params object[] parameters)
        {
            _logger.Info(GetFormattedMessage(message, parameters) + " in line " + StackFrame.GetFileLineNumber());
        }

        /// <summary>
        /// Logs the warning.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void LogWarning(string message, params object[] parameters)
        {
            _logger.Warn(GetFormattedMessage(message, parameters) + " in line " + StackFrame.GetFileLineNumber());
        }

        /// <summary>
        /// Logs the fatal.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void LogFatal(string message, params object[] parameters)
        {
            _logger.Fatal(GetFormattedMessage(message, parameters) + " in line " + StackFrame.GetFileLineNumber());
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void LogError(string message, params object[] parameters)
        {
            _logger.Error(GetFormattedMessage(message, parameters) + " in line " + StackFrame.GetFileLineNumber());
        }

        /// <summary>
        /// Logs the debug.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        public void LogDebug(string message, params object[] parameters)
        {
            _logger.Debug(GetFormattedMessage(message, parameters) + " in line " + StackFrame.GetFileLineNumber());
        }

        /// <summary>
        /// Gets the formatted message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String.</returns>
        private static string GetFormattedMessage(string message, params object[] parameters)
        {
            if (parameters != null && parameters.Any())
            {
                message = string.Format(message, parameters);
            }

            return message;
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <returns>ILog.</returns>
        public static ILog GetLogger()
        {
            return _logger;
        }

        /// <summary>
        /// Initializes the logger.
        /// </summary>
        public static void InitLogger()
        {
            XmlConfigurator.Configure();
        }
    }
}