using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.ConcreteProcessors
{
    static class ADONetFactories
    {
        public static System.Data.SqlClient.SqlConnection GetConnectionObject()
        {
            //String strConnection = "Data Source=localhost; Integrated Security=SSPI;Initial Catalog=ConferenceRoomScheduler";
            string strConnection = @"Data Source=JACK-LAPTOP\SQL2014;Initial Catalog=ConferenceRoomScheduler;Integrated Security=True";
            System.Data.SqlClient.SqlConnection objCon;
            try
            {
                objCon = new System.Data.SqlClient.SqlConnection(strConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objCon;
        }


        public static System.Data.SqlClient.SqlCommand GetCommandObject(System.Data.SqlClient.SqlConnection Connection
                                                                        , System.Data.CommandType CommandType
                                                                        , string Command)
        {
            System.Data.SqlClient.SqlCommand objCmd;
            try
            {
                objCmd = new System.Data.SqlClient.SqlCommand();
                objCmd.Connection = Connection;
                objCmd.CommandType = CommandType;
                objCmd.CommandText = Command;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objCmd;
        }
    }
}

//Adding Parameters to Commands
//http://www.csharp-station.com/tutorials/adodotnet/lesson06.aspx

//Using Stored Procedures
//http://www.csharp-station.com/tutorials/adodotnet/lesson07.aspx

//Command parameters
//http://dotnetfacts.blogspot.com/2009/01/adonet-command-parameters.html

//Modifying Data with Stored Procedures (ADO.NET)
//http://msdn.microsoft.com/en-us/library/59x02y99.aspx
