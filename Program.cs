using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Clockwork;

namespace JTL_Wawi_Clockwork
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (args[1].StartsWith("0") && !args[1].StartsWith("00")) args[1] = args[3] + args[1].Substring(1); // 01 == 491
            else if (args[1].StartsWith("00")) args[1] = args[1].Substring(2); //0049 => 49

            try

            {
                Clockwork.API api = new API(args[0]);
                SMSResult result = api.Send(
                    new SMS
                    {
                        To = args[1],
                        Message = args[2]
                    });

                if (result.Success)
                {
                    Console.WriteLine("SMS Sent to {0}, Clockwork ID: {1}",
                        result.SMS.To, result.ID);
                }
                else
                {
                    Console.WriteLine("SMS to {0} failed, Clockwork Error: {1} {2}",
                        result.SMS.To, result.ErrorCode, result.ErrorMessage);
                }
            }
            catch (APIException ex)
            {
                // You’ll get an API exception for errors
                // such as wrong username or password
                Console.WriteLine("API Exception: " + ex.Message);
            }
            catch (WebException ex)
            {
                // Web exceptions mean you couldn’t reach the Clockwork server
                Console.WriteLine("Web Exception: " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Argument exceptions are thrown for missing parameters,
                // such as forgetting to set the username
                Console.WriteLine("Argument Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Something else went wrong, the error message should help
                Console.WriteLine("Unknown Exception: " + ex.Message);
            }
        }
    }
}