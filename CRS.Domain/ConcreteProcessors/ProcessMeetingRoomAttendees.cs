using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRS.Domain.ConcreteProcessors
{
    public class ProcessMeetingRoomAttendees: Abstract.IProcessMeetingRoomAttendees
    {
        public IEnumerable<ConcreteEntities.MeetingRoomAttendee> MeetingRoomAttendees
        {
            get
            {
                List<CRS.Domain.ConcreteEntities.MeetingRoomAttendee> objL;
                objL = new List<CRS.Domain.ConcreteEntities.MeetingRoomAttendee>();
                string strSQLCode = @"Select MeetingID, MeetingSubject, MeetingDate, MeetingHour, ConferenceRoomID, ConferenceRoomName, ConferenceRoomFloor, ConferenceRoomLocation, AttendeeID, AttendeeName, AttendeeEmail, AttendeePhone From [dbo].[vMeetingRoomAttendees]";
                System.Data.SqlClient.SqlConnection objCon = ADONetFactories.GetConnectionObject();
                try
                {
                    var objCmd = ADONetFactories.GetCommandObject(objCon, System.Data.CommandType.Text, strSQLCode);
                    objCon.Open();
                    var objDR = objCmd.ExecuteReader();
                    while (objDR.Read())
                    {
                        ConcreteEntities.MeetingRoomAttendee objMRA = new ConcreteEntities.MeetingRoomAttendee();
                        objMRA.MeetingID = (int)objDR["MeetingID"];
                        objMRA.MeetingSubject = (string)objDR["MeetingSubject"];
                        objMRA.MeetingDate = (DateTime)objDR["MeetingDate"];
                        objMRA.MeetingHour = (int)objDR["MeetingHour"];

                        objMRA.ConferenceRoomID = (int)objDR["ConferenceRoomID"];
                        objMRA.ConferenceRoomName = (string)objDR["ConferenceRoomName"];
                        objMRA.ConferenceRoomFloor = (int)objDR["ConferenceRoomFloor"];
                        objMRA.ConferenceRoomLocation = (string)objDR["ConferenceRoomLocation"];

                        objMRA.AttendeeID = (int)objDR["AttendeeID"];
                        objMRA.AttendeeName = (string)objDR["AttendeeName"];
                        objMRA.AttendeeEmail = (string)objDR["AttendeeEmail"];
                        objMRA.AttendeePhone = (string)objDR["AttendeePhone"];
                        objL.Add(objMRA);
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
    }
}
