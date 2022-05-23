using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.ConcreteProcessors
{
    public class ProcessMeetings: Abstract.IProcessMeetings
    {

        public IEnumerable<ConcreteEntities.Meeting> Meetings
        {
            get
            {
                List<CRS.Domain.ConcreteEntities.Meeting> objL;
                objL = new List<CRS.Domain.ConcreteEntities.Meeting>();
                string strSQLCode = @"Select MeetingID, MeetingSubject, MeetingDate, MeetingHour, ConferenceRoomID
                                        From [dbo].[vMeetings]";
                System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
                try
                {
                    var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.Text, strSQLCode);
                    objCon.Open();
                    var objDR = objCmd.ExecuteReader();
                    while (objDR.Read())
                    {
                        ConcreteEntities.Meeting objM = new ConcreteEntities.Meeting();
                        objM.MeetingID = (int)objDR["MeetingID"];
                        objM.MeetingSubject = (string)objDR["MeetingSubject"];
                        objM.MeetingDate = (DateTime)objDR["MeetingDate"];
                        objM.MeetingHour = (int)objDR["MeetingHour"];
                        objM.ConferenceRoomID = (int)objDR["ConferenceRoomID"];
                        objL.Add(objM);
                    }
                    objDR.Close();
                }
                catch { throw; }
                finally
                {
                    objCon.Close();
                }
                return objL;
            }
        }

        public int pInsMeeting(ConcreteEntities.Meeting Meeting)
        {
            string strSQLCode = @"pInsMeeting";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@MeetingSubject";
            objP1.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP1.Size = 100;
            objP1.Value = Meeting.MeetingSubject;
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@MeetingDate";
            objP2.SqlDbType = System.Data.SqlDbType.DateTime;
            //objP2.Size = 100;
            objP2.Value = Meeting.MeetingDate;
            lstParms.Add(objP2);

            System.Data.SqlClient.SqlParameter objP3 = new System.Data.SqlClient.SqlParameter();
            objP3.Direction = System.Data.ParameterDirection.Input;
            objP3.ParameterName = "@MeetingHour";
            objP3.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP3.Value = Meeting.MeetingHour;
            lstParms.Add(objP3);

            System.Data.SqlClient.SqlParameter objP4 = new System.Data.SqlClient.SqlParameter();
            objP4.Direction = System.Data.ParameterDirection.Input;
            objP4.ParameterName = "@ConferenceRoomID";
            objP4.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP4.Value = Meeting.ConferenceRoomID;
            lstParms.Add(objP4);

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

        public int pUpdMeetings(ConcreteEntities.Meeting Meeting)
        {
            string strSQLCode = @"pUpdMeetings";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@MeetingID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP1.Value = Meeting.MeetingID;
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@MeetingSubject";
            objP2.SqlDbType = System.Data.SqlDbType.NVarChar;
            objP2.Size = 100;
            objP2.Value = Meeting.MeetingSubject;
            lstParms.Add(objP2);

            System.Data.SqlClient.SqlParameter objP3 = new System.Data.SqlClient.SqlParameter();
            objP3.Direction = System.Data.ParameterDirection.Input;
            objP3.ParameterName = "@MeetingDate";
            objP3.SqlDbType = System.Data.SqlDbType.DateTime;
            //objP2.Size = 100;
            objP3.Value = Meeting.MeetingDate;
            lstParms.Add(objP3);

            System.Data.SqlClient.SqlParameter objP4 = new System.Data.SqlClient.SqlParameter();
            objP4.Direction = System.Data.ParameterDirection.Input;
            objP4.ParameterName = "@MeetingHour";
            objP4.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP4.Value = Meeting.MeetingHour;
            lstParms.Add(objP4);

            System.Data.SqlClient.SqlParameter objP5 = new System.Data.SqlClient.SqlParameter();
            objP5.Direction = System.Data.ParameterDirection.Input;
            objP5.ParameterName = "@ConferenceRoomID";
            objP5.SqlDbType = System.Data.SqlDbType.Int;
            //objP3.Size = 100;
            objP5.Value = Meeting.ConferenceRoomID;
            lstParms.Add(objP5);

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

        public int pDelMeetings(ConcreteEntities.Meeting Meeting)
        {
            string strSQLCode = @"pDelMeetings";
            System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
            List<System.Data.SqlClient.SqlParameter> lstParms = new List<System.Data.SqlClient.SqlParameter>();

            System.Data.SqlClient.SqlParameter objP1 = new System.Data.SqlClient.SqlParameter();
            objP1.Direction = System.Data.ParameterDirection.Input;
            objP1.ParameterName = "@MeetingID";
            objP1.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP1.Value = Convert.ToInt32(Meeting.MeetingID);
            lstParms.Add(objP1);

            System.Data.SqlClient.SqlParameter objP2 = new System.Data.SqlClient.SqlParameter();
            objP2.Direction = System.Data.ParameterDirection.Input;
            objP2.ParameterName = "@ConferenceRoomID";
            objP2.SqlDbType = System.Data.SqlDbType.Int;
            //objP1.Size = 100;
            objP2.Value = Convert.ToInt32(Meeting.ConferenceRoomID);
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
