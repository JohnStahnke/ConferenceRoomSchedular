using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.ConcreteProcessors
{
    class ProcessMeetingAttendees: Abstract.IProcessMeetingAttendees
    {
        public IEnumerable<ConcreteEntities.MeetingAttendee> MeetingAttendees
        {
            //I don't see anwhere a list of MeetingAttendees is used.
            get { throw new NotImplementedException(); }
        }

        public int pInsMeetingsAttendees(ConcreteEntities.MeetingAttendee MeetingAttendee)
        {
            string strSQLCode = @"pInsMeetingsAttendees";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@MeetingID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(MeetingAttendee.MeetingID);
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@AttendeeID";
            objP2.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(MeetingAttendee.AttendeeID);
            lstParms.Add(objP2);

            try
            {
                var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.StoredProcedure, strSQLCode);
                objCmd.Parameters.AddRange(lstParms.ToArray<System.Data.SqlClient.SqlParameter>());
                objCon.Open();
                var objDR = objCmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { objCon.Close(); }
            return 100;
        }

        public int pUpdMeetingsAttendees(ConcreteEntities.MeetingAttendee MeetingAttendee)
        {
            string strSQLCode = @"pUpdMeetingsAttendees";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@MeetingID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(MeetingAttendee.MeetingID);
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@AttendeeID";
            objP2.SqlDbType = System.Data.SqlDbType.Int;
            //objP2.Size = 100;
            objP2.Value = Convert.ToInt32(MeetingAttendee.AttendeeID);
            lstParms.Add(objP2);


            try
            {
                var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.StoredProcedure, strSQLCode);
                objCmd.Parameters.AddRange(lstParms.ToArray<System.Data.SqlClient.SqlParameter>());
                objCon.Open();
                var objDR = objCmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { objCon.Close(); }
            return 100;
        }

        public int pDelMeetingsAttendees(ConcreteEntities.MeetingAttendee MeetingAttendee)
        {
            string strSQLCode = @"pDelMeetingsAttendees";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@MeetingID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(MeetingAttendee.MeetingID);
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@AttendeeID";
            objP2.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP2.Value = Convert.ToInt32(MeetingAttendee.AttendeeID);
            lstParms.Add(objP2);

            try
            {
                var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.StoredProcedure, strSQLCode);
                objCmd.Parameters.AddRange(lstParms.ToArray<System.Data.SqlClient.SqlParameter>());
                objCon.Open();
                var objDR = objCmd.ExecuteNonQuery();
            }
            catch { throw; }
            finally { objCon.Close(); }
            return 100;
        }
    }
}
